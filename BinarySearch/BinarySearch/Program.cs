namespace BinarySearch
{
    internal class Program
    {
		static int BinarySearch(int[] arr, int target)
		{
			int left = 0;
			int right = arr.Length - 1;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;

				if (arr[mid] == target)
				{
					return mid;
				}
				if (arr[mid] > target)
				{
					right = mid - 1;
				}

				else
				{
					left = mid + 1;
				}
			}

			return -1;
		}
		


		static void Main(string[] args)
        {
			int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
			while (true)
			{
			Console.Write("Enter a number to search: ");

			int target;
			int.TryParse(Console.ReadLine(), out target);

			int result = BinarySearch(numbers, target);

			if (result != -1)
			{
				Console.WriteLine($"Number {target} found at index {result}.");
			}
			else
			{
				Console.WriteLine($"Number {target} not found in the array.");
			}
		}

		}
	}
}

