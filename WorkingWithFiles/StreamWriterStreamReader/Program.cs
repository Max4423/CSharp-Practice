namespace StreamWriterStreamReader;

internal class Program
{
    private static void Main(string[] args)
    {
        const string path = "C:\\Users\\miksi\\Desktop\\StreamWriterStreamReader.txt";
        using (var streamWriter = new StreamWriter(path, false))
        {
            streamWriter.WriteLine("Hello World!");
            streamWriter.WriteLine("Kuku!");
            streamWriter.Write("12345");
            streamWriter.Write("\n9876543210");
        }

        string text;
        using (var streamReader = new StreamReader(path))
        {
            text = streamReader.ReadToEnd();
        }

        Console.WriteLine(text);
    }
}