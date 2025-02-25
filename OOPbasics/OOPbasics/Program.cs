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
		public int sum;
		public DayOfWeek day;
		public string goods;

	}

	internal class Program
    {
		static void Main(string[] args)
        {
			Order order1 = new Order();

			order1.sum = 12;
			order1.day = DayOfWeek.Wednesday;

			Convert.ToInt32(Console.ReadLine());

		}
    }
}
