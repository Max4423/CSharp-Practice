namespace sumOfDigits
{
    internal class Program
    {
		static int SumOfDigits(int value)
        {
            if (value == 0)
            {
                return 0;
            }

            return SumOfDigits(value / 10) + value % 10;
        }

		static int SumOfDigitsLoop(int value)
		{
            int sum = 0;

			while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }
            return sum;
		}

		static void Main(string[] args)
        {
            int value = 234;

            int result = SumOfDigits(value);
			Console.WriteLine(result);
			Console.WriteLine(SumOfDigitsLoop(value));

		}
    }
}
