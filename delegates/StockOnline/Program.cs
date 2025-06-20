namespace StockOnline
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StockExchangeMonitor UAHMonitor = new StockExchangeMonitor();

			UAHMonitor.ExchangeHandler = ProcessRate;

			UAHMonitor.Start();
		}
		static void ProcessRate(int rate, double EuroRate)
		{
			Console.Write("DOLLAR rate:" + rate);
			Console.WriteLine("\tEURO rate: " + EuroRate);
		}
	}

}
