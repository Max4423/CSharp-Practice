using System.Diagnostics.CodeAnalysis;

namespace RefOut
{
	internal class Program
	{
		static void Change10(ref int x)
		{
			x = 10;
		}	

		/// <summary>
		/// Changes value to 20
		/// </summary>
		/// <param name="x"> Довільне число</param>
		static void Change20(out int x)
		{
			x = 20;
		}

		static void SumProduct(int a, int b, out int sum, out int product)
		{
			sum = a + b;
			product = a * b;
		}

		static void Main(string[] args)
		{

			int a = 5;
			Change10(ref a);
			Console.WriteLine(a); 
			int b;
			Change20(out b);
			Console.WriteLine(b); 

			int sum, product;

			SumProduct(3, 4, out sum, out product);

			Console.WriteLine(sum);
		}
	}
}

