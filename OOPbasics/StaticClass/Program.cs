namespace StaticClass
{
	static class Logger
	{
		private static readonly DateTime startTime;

		static Logger()
		{
			startTime = DateTime.Now;

			Console.WriteLine($"Конструктор відпрацював у {startTime}");
		}

		public static void Log()
		{
			Console.WriteLine($"Time from constructor: {startTime - DateTime.Now}");
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Logger.Log();

			Thread.Sleep(500);

			Logger.Log();
			Console.WriteLine(Converter.DolarsToHryvnas(15.5));
			Console.WriteLine(Converter.HryvnasToDollars(300));
			
			
			
		}
	}
}
