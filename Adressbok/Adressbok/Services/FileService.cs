using Adressbok.Interfaces;
using Adressbok.Models;
using Newtonsoft.Json;

namespace Adressbok.Services;

public static class FileService
{
    private static readonly string filePath = @"C:\Skola\C-Sharp\List\contacts.json";
    public static void SaveContactsToFile(List<IContact> contacts)
    {
        var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static List<IContact> LoadContactsFromFile()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<IContact>>(json);
        }
        else
        {
            return new List<IContact>();
        }
    }
}



