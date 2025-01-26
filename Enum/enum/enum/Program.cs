internal class Program
{
	enum Days : byte
	{
		Sunday = 1,
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday
	}

	static void GoNextDay(Days day)
	{
		if (day == Days.Saturday)
			return;
		day++;
		Console.WriteLine(day);
	}
	static void Main(string[] args)
	{
		var days = Enum.GetNames(typeof(Days));
		foreach (var day in days)
		{
			Console.WriteLine(day);
		}
		while (true)
		{
			Console.Write("Enter a day of week: ");
			string input = Console.ReadLine();
			Enum.TryParse(input, out Days day);
			if (Enum.IsDefined(typeof(Days), day)) 

			{
				Console.WriteLine(day);
				GoNextDay(day);

			}

		}
	}
}
