using System.Text.Json;

namespace FactoryPattern;

class Program
{
    static void Main(string[] args)
    {
        var FactoryPerson = FactoryHandler.GetFactory<Person>();
        var FactoryAddress = FactoryHandler.GetFactory<Address>();

        string json = JsonSerializer.Serialize(FactoryPerson.CreateInstance());

        Console.WriteLine(json);
    }
}