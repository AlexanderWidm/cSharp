using Adressbok.Interfaces;
using Adressbok.Models;
using Newtonsoft.Json;

namespace Adressbok.Services;

public static class FileService
{
    private static readonly string filePath = @"C:\Skola\C-Sharp\List\contacts.json"; // filepath where list is saved
    public static void SaveContactsToFile(List<IContact> contacts) // method for saving list to json file
    {
        var json = JsonConvert.SerializeObject(contacts, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto })!;
        File.WriteAllText(filePath, json);
    }

    public static List<IContact> LoadContactsFromFile() 
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<IContact>>(json, new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Auto})! ;
        }
        else
        {
            return new List<IContact>();
        }
    }
}



