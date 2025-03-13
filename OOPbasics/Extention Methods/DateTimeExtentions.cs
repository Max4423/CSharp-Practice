using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Extention_Methods
{
	static class DateTimeExtentions
	{
		public static void Print(this DateTime dt)
		{
			Console.WriteLine(dt);
		}

		public static bool IsWeekend(this DateTime dt, DayOfWeek today)
		{
			if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
