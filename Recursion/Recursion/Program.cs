
namespace Recursion
{
	internal class Program
	{
		static void Foo(int i)
		{
			Console.WriteLine(i);
			i++;
			if (i <= 15000)
			{
				Foo(i);

			}

		}

		static void PrintArr(int[] arr, int i = 0)
		{
			if (i >= arr.Length)
			{
				return;
			}
			Console.Write(arr[i] + " ");

			PrintArr(arr, ++i);

		}

		static int SumArr(int[] arr, int i = 0)
		{
			if (arr.Length == i)
			{
				return 0;
			}

			return SumArr(arr, i + 1) + arr[i];
		}
		static void Main(string[] args)
		{
			int[] arr = { 1, 4, 5, 2, 4, 22, 1, 0, 45 };

			PrintArr(arr);
			Console.WriteLine();
			Console.WriteLine(SumArr(arr));
		}
	}
}
