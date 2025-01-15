namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("input string:");
            string input = Console.ReadLine();

            string output = Reverse(input);
			Console.WriteLine(output);

		}

        public static string Reverse(string input)
		{
            char[] inputChar = input.ToCharArray();
            Array.Reverse(inputChar);
           string output = new string(inputChar);
            return output;
		}
	}
}
