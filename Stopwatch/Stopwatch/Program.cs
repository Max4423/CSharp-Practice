namespace Stopwatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var timer = new System.Diagnostics.Stopwatch();

			timer.Start();

			int[] arr = new int[1_000_000];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i * 2;
			}
			Console.WriteLine(timer.ElapsedTicks);
			timer.Restart();
			int[] arr2 = new int[100_000];
			for (int i = 0; i < arr2.Length; i++)
			{
				arr2[i] = i * 2;
			}  
			Console.WriteLine(timer.ElapsedTicks);
		}
	}
}
