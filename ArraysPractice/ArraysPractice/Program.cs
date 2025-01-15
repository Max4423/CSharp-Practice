//Створіть масив із 6 елементів типу double. Завдяки циклу for заповніть їх значеннями від 0.1. до 0.6.
//Виведіть його на екран. 
namespace ArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numb = new double[6];

            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = Math.Round(0.1 * (i + 1),1);
            }

            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine(numb[i]);
            }
        }
    }
}
