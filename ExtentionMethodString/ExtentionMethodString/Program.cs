namespace ExtentionMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";

			Console.WriteLine(str.Reverse());

			Console.WriteLine(str.Reverse().Reverse());
        }
    }

    static class ExtentionClass
    {
        public static string Reverse(this string str)
        {
            char[] chars = str.ToCharArray();

            char[] reversedString = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                reversedString[i] = chars[chars.Length - i - 1];


			}
            return new string(reversedString);
		}
    }
}
