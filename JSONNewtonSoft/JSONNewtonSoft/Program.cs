using JSONNewtonSoft;
using Newtonsoft.Json;
namespace JSONNewtonSoft
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			var person = new Person { Name = "Іван", Age = 30 };

			string json = JsonConvert.SerializeObject(person);

			File.WriteAllText("person.json", json);

			Console.WriteLine("JSON успішно записано у файл person.json");
		}
	}
}
