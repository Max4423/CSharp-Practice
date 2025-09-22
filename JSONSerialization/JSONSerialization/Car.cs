using System;
using System.Reflection;
namespace JSONSerialization
{ 
public class Car
{
	public Engine engine { get; set; }
		public string Brand { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }

	public Car(string Brand)
	{
		this.Brand = Brand;
	}
	public Car(string Brand, string Model, int Year, int CylindersNumber, double Volume)
	{
		this.Brand = Brand;
		this.Model = Model;
		this.Year = Year;
		engine = new Engine(CylindersNumber, Volume);

	}
	public Car()
	{

	}

	public void Drive(int speed)
	{
		Console.WriteLine($"Car is driving with speed {speed} km/h");
	}
}
}