using System.Collections;
using System.Xml.Linq;

namespace CSharpCollections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> people = new List<string>();
			List<string> people2 = new List<string>() { "Tom", "Bob", "Sam" };

			var employees = new List<string>(people2) { "Max" };
			foreach (var item in employees)
			{
				Console.Write(item + " ");
			}

			List<string> d = ["max", "ivan", "petro"];

			List<Person> ppl = new List<Person>
			{
				new Person("Tom"),
				new Person("Bob"),
				new Person("Sam")
			};

			List<string> p = new List<string>(16); //16 - початкова ємність ліста

			Console.WriteLine(p.Count);

			d.Add("vasyl");
			ShowCollection(d);



			d.AddRange(new string[] { "vasd", "cdsfv", "rff" });
			ShowCollection(d);



			Console.WriteLine(d.Contains("cdsfv2"));


			Console.WriteLine(d.Count);



			d.Insert(0, "ksks");
			ShowCollection(d);

			d.Remove("ksks");
			ShowCollection(d);

			d.RemoveAt(0);
			ShowCollection(d);

			d.RemoveAll(x => x.Length < 4);
			ShowCollection(d);

			d.RemoveRange(1, 2);
			ShowCollection(d);

			//d.Clear();
			//ShowCollection(d);

			Console.WriteLine( d.Contains("Max"));

			Console.WriteLine(d.Exists(x => x.Length == 3));

			Console.WriteLine(d.Find(x => x.Length ==4));

			Console.WriteLine(d.FindLast(x => x.Length == 4));

			List<string> dWithLength3 = d.FindAll(p => p.Length == 3);

			List<string> d13 = d.GetRange(0, 2);

			string[] partOfd = new string[3];

			d.CopyTo(0,partOfd,0, 3);
			ShowCollection(d);

			d.Reverse();
			ShowCollection(d);

			d.Reverse(0,2);
			ShowCollection(d);
		}


		public static void ShowCollection(IEnumerable collection)
		{
			foreach (var item in collection)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
	}

	class Person
	{
		public string Name { get; }
		public Person(string name) => Name = name;
	}
}
