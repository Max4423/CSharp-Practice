using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            long[] numbers = Digitizer.Digitize(123456789);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }

    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            int NumbersCount = n.ToString().Length;

            if (n == 0)
            {
                return new long[] { 0 };
            }

            var digits = new List<long>();

            long tempNumber = n;

            while (tempNumber > 0)
            {
                digits.Add(tempNumber % 10);
                tempNumber /= 10;
            }

            return digits.ToArray();
        }
    }
}