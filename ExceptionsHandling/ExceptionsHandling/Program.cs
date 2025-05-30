namespace ExceptionsHandling
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int yx = 123;

			Exception exep = new Exception();

			Console.WriteLine(exep.Data);
			try
			{
				int x = 5;
				int y = x / 0;
				Console.WriteLine($"Результат: {y}");
				Console.WriteLine("Кінець програми");
			}
			catch(DivideByZeroException ex) when (yx == 123)
			{

				Console.WriteLine("Catch");
				Console.WriteLine(ex.Message);
			}

			catch
			{
				Console.WriteLine("All exceptions");
			}
			finally
			{
				Console.WriteLine("Finally block");
			}
		}
	}
}
