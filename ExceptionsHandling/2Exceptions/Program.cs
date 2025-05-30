using System.Xml;

namespace _2Exceptions
{
	internal class Program
	{
		public static void Divide(int a, int b)
		{
			Console.WriteLine(a / b);

			if (b == 0)
			{
				throw new DivideByZeroException("Дiлення ну нуль!!!");
			}
		}

		static void Main(string[] args)
		{
			int a;
			int b;

			Console.Write("Enter a:");
			int.TryParse(Console.ReadLine(), out a);
			Console.Write("Enter b:");

			int.TryParse(Console.ReadLine(), out b);


			Divide(a, b);
		}
	}
}
