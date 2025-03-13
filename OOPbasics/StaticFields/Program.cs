namespace StaticFields
{

	class Point
	{
		private static int counter;

		public static int Counter
		{
			get { return counter; }
			private set { counter = value; }
		}
		public Point()
		{
			Counter++;
			y = 225;
		}

		public static int y;


		public static void PrintY()
		{
			Console.WriteLine(y);
		}


	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Point p = new Point();
			Console.WriteLine(Point.y); 
			Point.PrintY();
			Point p2 = new Point();

			Console.WriteLine(Point.Counter); 
 
		}
	}
}
