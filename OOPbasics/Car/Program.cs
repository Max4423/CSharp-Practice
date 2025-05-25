using System.Drawing;
using System.Reflection;

namespace Car
{
	class Car
	{
		private string make;
		private string model;
		public int year;
		string color;
		double? engineSize = null;

		public Car()
		{

		}

		public Car(string make, string model, int year)
		{
			this.make = make;
			this.model = model;
			this.year = year;
		}
		public Car(string make, string model, int year, string color, double engineSize)
		{
			this.make = make;
			this.model = model;
			this.year = year;
			this.color = color;
			this.engineSize = engineSize;
		}

		public Car(Car car)
		{
			make = car.make;
			model = car.model;
			year = car.year;
			color = car.color;
			engineSize = car.engineSize;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"{make} {model} {year} {color} {engineSize} ");
		}

		public void Deconstruct(out string make, out string model, out int year, out string color, out double? engineSize)
		{
			make = this.make;
			model = this.model;
			year = this.year;
			color = this.color;
			engineSize = this.engineSize;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Car bmw = new Car(make: "BMW", model: "X5m", year: 2018);
			bmw.PrintInfo();

			Car mercedes = new Car(make: "Mercedes", model: "w211", year: 2020, engineSize: 3.0, color: "Black");
			mercedes.PrintInfo();

			Car bmw2 = new Car(bmw);
			bmw2.year = 1996;
			bmw2.PrintInfo();

			Car bmw3 = bmw;
			bmw3.year = 2025;
			bmw3.PrintInfo();
			bmw.PrintInfo();


			mercedes.Deconstruct(out string make, out string model, out int year, out string color, out double? engineSize);
			Console.WriteLine(make);
			Console.WriteLine(engineSize);

		}
	}
}
