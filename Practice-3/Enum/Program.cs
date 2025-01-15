namespace Enum
{
	internal class Program
	{
		enum Seasons
		{
			Spring,
			Autumn
		}
		static void Main(string[] args)
		{

			Seasons myseason = Seasons.Spring;
			if (myseason == Seasons.Spring)
				Console.WriteLine((int)Seasons.Spring + " yes");

			Console.WriteLine(20 * (int)Seasons.Autumn);
		}
	}
}

