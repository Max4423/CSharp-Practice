using Microsoft.VisualBasic;
using My_Extention_Methods;

namespace Extention_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime dateTime = new DateTime(2025, 12, 1, 12, 5, 12);
			dateTime.Print();


			Console.WriteLine(dateTime.IsWeekend(DayOfWeek.Saturday));

			dateTime = dateTime.AddDays(3);
			Console.WriteLine(dateTime);

			string a = "asdv cvweddfv vwev   ";
			
			Console.WriteLine(a.WordsCount());
			Console.WriteLine(a.Reverse());

			int num = 121;

			Console.WriteLine(num.IsEven());

		}
	}
}
