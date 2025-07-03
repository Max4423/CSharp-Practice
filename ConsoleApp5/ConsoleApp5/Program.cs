
namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			a aa = new();

			System.Console.WriteLine(aa.GetType().IsClass);
		}
	}

	public class a { int x; }

}
