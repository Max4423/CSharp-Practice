namespace ArrayWithoutDuplicates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[15] {34, 32, 21, 11, 32, 23, 55, 32, 11, 12, 18, 78, 2, 1, 65 };

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}


			Console.WriteLine();
			int[] arr1 = arr.Distinct().ToArray();
			for (int i = 0; i < arr1.Length; i++)
			{
				Console.Write(arr1[i] + " ");
			}



			int[] tempArr = new int[arr.Length];

			int uniqueCount = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				bool isDuplicate = false;

				for (int j = 0; j < uniqueCount; j++)
				{
					if (arr[i] == tempArr[j])
					{
						isDuplicate = true;
						break;
					}
				}

				if (!isDuplicate) 
				{
					tempArr[uniqueCount] = arr[i];
					uniqueCount++;
				}
				
			}
			int[] withoutDuplicates = new int[uniqueCount];

			for (int i = 0; i < uniqueCount; i++)
			{
				withoutDuplicates[i] = tempArr[i];
			}
			Console.WriteLine();
			for (int i = 0; i < withoutDuplicates.Length; i++)
			{
				Console.Write(withoutDuplicates[i] + " ");
			}
		}
	}
}
