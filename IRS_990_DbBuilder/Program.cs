using System.Dynamic;
using System.Text;
using System.Xml;
using Konsole;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Formatting = Newtonsoft.Json.Formatting;
using Path = System.IO.Path;

public static class InternalProgram
{
    private static readonly DirectoryInfo BaseMainFolder = new("/home/kburns/IRS_Data/");

    private static readonly DirectoryInfo XmlMainFolder = new(Path.Combine(BaseMainFolder.FullName, "xml"));

    private static readonly DirectoryInfo DiErrorMessages = new(Path.Combine(BaseMainFolder.FullName, "errors"));

    //This is assuming you already have a Database in your local MongoDb called "IRS990", 
    //and a collection called  "Data", otherwise code it out to create before calling it.
    private static readonly MongoClient Client = new("mongodb://localhost:27017");
    private static readonly IMongoDatabase Db = Client.GetDatabase("IRS990");
    private static readonly IMongoCollection<Return> Collection = Db.GetCollection<Return>("Data");

    private static int _totalFileCnt = 0;
    private static int _totalConvert = 0;
    private static int _totalUpload = 0;

    private static ProgressBar _totalConvertProgressBar = null;
    private static ProgressBar _totalUploadProgressBar = null;
    
    private static void UpdateConvertBar(int bySize, string fileName)
    {
        Interlocked.Add(ref _totalConvert, bySize);
        _totalConvertProgressBar.Refresh((_totalConvert), fileName);
    }

    private static void UpdateProgressBar(int bySize, string fileName)
    {
        Interlocked.Add(ref _totalUpload, bySize);
        _totalUploadProgressBar.Refresh((_totalConvert), fileName);
    }

    public static async Task Main(string[] args)
    {
        //If you pass an argument like "2021", it will grab all of the files from both the Db and the main folder that
        //start with "2021." This would allow you to run the program in a few separate threads, which crunched
        //through the 1.9million records faster than in a single thread.
        //In Linux, I had to make sure that my "NoFile" environment settings where set to a high number, allowing me to
        //open a decent amount of file allocators at one time.
        var searchByYear  = args.FirstOrDefault();
        
        var console = new ConcurrentWriter();
        console.WriteLine(ConsoleColor.Magenta, "Getting File List");
        
        //Grab files from XML Folder and see what has already been uploaded to the DB
        //Return the exclusion of the two.
        var files2Upload = await GetFiles2Upload(searchByYear);
        
        _totalFileCnt = files2Upload.Length;
        
        console.WriteLine(ConsoleColor.Cyan,"\nConversion");
        _totalConvertProgressBar = new ProgressBar(PbStyle.DoubleLine, _totalFileCnt);
        _totalConvertProgressBar.Refresh(0, "warming up....");
        console.WriteLine(ConsoleColor.Yellow,"\nDb Insert");
        _totalUploadProgressBar = new ProgressBar(PbStyle.DoubleLine, _totalFileCnt);
        _totalUploadProgressBar.Refresh(0, "warming up....");

        await Parallel.ForEachAsync(files2Upload, new ParallelOptions
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount
        }, async (fileName, token) =>
        {
            try
            {
                var obj = await Task.Run(() =>
                    ConvertXmlToJson(fileName));
                if (obj == null)
                    return;
        
                UpdateConvertBar(1,fileName);
                    
                await Collection.InsertOneAsync(obj, token);
        
                UpdateProgressBar(1,fileName);
            }
            catch (Exception exp)
            {
                WriteMessageToWall(fileName, exp);
            }
        });
    }

    private static Return ConvertXmlToJson(string f)
    {
        try
        {
            var xml = new XmlDocument();
            xml.Load(Path.Combine(XmlMainFolder.FullName, f));
            var root = xml.DocumentElement;
            root.RemoveAllAttributes();    
            
            //Some of the XML files from the IRS had a decent amount of garbage, this step
            //is sort of optional depending on your data requirements.
            var jsonString = JsonConvert.SerializeXmlNode(xml, Formatting.None);
            jsonString = jsonString.Replace("@", "")
                .Replace("#", "")
                .Replace("irs:","",StringComparison.CurrentCultureIgnoreCase)
                .Trim();
           
            jsonString = ConvertUnicodeToAscii(jsonString);
    
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
    
            var returnHeaderData = (IDictionary<string, object>) rH;
            var returnDataData = (IDictionary<string, object>) rd;
    
            foreach (KeyValuePair<string, object> keyValuePair in returnHeaderData)
                ((IDictionary<string, object>) json).Add(keyValuePair.Key, keyValuePair.Value);
    
            foreach (KeyValuePair<string, object> keyValuePair in returnDataData)
                ((IDictionary<string, object>) json).Add(keyValuePair.Key, keyValuePair.Value);
    
            dict.Remove("Return");
            dict.Remove("ReturnHeader");
            dict.Remove("ReturnData");

            RemoveKeysStartingWithDocument(json, "documentId");
            RemoveKeysStartingWithDocument(json, "documentName");
            RemoveKeysStartingWithDocument(json, "referenceDocumentName");
            RemoveKeysStartingWithDocument(json, "referenceDocumentId");
            RemoveKeysStartingWithDocument(json, "binaryAttachmentCnt");
            RemoveKeysStartingWithDocument(json, "documentCnt");
    
            string jsonOBj = JsonConvert
                .SerializeObject(json, Formatting.None, new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Include,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                });
    
            var res = JsonConvert.DeserializeObject<Return>(jsonOBj);
            if (res == null)
                throw new Exception();
    
            res.Id = Guid.NewGuid();
            res.FileName = f;
    
            return res;
        }
        catch (Exception e)
        {
            WriteMessageToWall(f, e);
            return null;
        }
    }
    
    private static void RemoveKeysStartingWithDocument(ExpandoObject expando, string searchItem)
    {
        var dictionary = (IDictionary<string, object>)expando as IDictionary<string, object>;

        // Need to convert to a list before removing because dictionary cannot be modified during iteration
        var keysToRemove = dictionary.Keys.Where(key => key.StartsWith(searchItem, 
            StringComparison.OrdinalIgnoreCase)).ToList();

        foreach (var key in keysToRemove)
        {
            dictionary.Remove(key);
        }

        foreach (var pair in dictionary)
        {
            if (pair.Value is ExpandoObject childExpando)
            {
                RemoveKeysStartingWithDocument(childExpando,searchItem);
            }
            else if (pair.Value is IEnumerable<object> enumerable)
            {
                foreach (var item in enumerable)
                {
                    if (item is ExpandoObject childItemExpando)
                    {
                        RemoveKeysStartingWithDocument(childItemExpando, searchItem);
                    }
                }
            }
        }
    }
    
    private static string ConvertUnicodeToAscii(string unicode)
    {
        var ascii = string.Empty;
        var normalized = unicode.Normalize(NormalizationForm.FormKD);
    
        foreach (var c in normalized)
        {
            if ((c < ' ') || (c > 127))
                continue;
            
            ascii += c;
        }
    
        return ascii;
    }


    /// <summary>
    /// Creates an empty schema based on the input JSON file and writes it to an output file.
    /// </summary>
    /// <param name="storageDirectoryInfo">The storage directory information.</param>
    /// <param name="inputFileName">The name of the input file.</param>
    /// <param name="outputFileName">The name of the output file.</param>
    private static async Task CreateEmptySchemaAndWriteOutput
    (DirectoryInfo storageDirectoryInfo,
        string inputFileName, string outputFileName)
    {
        try
        {
            var jsonTokenString = await File.ReadAllTextAsync
                (Path.Combine(storageDirectoryInfo.FullName, inputFileName));

            var token = JToken.Parse(jsonTokenString);
            var schema = CreateEmptySchema(token);

            await File.WriteAllTextAsync
                (Path.Combine(storageDirectoryInfo.FullName, outputFileName), schema.ToString());
        }
        catch (Exception exp)
        {
            WriteMessageToWall(inputFileName, exp);
        }
    }

    private static JToken CreateEmptySchema(JToken token)
    {
        if (token is JValue)
        {
            return new JValue("");
        }
        else if (token is JObject obj)
        {
            var newObj = new JObject();
            foreach (var property in obj.Properties())
            {
                newObj.Add(property.Name, CreateEmptySchema(property.Value));
            }
            return newObj;
        }
        else if (token is JArray arr)
        {
            var newArr = new JArray();
            foreach (var value in arr)
            {
                newArr.Add(CreateEmptySchema(value));
            }
            return newArr;
        }

        return null;
    }

    private static async Task<string[]> GetFiles2Upload(string startsWithSearchPattern)
    {
        var filesTask = Task.Run(() =>
        {
            var files = !string.IsNullOrEmpty(startsWithSearchPattern)
                ? XmlMainFolder.GetFiles("*.xml",
                        SearchOption.AllDirectories)
                    .Where(x => x.Name.StartsWith(startsWithSearchPattern))
                    .OrderByDescending(x => x.Name)
                    .ToArray()
                : XmlMainFolder.GetFiles("*.xml",
                        SearchOption.AllDirectories)
                    .OrderByDescending(x => x.Name)
                    .ToArray();

            return files.Select(x => x.Name).ToList();
        });

        var previouslyUploadedTask = GetImportedFiles(startsWithSearchPattern);

        await Task.WhenAll
        ([
            filesTask,
            previouslyUploadedTask
        ]);

        var existingFileNames = (await filesTask)
            .ToArray();

        var previousFileNames = (await previouslyUploadedTask);

        var files2Upload =
            existingFileNames.Except(previousFileNames)
                .ToArray();

        return files2Upload
            .ToArray();
    }

    private static async Task<IReadOnlyCollection<string>> GetImportedFiles(string searchStartsWithPattern)
    {
        return await Task.Run(() =>
        {
            var query = Collection
                .AsQueryable()
                .Select(x => x.FileName);

            return string.IsNullOrEmpty(searchStartsWithPattern) ? query.ToList() :
                query.ToList()
                    .Where(x=>x.StartsWith(searchStartsWithPattern))
                .ToList();
        });
    }

    private static void WriteMessageToWall(string fileName,
        Exception exp)
    {
        try
        {
            var newFName = fileName.Replace(".xml", "_err.txt");
            var sb = new StringBuilder();
            sb.Append($"\n{Path.Combine(XmlMainFolder.FullName, fileName)}\n");
            sb.Append($"Message:{exp.Message}");
            sb.Append($"Inner Message: {exp.InnerException?.Message}");
            sb.Append($"Stack : {exp.StackTrace ?? ""}");
            sb.Append($"Source : {exp.Source ?? ""}");

            File.WriteAllText(Path.Combine(DiErrorMessages.FullName, newFName),
                sb.ToString());
            sb.Clear();
        }
        catch
        {
            //DON'T DEAD OPEN INSIDE
        }
    }
}