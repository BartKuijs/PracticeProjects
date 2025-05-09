

using PrintImageDownloader;
using System.Text.Json.Serialization;

var json = "C:\\Users\\Bart\\source\\repos\\TimCorey_Mastercourse\\PrintImageDownloaderApp\\PrintImageDownloader\\data.json";


string fileName = "data.json";
string jsonString = File.ReadAllText(fileName);
dynamic info = JsonSerializer.Deserialize<>();

var fields = info.Fields;

string stringMapIdFalse = fields.OverlayImageIds;
string stringMapId = stringMapIdFalse.Substring(stringMapIdFalse.Length - 58, 36);

// teken 58 t/m 94 - 36tekens

DataModel link = new();

link.PrintImageId = info.PrintImageId;
link.PrintImageMapId = stringMapId;

Console.WriteLine(stringMapId);

