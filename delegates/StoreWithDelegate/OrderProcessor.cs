using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StoreWithDelegate
{
	public class OrderProcessor
	{
		public OrderProcessor(int qtty, string name, OrderHandler orderMethod)
		{
			Quantity = qtty;
			Name = name;
			OrderMethod = orderMethod;

			if (Quantity > 0)
				OrderMethod(Name, Quantity);
			else
				Console.WriteLine("Order cannot be 0 or negative");
		}
		public delegate void OrderHandler(string productName, int quantity);

		private int Quantity { get; set; }

		private string Name { get; set; }
		private OrderHandler OrderMethod { get; set; }



	}

}
