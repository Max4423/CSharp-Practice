namespace FuncActionPredicate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter array size:");
			int arrSize = 0;
			int.TryParse(Console.ReadLine(), out arrSize);
			Console.WriteLine();
			int[] arr = new int[arrSize];

			for (int i = 0; i < arrSize; i++)
			{
				Console.Write($"Enter {i + 1}st element:");
				int.TryParse(Console.ReadLine(), out arr[i]);
				Console.WriteLine();
			}

			//Anonymous method
			//Predicate<int> isEven = delegate(int x) { return x % 2 == 0; } ;  

			Predicate<int> isEven = x => x % 2 == 0;
			Func<int, int> multiplyByTen = x => x * 10;
			Action<int> print = x => Console.Write($"{x} ");

			var EvenArr = arr.Where(x => isEven(x));

			var multByTen = EvenArr.Select(x => multiplyByTen(x));

			foreach (var item in multByTen)
			{
				print(item);
			}
		}


	}
}
