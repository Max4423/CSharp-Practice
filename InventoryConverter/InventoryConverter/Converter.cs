using System.Text.Json;
using System.Xml.Serialization;

namespace InventoryConverter;

public class Converter
{
    private List<Product> _products = new List<Product>();

    private void ReadFile(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split(",");

                var product = new Product();

                product.Id = int.Parse(lines[0]);
                product.Name = lines[1];
                product.Quantity = int.Parse(lines[2]);
                product.Price = decimal.Parse(lines[3], System.Globalization.CultureInfo.InvariantCulture);

                _products.Add(product);
            }

            Console.WriteLine($"Successfully read: {_products.Count}");
            Show();
        }
    }

    public void ConvertToJson(string path, string jsonPath)
        {
            if (_products.Count == 0)
            {
                ReadFile(path);
            }
            using (StreamWriter sw = new StreamWriter(jsonPath))
            {
                    string json = JsonSerializer.Serialize(_products, new JsonSerializerOptions { WriteIndented = true });
                    sw.WriteLine(json);
                
            }

            Console.WriteLine("Successfully saved inventory.json");
        }
    public void ConvertToXML(string path, string xmlPath)
    {
        if (_products.Count == 0)
        {
            ReadFile(path);
        }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
        using (StreamWriter sw = new StreamWriter(xmlPath))
        {
                xmlSerializer.Serialize(sw, _products);
        }

        Console.WriteLine("Successfully saved inventory.xml");
    }
       private void Show()
        {
            foreach (var prod in _products)
            {
                Console.WriteLine($"Id: {prod.Id}, Name: {prod.Name}, Price: {prod.Price}, Quantity: {prod.Quantity}");
            }
        }
    }
