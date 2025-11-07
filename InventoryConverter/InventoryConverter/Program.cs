using System.Text.Json;

namespace InventoryConverter;

class Program
{
    static void Main(string[] args)
    {
        const string path = "inventory.csv";
        
        Converter converter = new();
        converter.ConvertToJson(path, "inventory.json");
        converter.ConvertToXML(path, "inventory.xml");
    }
}