namespace StoreWithDelegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			OrderProcessor op = new OrderProcessor(4, "Book", OnlineOrder);

			OrderProcessor op2 = new OrderProcessor(45, "Pen", OfflineOrder);

		}

		public static void OnlineOrder(string productName, int quantity)
		{
			Console.WriteLine($"Order with {quantity} {productName} was placed online.");
		}

		public static void OfflineOrder(string productName, int quantity)
		{
			Console.WriteLine($"Order with {quantity} {productName} was placed offline.");
		}


	}
}
