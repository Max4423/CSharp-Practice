using MyProject;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int input = 0;
            int a, b;
            while (true)
            {

            Console.WriteLine("1 - Add;\n" +
                "2 - Substract;\n" +
                "3 - Multiply;\n" +
                "4 - Divide;\n");
			Console.Write("Input an operation type: "); 
            input = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input a number a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
			Console.Write("Input a number b: ");
            b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			switch (input)
            {
                case 1:
                    Console.WriteLine(MyLibrary.Add(a, b)); 
                    break;
				case 2:
					Console.WriteLine(MyLibrary.Subtract(a, b)); 
                    break;
				case 3:
					Console.WriteLine(MyLibrary.Multiply(a, b)); 
                    break;
				case 4:
					Console.WriteLine(MyLibrary.Divide(a, b)); 
                    break;
                default:
					Console.WriteLine("Error in operation choosing");
                    break;
				}
			}
		}
    }
}
