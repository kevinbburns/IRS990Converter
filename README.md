I recently had to work aggregating a tremendous amount of data from the IRS's 990 repositories. Amazon AWS used to have a free database, but it has since been discontinued. You must manually go to the IRS website and download the individual files. Most years have eight total zip files, all about 400MB each. When uncompressed, there are about 458,000+ files in each archive, so the user beware. You are in a tough time if you do not have the storage, memory, and processing power.

I had initially reached out to the IRS for a schema, which you have to request formally, even though the files are readily available. The agent and I chuckled, but red tape is red tape. She had sent me a few XSD files. Still, she also warned me that sometimes they didn't align and was warned that previous developers continuously had issues trying to serialize/deserialize the data, so I began my journey.

Each 990 return may or may not have missing properties from file to file, so you were left with missing pieces that you had to pick up instead of each XML file containing every combination. Without a working XSD that could include all possible data combinations, you would unintentionally omit data that could be important to future analysis. So I did what any data hacker would do; I started chucking every tool I had until it made some damn sense.

As I said before, the biggest hurdle is the sheer amount of files, and each XML file was rather large (figuratively speaking, for an XML at least.), so each iteration of ideas had to be thought out properly.

 My first attempt was to use a Microsoft XML import and merge schema utility, which failed miserably. The XSD was so corrupted that the XSD and XML files wouldn't validate and had missing properties or duplicated fields with meaningless values. 

On my second attempt, I tried to convert it to string, which I ran through a utility from Google that would create differentials for patching and merging, but it also failed, and the XML/XSD would become corrupted each time when converted back. 

On my third attempt, and since I had settled on using a NoSQL database (MongoDB), I decided to see what I could do with JSON. I started by loading the XML file using NewtownSoft with the following code:

var xml = new XmlDocument();
xml.Load(f.OpenRead());
string jsonString = JsonConvert.SerializeXmlNode(xml, Formatting.None);

dynamic json =
    JsonConvert.DeserializeObject<ExpandoObject>(
        jsonString,
        new ExpandoObjectConverter()
    );

At this point, I had started to perk up; treating an XML as a Dictionary with standard keys and values made more sense and made it much easier to manage the data. I was still missing a schema at this point, but with JSON, there is a built-in merge utility; all I had to do was iterate over the unzipped files with a few years of zip data, which was a measly million files, no biggie, and merge the properties fields with the "original" JSON file. In the end, I had a single JSON file that, in theory, should contain every potential property and value combination. From here, I headed on over to a website that would convert JSON to a C# class, which spit out a massive file that would allow me to freely serialize and deserialize the data at will into an object that made sense and was easy to manage, and eventually convert to Spreadsheet since that it was 99% of the damn financial world seems to run on, thanks Microsoft. 

Ultimately, I am happy with the results, and so is the data analyst team. I wanted to document my workflows and provide anyone searching for a fast and easy means of converting the data. My original project was a simple console program written in .net 7 in Fedora; I included some functions I had used for the initial process and the final IRS990Return class that would be needed to convert. Please let me know if anyone has any suggestions on speeding up the process or improving it for future revisions. I feel like I skipped over some "enhancements" to get this project done and over with; after looking at this data for too long, you will have nightmares.


I included a newer JSON Schema and DTO for the latest changes in 2023. I didn't need the newer properties for my requirements, but I wanted to include them if anyone else would require them. In the latest update, I migrated from Azure CosmosDb to a local instance of MongoDB; it made more sense and was much faster.

I also used Allan Hemming's (GoblinFactory) to show some output on the console.


![IRS_990_DbBuilder-v2](https://github.com/kevinbburns/IRS990Converter/assets/825269/f53609e9-576c-471b-aaee-08acead36225)




