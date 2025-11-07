using System.Text;

namespace FileStreamClass;

class Program
{
    static void Main(string[] args)
    {
        const string _filePath = "C:\\Users\\miksi\\Desktop\\123.txt";
        using (FileStream fileStream = new FileStream("file.txt", FileMode.OpenOrCreate))
        {
            fileStream.Write(new byte[1024], 0, 1024);
        }

        using (FileStream fileStream = File.OpenRead(_filePath))
        {
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, buffer.Length);
            string textFromFile = Encoding.Default.GetString(buffer);

            Console.WriteLine((textFromFile));

        }
        
        
    }
}