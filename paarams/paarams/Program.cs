namespace paarams
{
    internal class Program
    {
		static int Sum(params int[] param)
		{
			int sum = 0;
			foreach (int i in param)
			{
				sum += i;
			}
			return sum;
		}

			static void Main(string[] args)
        {
            
			Console.WriteLine(Sum(1, 2, 3, 4, 5, 123, 1234412));
		}
    }
}
