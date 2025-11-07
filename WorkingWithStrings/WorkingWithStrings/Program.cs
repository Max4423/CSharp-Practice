using System;
using System.Text;

namespace WorkingWithStrings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s1 = "str";

			string s2 = new string(new char[] { 's', 't', 'r' });

			string s3 = new string('a', 5); // "aaaaa"

			string s4 = new string(new char[] { 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' }, 6, 5); // "world"

			Console.WriteLine(s1[1]);
			Console.WriteLine(s1.Length);

			Console.WriteLine("-------------");
			foreach (char c in s1)
			{
				Console.WriteLine(c);
			}

			for (int i = 0; i < s1.Length; i++)
			{
				Console.WriteLine(s1[i]);
			}

			string message1 = "hello";
			string message2 = "hello";

			Console.WriteLine(message1 == message2);

			var ss1 = s1.Insert(3, "ks");

			Console.WriteLine(ss1);

			var split = ss1.Split("r");

			foreach (var item in split)
			{
				Console.WriteLine(item);
			}

			var sub = s3.Substring(0, 1);

			Console.WriteLine(s4.ToUpper());

			Console.WriteLine(new string("      cwd cd c          ").Trim());

			Console.WriteLine(message1.IndexOf("l"));

			string[] toJoin = new string[] { "cweferfq", "dveverq", "ccfdvq" };
			string.Concat("hello", " ", "world");

			Console.WriteLine(string.Join(", ", toJoin));

			Console.WriteLine(string.Compare(message1, message2));// == 0 - Equal

			Console.WriteLine(string.Compare(message1, "abc"));

			Console.WriteLine(message1.IndexOf("hell"));



			StringBuilder sb = new StringBuilder("Hello world!");
			Console.WriteLine($"Length: {sb.Length}");
			Console.WriteLine($"Capacity: {sb.Capacity}");

			sb.Append(" Welcome to C# programming.");
			Console.WriteLine(sb);
			Console.WriteLine($"Length: {sb.Length}");
			Console.WriteLine($"Capacity: {sb.Capacity}");

			sb.Append(" Hello!");
			Console.WriteLine(sb);
			Console.WriteLine($"Length: {sb.Length}");
			Console.WriteLine($"Capacity: {sb.Capacity}");

			sb.Append(" Ku!");
			Console.WriteLine(sb);
			Console.WriteLine($"Length: {sb.Length}");
			Console.WriteLine($"Capacity: {sb.Capacity}");

			sb.Insert(7, " qwerty!");
			Console.WriteLine(sb);

			sb.Replace("Hello", "KUKU");
			Console.WriteLine(sb);

			sb.Remove(0,20);
			Console.WriteLine(sb);

			string finalString = sb.ToString();

		}
	}
}
