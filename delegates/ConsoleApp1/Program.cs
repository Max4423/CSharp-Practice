using System.Xml.Schema;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Sum(new int[] { 3, 1, 623, 52, 1, 5, 7, 9, 66 }, x => x % 2 == 0));
		} 

		static int Sum(int[] numbers, IsEqual func)
		{
			int result = 0;

			foreach (var item in numbers)
			{
				if (func(item))
					result += item;	
			}
			return result;
		}
		delegate bool IsEqual(int x);

		delegate int Operation(int a, int b);

	 
	}
}
