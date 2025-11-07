using System.Text.Json;

namespace FileReader;

public class FileReader<T>
{
    public string? ReadFile1(string filepath)
    {
        return !File.Exists(filepath) ? null : File.ReadAllText(filepath);
    }

    public void SaveToFile1(string filepath, string content)
    {
        File.WriteAllText(filepath, content);
    }

    public T? ReadFile(string filepath)
    {
        using var streamReader = new StreamReader(filepath);
        var content = streamReader.ReadToEnd();
        
        return JsonSerializer.Deserialize<T>(content);
    } 

    public void SaveToFile(string filepath, T content)
    {
        using var streamWriter = new StreamWriter(filepath);
        streamWriter.Write(JsonSerializer.Serialize(content));
    }
}