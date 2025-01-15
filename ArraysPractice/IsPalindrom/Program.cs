namespace IsPalindrom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Input an array size: ");
			int arrSize = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			int[] palindrom = new int[arrSize];

			Console.WriteLine("Input an array elements:");
			for (int i = 0; i < arrSize; i++)
			{
				palindrom[i] = Convert.ToInt32(Console.ReadLine());
			}

			if (IsPalindrome(palindrom))
			{
				Console.WriteLine("The array is a palindrome.");
			}
			else
			{
				Console.WriteLine("The array is not a palindrome.");
			}

			Console.WriteLine();
			for (int i = 0; i < palindrom.Length; i++)
			{
				Console.Write(palindrom[i] + "   ");
			}		}

		static bool IsPalindrome(int[] array)
		{
			for (int i = 0; i < array.Length / 2; i++)
			{
				if (array[i] != array[array.Length - i -1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
