using System;

namespace Interfaces
{
	interface IDataProvider
	{
	 string GetData();
	}
	interface IDataProcessor
	{
		void ProcessData(IDataProvider dataProvider);
	}

	class DBDataProvider : IDataProvider
	{
		public string GetData()
		{
			return "Data from DB";
		}
	}

	class FileDataProvider : IDataProvider
	{
		public string GetData()
		{
			return "Data from file";
		}
	}

	class ConsoleDataProcessor : IDataProcessor
	{
		public void ProcessData(IDataProvider dataProvider)
		{
			Console.WriteLine(dataProvider.GetData());
		}
	}
	
	internal class Program
	{
		static void Main(string[] args)
		{
			IDataProcessor dataProcessor = new ConsoleDataProcessor();
			IDataProvider dataProvider = new FileDataProvider();
			dataProcessor.ProcessData(dataProvider);
		}
	}
}
