namespace Dictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> people = new Dictionary<int, string>() {{ 5, "Tom"},
																			{ 3, "Sam"},
																			{ 11, "Bob"} };

			people.Add(22,"Ivan");

			foreach (var item in people)
			{
				Console.WriteLine($"{item.Key} {item.Value}");
			}

			Console.WriteLine(people[5]);
			people[5] = "dasd";
			Console.WriteLine(people[5]);

			people.Add(12, "Peter");

			people[333] = "Petro";

			Console.WriteLine(people.ContainsKey(23));
			Console.WriteLine(people.ContainsValue("Tom"));

		}
	}
}
