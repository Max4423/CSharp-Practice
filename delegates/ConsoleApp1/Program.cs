using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] { 1, 2, 3,3,453,2,2,1,4 }, x =>x % 2 == 0));
        }

        public static int Sum(int[] array, Func<int,bool> isEven)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (isEven(array[i]))
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }

    delegate bool IsEven(int a);
}