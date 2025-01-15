namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			while (true)
			{
				int age = Convert.ToInt32(Console.ReadLine());

				switch (age)
				{
					case <= 0:
						Console.WriteLine("Incorrect value");
						break;

					case > 0 when age < 18:
						Console.WriteLine("Child");
						break;
					case >= 18 when age < 60:
						Console.WriteLine("Adult");
						break;
					case >= 60 when age <= 120:
						Console.WriteLine("Aged");
						break;
					case > 120:
						Console.WriteLine("Incorrect value");
						break;
					default:
						break;
				}
			}
		}
	}
}