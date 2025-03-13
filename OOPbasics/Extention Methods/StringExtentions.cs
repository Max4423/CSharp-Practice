using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods
{
    static class StringExtentions
    {
     public static int WordsCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }
           

            return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Reverse(this string str)
        {
            string reversed = "";

            for (int i = 0; i < str.Length; i++)
            {
				reversed  += str[str.Length - i - 1];
			}
            return reversed;
		}

        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
