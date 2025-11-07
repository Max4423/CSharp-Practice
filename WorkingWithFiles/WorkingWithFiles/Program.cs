using System.Diagnostics;
using System.IO.Compression;
using System.Text.Json;

namespace WorkingWithFiles;

class Program
{
    static void Main(string[] args)
    {
        //Working with disks DriveInfo
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (var drive in allDrives)
        {
            Console.WriteLine($"Drive: {drive.Name} {drive.DriveType} {drive.DriveFormat} {drive.RootDirectory} ");
            Console.WriteLine($"{drive.TotalFreeSpace / 1048576} {drive.TotalSize} {drive.AvailableFreeSpace} ");
        }

        //Working with directories Directory/DirectoryInfo
        const string dirName = "C:\\Users\\miksi\\Desktop";


        for (int i = 0; i < 35; i++)
        {
            Directory.CreateDirectory($"C:\\Users\\miksi\\Desktop\\kukuku\\k{i}");
        }

        Directory.Delete($"C:\\Users\\miksi\\Desktop\\kukuku", true);
        Console.WriteLine(Directory.Exists("C:\\Users\\miksi\\Desktop\\C#"));
        Console.WriteLine(Directory.GetCurrentDirectory());
        var dirs = Directory.GetDirectories($"{dirName}\\C#");
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir);
        }

        var files = Directory.GetFiles($"{dirName}\\C#\\WorkingWithFiles");
        Console.WriteLine("=================");
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }

        DirectoryInfo di = new DirectoryInfo(dirName);
        if (di.Exists)
        {
            var dirs2 = di.GetDirectories();

            foreach (var dir in dirs2)
            {
                Console.WriteLine(dir.FullName);
            }

            FileInfo[] files2 = di.GetFiles();
            foreach (FileInfo file in files2)
            {
                Console.WriteLine(file.FullName);
            }
        }

        var files3 = Directory.GetFiles(dirName, "*.exe");
        var dirs3 = Directory.GetDirectories(dirName, "C*.");

        //working with files File / FileInfo

        const string filepath = dirName + "\\123.txt";
        FileInfo fi = new FileInfo(filepath);

        if (fi.Exists)
        {
            Console.WriteLine($"{fi.FullName} + {fi.CreationTime} + {fi.LastAccessTime} + {fi.Length}");

            //fi.MoveTo("C:\\Users\\miksi\\Desktop\\Study\\12345.txt",true);

            fi.CopyTo("C:\\Users\\miksi\\Desktop\\Study\\1234.TXT", true);
        }

        File.WriteAllText(filepath, "Hello World!");
        
        Stopwatch sw = new Stopwatch();
        
        sw.Start();
        File.WriteAllText(filepath, "Hello World2!");
        
        File.AppendAllText(filepath, "\nKu!");
        
        File.AppendAllText(filepath, " KuKu!");
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        
        sw.Reset();
        sw.Start();

        File.WriteAllTextAsync(filepath, "Hello World2!");
        
        File.AppendAllTextAsync(filepath, "\nKu!");
        
        File.AppendAllTextAsync(filepath, " KuKu!");
        
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        string filetext = File.ReadAllText(filepath);

        Console.WriteLine(filetext);
        
        //ZipFile.CreateFromDirectory($"C:\\Users\\miksi\\Desktop\\books", "C:\\Users\\miksi\\Desktop\\booksss.zip");
        ZipFile.ExtractToDirectory("C:\\Users\\miksi\\Desktop\\booksss.zip", "C:\\Users\\miksi\\Desktop\\booksss");
        var cds = new Person();
        var getrg = JsonSerializer.Serialize(cds, new JsonSerializerOptions { WriteIndented = true });
    }
}

class Person
{
    public string? Name { get; set; }
}