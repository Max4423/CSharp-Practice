using System;
using System.Xml.Linq;

namespace AllLinqMethods;

class Program
{
	static void Main(string[] args)
	{
		int[] arr = { 11, 2, 33, 4, 5 };

		ShowCollection(arr);
		var reversedArr = arr.Reverse();
		ShowCollection(reversedArr);
		var sortedArr = arr.OrderBy(x => x);
		ShowCollection(sortedArr);

		List<string> firstlist = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "a" };
		List<string> secondlist = new List<string>() { "q", "w", "e", "r", "t", "y" };

		var uList = firstlist.Union(secondlist);
		ShowCollection(uList);

		var skiplist = firstlist.Skip(1);
		ShowCollection(skiplist);

		var listWithoutDuplicates = firstlist.Distinct();
		ShowCollection(listWithoutDuplicates);

		Console.WriteLine(listWithoutDuplicates.Count());

		List<string> words = new List<string> { "apple", "banana", "car", "dog", "elephant", "banana" };

		var wordsWithA = words.Where(word => word.Contains("a"));
		ShowCollection(wordsWithA);


		var wordsWithA2 = words.Select(word => word.Contains("a"));

		ShowCollection(wordsWithA2);

		var duplicates = words.GroupBy(g => g).Where(g => g.Count() > 1).Select(g => g.Key);
		ShowCollection(duplicates);

		List<object> objects = new List<object>() { 1, 2, 3, "asd", 'q', 3.14 };

		List<int> ints = objects.OfType<int>().ToList();
		ShowCollection(ints);

		string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

		var selectedPeople = from p in people
							 where p.ToUpper().StartsWith("T")
							 orderby p
							 select p;

		var selectedPeople2 = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);
		Console.WriteLine(people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p).Count());

		ShowCollection(selectedPeople);
		ShowCollection(selectedPeople2);

		string[] soft = { "Microsoft", "Google", "Apple" };
		string[] hard = { "Apple", "IBM", "Samsung" };


		var except = soft.Except(hard);

		foreach (var ex in except)
		{
			Console.Write(ex + " ");
		}

		Console.WriteLine();
		var intersect = soft.Intersect(hard);

		foreach (var inter in intersect)
		{
			Console.Write(inter + " ");
		}
		Console.WriteLine();
		var distinct = soft.Distinct();

		foreach (var dist in distinct)
		{
			Console.Write(dist + " ");
		}
		Console.WriteLine();
		var result = soft.Union(hard);
		foreach (var un in result)
		{
			Console.Write(un + " ");
		}


		Person[] peoples =
 {
	new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
	new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
	new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft"),
 };

		Console.WriteLine();
		var groupedPeople = peoples.GroupBy(p => p.CompanyName);

		foreach (var gp in groupedPeople)
		{
			Console.WriteLine("=============");

			Console.WriteLine(gp.Key + ":");
			foreach (var person in gp)
			{
				Console.WriteLine(person.PName);
			}
		}

		Person[] people1 =
 {
	new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
	new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
 };
		Company[] companies =
		{
	new Company("Microsoft", "C#"),
	new Company("Google", "Go"),
	new Company("Oracle", "Java")
 };

		var employees = people1.Join(companies,
		p => p.CompanyName,
		 c => c.Name,
		 (p,c) => new { Name = p.PName, Company = c.Name, Language = c.Language });

		foreach (var emp in employees)
		{
			Console.WriteLine($"{emp.Name} {emp.Company} {emp.Language}");
		}

		var zipped = people.Zip(objects);

		ShowCollection(zipped);
	}




	public static void ShowCollection<T>(IEnumerable<T> collection)
	{
		foreach (var item in collection)
		{
			Console.Write(item + " ");
		}

		Console.WriteLine();
	}

	class Person
	{
		public string PName { get; set; }
		public string CompanyName { get; set; }
		public Person(string name, string company)
		{
			PName = name;
			CompanyName = company;
		}
	}

	class Company
	{
		public string Name { get; set; }
		public string Language { get; set; }
		public Company(string name, string language)
		{
			Name = name;
			Language = language;
		}
	}
}