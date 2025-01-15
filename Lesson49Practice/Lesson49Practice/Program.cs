namespace Lesson49Practice
{
	internal class Program
	{

		static int GetSum(int[,] arr)
		{

			int sum = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					sum += arr[i, j];
				}
			}
			return sum;
		}

		static void PrintArr(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		static void ArrSum(int[,] arr1, int[,] arr2, int[,] arr3)
		{
			for (int i = 0; i < arr1.GetLength(0); i++)
			{
				for (int j = 0; j < arr1.GetLength(1); j++)
				{
					arr3[i, j] = arr1[i, j] + arr2[i, j];
				}
			}
		}

		static int FindMax(int[,] arr, out int maxRow, out int maxCol)
		{
			int max = int.MinValue;

			maxRow = 0;
			maxCol = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] > max)
					{
						max = arr[i, j];
						maxRow = i;
						maxCol = j;
					}
				}
			}
			return max;
		}

		static int FindMin(int[,] arr, out int minRow, out int minCol)
		{
			int min = int.MaxValue;

			minRow = 0;
			minCol = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] < min)
					{
						min = arr[i, j];
						minRow = i;
						minCol = j;
					}
				}
			}
			return min;
		}

		static bool IsSymmetric(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] != arr[j, i])
					{
						return false;
					}
				}
			}
			return true;
		}
		static void swap(int[,] arr)
		{
			int maxRow, maxCol, minRow, minCol;
			int max = FindMax(arr, out maxRow, out maxCol);
			int min = FindMin(arr, out minRow, out minCol);
			int temp = arr[maxRow, maxCol];
			arr[maxRow, maxCol] = arr[minRow, minCol];
			arr[minRow, minCol] = temp;

		}

		static int[,] InputArr()
		{
			Console.Write("Input rows (i): ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("Input columns (j): ");
			int cols = int.Parse(Console.ReadLine());

			int[,] arr = new int[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"Input value for element [{i},{j}]: ");
					arr[i, j] = int.Parse(Console.ReadLine());
				}
			}

			PrintArr(arr);

			return arr;
		}

		static void SumOfRows(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				int sum = 0;

				for (int j = 0; j < arr.GetLength(1); j++)
				{
					sum += arr[i, j];
				}
				Console.WriteLine($"Sum of row {i + 1} is {sum}");

			}
		}

		static void SumOfColumns(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(1); i++)
			{
				int sum = 0;

				for (int j = 0; j < arr.GetLength(0); j++)
				{
					sum += arr[i, j];
				}
				Console.WriteLine($"Sum of column {i + 1} is {sum}");

			}
		}

		static void Main(string[] args)
		{
			int[,] arr1 = new int[2, 3] { { 5, 2, 3 }, { 9, 3, 43 } };

			int[,] arr2 = new int[2, 3] { { 4, 21, 6 }, { 1, 33, 3 } };

			int[,] arr3 = new int[2, 3];

			PrintArr(arr1);
			Console.WriteLine("-----------------------------------------------");
			PrintArr(arr2);
			Console.WriteLine("-----------------------------------------------");

			ArrSum(arr1, arr2, arr3);

			PrintArr(arr3);
			Console.WriteLine("-----------------------------------------------");

			swap(arr3);

			PrintArr(arr3);
			Console.WriteLine("-----------------------------------------------");

			int[,] symm = new int[3, 3] { { 1, 2, 3 },
										  { 2, 56, 5 }, 
										  { 3, 5, 6 } };
			Console.WriteLine(IsSymmetric(symm));


			int[,] arr = InputArr();

			SumOfRows(symm);
			Console.WriteLine();
			SumOfColumns(symm);
			Console.ReadKey();

		}
	}
}

