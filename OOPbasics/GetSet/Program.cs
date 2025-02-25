using System.Runtime;

namespace GetSet
{
	class Point
	{
		private int x;
		private int y;
		public int z { get; set; }

		public int GetX()
		{
			return x;
		}

		public void SetX(int x)
		{
			if (x <= 5 && x >= -5)
			{
				this.x = x;

			}

			else if (x < -5)
			{
				this.x = -5;
			}

			else if (x > 5)
			{
				this.x = 5;
			}
		}


		public int Y
		{
			get {
				return y;
			}
			set {
				if (value > 5)
				{
					y = 5;
					return;

				}
				else if (value < -5)
				{
					y = -5;
					return;
				}

					y = value; 
			}
		}
		



	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Point point = new Point();
			int xx = Convert.ToInt32(Console.ReadLine());
			point.SetX(xx);
			xx = point.GetX();

			int yy = Convert.ToInt32(Console.ReadLine());
			point.Y = yy;

			int zz = Convert.ToInt32(Console.ReadLine());

			point.z = zz;
			Console.WriteLine($"Point: \nX = {xx} \nY = {point.Y} \n Z = {point.z} ");

				}
	}
}
