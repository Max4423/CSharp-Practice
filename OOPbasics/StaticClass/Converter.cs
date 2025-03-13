using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class Converter
    {
        private static readonly double rate;
        private static double money;

        static Converter()
		{
			rate = 41.52;

		}
		public static double DolarsToHryvnas(double money)
        {
            return money * rate;

		}

		public static double HryvnasToDollars(double money)
		{
			return money / rate;

		}
	}
}
