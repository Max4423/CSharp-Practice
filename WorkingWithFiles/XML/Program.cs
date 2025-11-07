using System.Xml;
using System.Xml.Linq;

namespace XML;

class Program
{
    static void Main(string[] args)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("people.xml");

        XmlElement? xRoot = doc.DocumentElement;

        if (xRoot != null)
        {
            foreach (XmlElement xnode in xRoot)
            {
                XmlNode? attr = xnode.Attributes.GetNamedItem("name");
                Console.WriteLine(attr?.Value);

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine($"Company: {childnode.InnerText}");
                    }

                    if (childnode.Name == "age")
                    {
                        Console.WriteLine($"Age: {childnode.InnerText}");
                    }
                }

                Console.WriteLine();
            }
        }
        
        var xml = new XDocument(
            new XElement("users",
                new XElement("user",
                    new XElement("name", "Максим"),
                    new XElement("age", 19)
                )
            )
        );
        xml.Save("users.xml");
    }
}