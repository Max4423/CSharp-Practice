using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOnline
{
	public class StockExchangeMonitor
	{
		public delegate void ExchangeD(int rate, double euroRate);
		public ExchangeD ExchangeHandler { get; set; }

		public void Start()
		{
			while (true)
			{
				int UAHRate = (new Random()).Next(50);
				int EuroRate= (new Random()).Next(50);


				ExchangeHandler(UAHRate, EuroRate);

				Thread.Sleep(300);
			}
		}
	}
}
