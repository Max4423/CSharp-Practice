//псевдоніми типів:
using printer = System.Console;
namespace Null_Nullable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int? number = null;
			int ch = 0;
			Console.WriteLine("Do you want to input random number? \n0-No: \n1 - Yes");
			ch = Convert.ToInt32(Console.ReadLine());
			if (ch == 1)
			{
				number = Convert.ToInt32(Console.ReadLine());
			}
			if (number.HasValue)
			{
				Console.WriteLine("Number = " + number);
			}
			else
			{
				Console.WriteLine("You don`t input a random number!");
			}

				int choice = 0;
			Console.WriteLine("0 - don`t input fullname");
			Console.WriteLine("1 - input fullname");
			choice = Convert.ToInt32(Console.ReadLine());

			string fullname = null;
			if (choice == 1)
			{
				fullname = Console.ReadLine();
				Console.WriteLine(fullname);

			}
			if (fullname == "")
			{
				Console.WriteLine("Empty string");
			}
			if(fullname == null) 
			{
				Console.WriteLine("No data");
			}

			//оператор null-об'єднання
			int? x = null;

			int? y = x ?? 12345;

			Console.WriteLine(y);

			//оператор умовного null

			//можна писати 
			if (fullname != null)
			{
				fullname.ToUpper();
			}

			// А з оператором умовного null

			fullname?.ToUpper();




			//використання псевдонімів типів

			int? a = 12;
			a?.CompareTo(0);



			printer.WriteLine("Використовується псевдонім типу!!!");
		}
	}
}
