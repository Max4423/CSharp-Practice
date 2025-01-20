using System.Diagnostics;
namespace ConsoleApp3
{
    internal class Program
    {
		public static int ThirdMax(int[] nums)
		{
			for (int i = 0; i < nums.Length - 1; i++)
			{
				for (int j = 0; j < nums.Length - 1 - i; j++)
				{
					if (nums[j] > nums[j + 1])
					{
						int temp = nums[j];
						nums[j] = nums[j + 1];
						nums[j + 1] = temp;
					}
				}
			}
			if (nums.Length < 3)
			{
				return nums[nums.Length - 1];
			}
			else
			{
				if (nums[nums.Length - 3] == nums[nums.Length - 2 ])
				{
					return nums[nums.Length - 4];
				}
			return nums[nums.Length - 3];
			}
		}

		static void Main(string[] args)
        {
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			int[] nums = new int[] { 2, 2, 3, 1, 5 };

			int max3 = ThirdMax(nums);

			Console.WriteLine(max3);
			stopwatch.Stop();
			Console.WriteLine($"Час виконання: {stopwatch.ElapsedMilliseconds} мс");

		}
	}
}
