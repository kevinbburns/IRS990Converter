using System.Dynamic;
using System.Net;
using System.Text;
using System.Xml;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Formatting = Newtonsoft.Json.Formatting;

string connectString =
    "SuperSecretCosmosDbConnectionString";

var baseMainFolder = "/home/kburns/irs990/";
string xmlMainFolder = "/home/kburns/irs990/xml/";
string jsonMainFolder = "/home/kburns/irs990/json/";

var dI = new DirectoryInfo(xmlMainFolder);
var diErrorMessages = new DirectoryInfo
    (Path.Combine(baseMainFolder, "ErrorMessages"));
if (!diErrorMessages.Exists)
    diErrorMessages.Create();

var jsonFolder = new DirectoryInfo(jsonMainFolder);
if (!jsonFolder.Exists)
    jsonFolder.Create();

await UploadLocalToAzure()
    .ConfigureAwait(false);

async Task GetDocumentProperities()
{
    var jsonFiles = jsonFolder.GetFiles();
    await using var fStream = jsonFiles[0].OpenRead();
    using var stringReader = new StreamReader(fStream);
    var j1 = JObject.Parse(await stringReader.ReadToEndAsync());

    var cnt = 1;
    foreach (var jsonFile in jsonFiles)
    {
        Console.WriteLine($"\r Merging {jsonFile.Name} : {cnt} of {jsonFiles.Length - 1}");
        using var stream = jsonFile.OpenRead();
        using var reader = new StreamReader(stream);
        var j2 = JObject.Parse(await reader.ReadToEndAsync());

        j1.Merge(j2, new JsonMergeSettings()
        {
            MergeNullValueHandling = MergeNullValueHandling.Merge,
            MergeArrayHandling = MergeArrayHandling.Union
        });

        cnt++;
    }

    await using var outputStream = File.Create(System.IO.Path.Combine(baseMainFolder, "output.json"));
    await using var streamWriter = new StreamWriter(outputStream);
    await streamWriter.WriteAsync(j1.ToString());
}

async Task UploadLocalToAzure()
{
    var files = jsonFolder.GetFiles("*.json",
        SearchOption.AllDirectories);

    Console.WriteLine("Starting the conversion process and uploading.....\n");

    CosmosClientOptions options = new CosmosClientOptions() {AllowBulkExecution = true};
    using var cosmosContext = new CosmosClient(connectString, options);
    var container = cosmosContext.GetContainer("irs990returns", "return_data");

    var tasks = new List<Task>();

    Console.WriteLine("Getting Previously Uploaded Files");
    
    var importedFiles = await GetImportedFiles();

    long fileRemainCnt = files.Length;
    int taskListCnt = 0;
    int completedFiles = 0;
    int errors = 0;

    Parallel.ForEach(files, new ParallelOptions
        {MaxDegreeOfParallelism = Environment.ProcessorCount - 2}, file =>
    {
        if (importedFiles.Contains(file.Name))
        {
            fileRemainCnt -= 1;
            Console.Write("\r File Cnt: {0} File Cnt Remain: {1} Task Cnt: {2} Comp: {3} Errors: {4}  ", 
                file.Name,
                fileRemainCnt.ToString(),
                taskListCnt.ToString(),
                completedFiles.ToString(),
                errors.ToString()
                );
            
            return;
        }
        
        try
        {
            using var fStream = File.OpenRead(file.FullName);
            using var streamReader = new StreamReader(fStream);
            
            dynamic jsonObjReturn =
                JsonConvert.DeserializeObject<ExpandoObject>(streamReader.ReadToEnd()
                    , new ExpandoObjectConverter());

            streamReader.DiscardBufferedData();
            streamReader.Dispose();
            fStream.Dispose();

            if (jsonObjReturn == null)
            {
                errors += 1;
                throw new Exception("File Not Proper Format.");
            }

            taskListCnt += 1;
            
            Console.Write("\r File Cnt: {0} File Cnt Remain: {1} Task Cnt: {2} Comp: {3} Errors: {4}  ", 
                file.Name,
                fileRemainCnt.ToString(),
                taskListCnt.ToString(),
                completedFiles.ToString(),
                errors.ToString()
            );

            tasks.Add(container.CreateItemAsync(jsonObjReturn as ExpandoObject, new PartitionKey(jsonObjReturn.TaxYr))
                .ContinueWith(itemResponse =>
                {
                    taskListCnt -= 1;
                    
                    if (itemResponse.IsCompletedSuccessfully)
                    {
                        completedFiles += 1;
                        fileRemainCnt -= 1;
                        
                        Console.Write("\r File Cnt: {0} File Cnt Remain: {1} Task Cnt: {2} Comp: {3} Errors: {4}  ", 
                            file.Name,
                            fileRemainCnt.ToString(),
                            taskListCnt.ToString(),
                            completedFiles.ToString(),
                            errors.ToString()
                        );
                    }
                    else
                    {
                        errors += 1;
                        fileRemainCnt -= 1;
                        
                        Console.Write("\r File Cnt: {0} File Cnt Remain: {1} Task Cnt: {2} Comp: {3} Errors: {4}  ", 
                            file.Name,
                            fileRemainCnt.ToString(),
                            taskListCnt.ToString(),
                            completedFiles.ToString(),
                            errors.ToString()
                        );
                        
                        if (!itemResponse.IsCompletedSuccessfully)
                        {
                            AggregateException innerExceptions = itemResponse.Exception.Flatten();
                            if (innerExceptions.InnerExceptions.FirstOrDefault(innerEx => innerEx is CosmosException) is
                                CosmosException cosmosException)
                            {
                                WriteMessageToWall(file, 
                                    new Exception($"Received " +
                                                  $"{cosmosException.StatusCode} ({cosmosException.Message}"));
                            }
                            else
                            {
                                WriteMessageToWall(file, 
                                    new Exception($"Exception " +
                                                  $"{innerExceptions.InnerExceptions.FirstOrDefault()}."));
                            }
                        }
                    }
                }));
        }
        catch (Exception exp)
        {
            Console.Write("\r File Cnt: {0} File Cnt Remain: {1} Task Cnt: {2} Comp: {3} Errors: {4}  ", 
                file.Name,
                fileRemainCnt.ToString(),
                taskListCnt.ToString(),
                completedFiles.ToString(),
                errors.ToString()
            );

            WriteMessageToWall(file, exp);
        }
    });

    await Task.WhenAll(tasks).ConfigureAwait(false);
}

async Task<IReadOnlyCollection<string>> GetImportedFiles(string fileNameBeginsWithYear)
{
    CosmosClientOptions options = new CosmosClientOptions() {AllowBulkExecution = true};
    using var cosmosContext = new CosmosClient(connectString, options);
    var container = cosmosContext.GetContainer("irs990returns", "return_data");

    var list = new List<string>();

    //Each year's worth of returns consists of a handful of zips, usually around 8. To make
    //life easier, I had broken everything down into years. The last round of data, and most
    //recently released happened to be 2020 in this case. In a previous version, I had created
    //a task for each year, and ran it through a list, i.e. list<Task>{ task2015,task2016,task2017,task2018};
    //and did a Task.WhenAll(listOfTasks.) That worked great, but your computer is unusuable about the entire time.
    var irs990Iterator =
        container.GetItemQueryIterator<string>
            ($"SELECT distinct value c.file_name FROM c where c.file_name like \"{fileNameBeginsWithYear}%\"");

    var res = await irs990Iterator.ReadNextAsync();
    foreach (var prevFile in res.Resource)
        list.Add(prevFile.Replace(".xml", ".json"));

    while (irs990Iterator.HasMoreResults)
    {
        res = await irs990Iterator.ReadNextAsync();
        foreach (var prevFile in res.Resource)
                    list.Add(prevFile.Replace(".xml", ".json"));
    }

    return list.AsReadOnly();
}

async Task InsertJsonObjIntoDb(ExpandoObject? jsonObj
    , Container container, FileInfo f)
{
    try
    {
        try
        {
            string? taxYr = ((IDictionary<string, object>) jsonObj)["TaxYr"]?.ToString();
            if (string.IsNullOrEmpty(taxYr))
            {
                Console.WriteLine("JsonObj TaxYr Missing");
            }
            else
            {
                Console.WriteLine($"File Converting {f.Name}");
                await container.CreateItemAsync
                    (jsonObj, new PartitionKey(taxYr));
            }
        }
        catch (Exception e)
        {
            try
            {
                var jString = jsonObj.ToString();
                dynamic json =
                    JsonConvert.DeserializeObject<ExpandoObject>(
                        jString,
                        new ExpandoObjectConverter()
                    );

                var dict = (IDictionary<string, object>) json;
                var containsTaxYr = dict.ContainsKey("TaxYr");
                if (containsTaxYr)
                {
                    var taxYr = dict["TaxYr"]?.ToString();
                    if (string.IsNullOrEmpty(taxYr))
                        throw;

                    Console.WriteLine($"File Converting {f.Name}");
                    await container.CreateItemAsync
                        (jsonObj, new PartitionKey(taxYr));
                }
            }
            catch
            {
                WriteMessageToWall(f, e);
            }
        }
    }
    catch (CosmosException cExp)
    {
        if (cExp.StatusCode == HttpStatusCode.Conflict)
        {
            Console.WriteLine($"File Upload {f.Name} Recv. Conflict Status Code");
            return;
        }

        WriteMessageToWall(f,
            new Exception($"Received {cExp.StatusCode} " +
                          $"({cExp.Message})."));
    }
    catch (AggregateException aExp)
    {
        AggregateException? innerExceptions = aExp?.Flatten();
        if (innerExceptions?.InnerExceptions.FirstOrDefault(innerEx => innerEx
                is CosmosException) is CosmosException cosmosException)
        {
            if (cosmosException.StatusCode == HttpStatusCode.Conflict)
            {
                return;
            }

            WriteMessageToWall(f,
                new Exception($"Received {cosmosException.StatusCode} " +
                              $"({cosmosException.Message})."));
        }
        else
        {
            WriteMessageToWall(f,
                new Exception($"Exception {innerExceptions?.InnerExceptions.FirstOrDefault()}."));
        }
    }
    catch (Exception exp)
    {
        WriteMessageToWall(f, exp);
    }
}

async Task ConvertJsonTextFileAndCreateStream(FileInfo f,
    Container container)
{
    try
    {
        Console.WriteLine($"File Converting {f.Name}");

        using FileStream fStream = f.OpenRead();
        using StreamReader reader = new StreamReader(fStream);

        dynamic json =
            JsonConvert.DeserializeObject<ExpandoObject>(await reader.ReadToEndAsync());

        await container.CreateItemAsync(json, new PartitionKey(json.TaxYr.ToString()));
    }
    catch (CosmosException cExp)
    {
        if (cExp.StatusCode == HttpStatusCode.Conflict)
        {
            Console.WriteLine($"File Upload {f.Name} Recv. Conflict Status Code");
            return;
        }

        WriteMessageToWall(f,
            new Exception($"Received {cExp.StatusCode} " +
                          $"({cExp.Message})."));
    }
    catch (AggregateException aExp)
    {
        AggregateException? innerExceptions = aExp?.Flatten();
        if (innerExceptions?.InnerExceptions.FirstOrDefault(innerEx => innerEx
                is CosmosException) is CosmosException cosmosException)
        {
            if (cosmosException.StatusCode == HttpStatusCode.Conflict)
            {
                return;
            }

            WriteMessageToWall(f,
                new Exception($"Received {cosmosException.StatusCode} " +
                              $"({cosmosException.Message})."));
        }
        else
        {
            WriteMessageToWall(f,
                new Exception($"Exception" +
                              $" {innerExceptions?.InnerExceptions.FirstOrDefault()}."));
        }
    }
    catch (Exception exp)
    {
        WriteMessageToWall(f, exp);
    }
}


async Task<ExpandoObject?> ConvertXmlToJsonObj(FileInfo f)
{
    try
    {
        var xml = new XmlDocument();
        xml.Load(f.OpenRead());
        string jsonString = JsonConvert.SerializeXmlNode(xml, Formatting.None);

        dynamic json =
            JsonConvert.DeserializeObject<ExpandoObject>(
                jsonString,
                new ExpandoObjectConverter()
            );

        var dict = (IDictionary<string, object>) json;
        dict.Remove("?xml");

        if (!dict.ContainsKey("Return"))
            throw new Exception($"JSON String : {jsonString}");

        var r = dict["Return"];
        var returnJsonData = (IDictionary<string, object>) r;
        var rH = returnJsonData["ReturnHeader"];
        var rd = returnJsonData["ReturnData"];

        json.id = Guid.NewGuid().ToString();
        json.file_name = f.Name;

        var returnHeaderData = (IDictionary<string, object>) rH;
        var returnDataData = (IDictionary<string, object>) rd;

        foreach (KeyValuePair<string, object> keyValuePair in returnHeaderData)
            ((IDictionary<string, object>) json).Add(keyValuePair.Key, keyValuePair.Value);

        foreach (KeyValuePair<string, object> keyValuePair in returnDataData)
            ((IDictionary<string, object>) json).Add(keyValuePair.Key, keyValuePair.Value);

        dict.Remove("Return");
        dict.Remove("ReturnHeader");
        dict.Remove("ReturnData");

        Console.WriteLine($"\r Converting {f.Name}");

        var jsonOBj = JsonConvert
            .SerializeObject(json, Formatting.None)?.ToString() ?? "";

        if (string.IsNullOrEmpty(jsonOBj))
            throw new Exception($"{f.Name} Cannot Be Serialized Properly Back to JSON string.");

        await File.WriteAllTextAsync
        (Path.Combine(jsonFolder.FullName,
                f.Name.Replace(".xml", ".json"))
            , jsonOBj);

        return json;
    }
    catch (Exception e)
    {
        WriteMessageToWall(f, e);
        return null;
    }
}

void WriteMessageToWall(FileInfo fInfo, Exception exp)
{
    try
    {
        var newFName = fInfo.Name.Replace(".xml", "_err.txt");
        using var fStream = File.Create(Path.Combine(diErrorMessages.FullName, newFName));
        using var stringWriter = new StreamWriter(fStream);
        var sb = new StringBuilder();
        sb.Append($"Message:{exp.Message}");
        sb.Append($"Inner Message: {exp.InnerException?.Message}");
        sb.Append($"Stack : {exp.StackTrace ?? ""}");
        sb.Append($"Source : {exp.Source ?? ""}");

        stringWriter.WriteLine(sb.ToString());
    }
    catch
    {
        //DON'T DEAD OPEN INSIDE
    }
}
