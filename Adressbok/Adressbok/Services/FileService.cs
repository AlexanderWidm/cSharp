namespace Adressbok.Services;

public class FileService
{
    private static readonly string filePath = @"C:\Skola\C-Sharp\List\contacts.json";

    public static void AppendToFile(string contentAsJson)
    {
        try
        {
            using (var sw = new StreamWriter(filePath, true)) // Open the file in append mode
            {
                sw.WriteLine(contentAsJson);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while appending to the file: {ex.Message}");
        }
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using (var sr = new StreamReader(filePath))
            {
                return sr.ReadToEnd();
            }
        }
        return null!;
    }
}