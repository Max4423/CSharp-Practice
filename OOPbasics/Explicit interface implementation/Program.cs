namespace Explicit_interface_implementation
{
	interface IFirstInterface
	{
		void Show();
	}

	interface ISecondInterface
	{
		void Show();
	}

	class Printer : IFirstInterface, ISecondInterface
	{
		public void Show()
		{
			Console.WriteLine("Hello from common method))");
		}
	}

	class PrinterImproved:IFirstInterface, ISecondInterface
	{
		void IFirstInterface.Show()
		{
			Console.WriteLine("Hello from first interface method))");
		}
		void ISecondInterface.Show()
		{
			Console.WriteLine("Hello from second interface method))");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Printer pr = new Printer();
			PrinterImproved prim = new PrinterImproved();

			pr.Show();

			if (pr is ISecondInterface && pr is IFirstInterface)
			{
				pr.Show();
			}

			if (prim is IFirstInterface primint)
			{
				primint.Show();
			}

			if(prim is ISecondInterface primint2)
			{
				primint2.Show();
			}
		}
	}
}
