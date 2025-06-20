namespace delegates2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, int> deleg1;
			Action<string> deleg2;

			deleg1 = new(Sum);

			deleg2 = new(Println);

			var numbers = new List<int> { 5, 7, 6, 99, 1, 34 };

			var evenresult = numbers.Where(IsEven);

			foreach (var item in evenresult)
				Console.Write(item + " ");
			Console.WriteLine();
			

			var oddresult = numbers.Where(delegate (int nums)
			{
				return nums % 2 == 1;
			}
			);

			foreach (var item in oddresult)
				Console.Write(item + " ");

			Console.WriteLine();


			var thirdresult = numbers.Where((int numbers) => numbers % 3 == 0);
			foreach (var item in thirdresult)
				Console.Write(item + " ");
			Console.WriteLine();

			var thirdresultSIMPLIFIED = numbers.Where(numbers => numbers % 3 == 0);

		}

		public static int Sum(int a, int b)
		{
			return a + b;
		}
		public static void Println(string text)
		{
			Console.WriteLine(text);
		}

		public static bool IsEven(int x)
		{
			if (x % 2 == 0)
				return true;
			else
				return false;

		}

	}
}
