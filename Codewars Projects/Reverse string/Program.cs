namespace Reverse_string;

class Program
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.InputEncoding = System.Text.Encoding.UTF8;
		while (true)
		{
			string word = Console.ReadLine();
			string reversedWord = ReverseString(word);
			Console.WriteLine(reversedWord);
		}

	}

	public static string ReverseString(string input)
	{
		char[] charArray = new char[input.Length];

		for (int i = 0; i < input.Length; i++)
		{
			charArray[i] = input[input.Length - 1 - i];
		}
		return new string(charArray);

	}
}