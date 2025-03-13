namespace Object_Initialization
{
	public class Engine
	{
		public double Volume;
		public string Fuel;
		public int Cylinders;
		public int HorsePower;

		public Engine(double Volume, string Fuel, int Cylinders, int HorsePower)
		{
			this.Volume = Volume;
			this.Fuel = Fuel;
			this.Cylinders = Cylinders;
			this.HorsePower = HorsePower;
		}
		public Engine()
		{
			
		}
	}
	public class Car
	{
		public string Model;
		public int Year;
		public Engine engine;

		public Car(string Model, int Year, Engine engine)
		{
			this.Model = Model;
			this.Year = Year;
			this.engine = engine;

		}
		public Car()
		{
			
		}

		public void PrintInfo()
		{
			Console.WriteLine(Model);
			Console.WriteLine(Year);
			Console.WriteLine($"{engine.Volume} {engine.Cylinders} {engine.Fuel} {engine.HorsePower}");
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Car BMW = new Car("BMW M5", 2021, new Engine(3.0, "Diesel", 6 , 310));
			BMW.PrintInfo();
			Console.WriteLine();
			Car Mercedes = new Car { Model = "Mercedes CLE", Year = 2018, engine = new Engine { Cylinders = 4, Fuel = "Diesel", HorsePower = 200, Volume = 2.5 } };
			Mercedes.PrintInfo();
		}
	}
}
