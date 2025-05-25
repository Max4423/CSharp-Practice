using System.Diagnostics.CodeAnalysis;

using Newtonsoft.Json;

namespace OOPbasics
{
	enum DayOfWeek
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}
	class Order
	{
		required public int sum;
		public DayOfWeek day;
		public string goods;

		public const int discount = 10;
		public Order()
		{
			Console.WriteLine("Order was created");
		}
		public Order(Order order)
		{
			sum = order.sum;
			day = order.day;
			goods = order.goods;
		}
		~Order()
		{
			Console.WriteLine("Order is deleted");
		}

	}


	internal class Program
	{
		static void Main(string[] args)
		{
			Order order1 = new Order() { sum = 12 };

			order1.sum = 12;
			order1.day = DayOfWeek.Wednesday;
			order1.goods = "milk";
			Console.WriteLine(Order.discount);

			string json = JsonConvert.SerializeObject(order1);
			Console.WriteLine(json);

			File.WriteAllText("file.json", json);
			Console.WriteLine(File.ReadAllText("file.json"));
			Order orderjson = JsonConvert.DeserializeObject<Order>(File.ReadAllText("file.json"));

			Console.WriteLine(orderjson.day);

			int value = int.MaxValue;
			File.WriteAllText("max.txt", Convert.ToString(value));

			Order copiedOrder = new Order(order1) { sum = 123 };
			Console.WriteLine(copiedOrder.goods);

		}
	}
}
