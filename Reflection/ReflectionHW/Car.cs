using System;
using System.Reflection;

public class Car
{
	public string Brand { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }

	public Car(string Brand)
	{
		this.Brand = Brand;
	}
	private int CylindersNumber = 4;
	public Car(string Brand, string Model, int Year, int CylindersNumber)
	{
		this.Brand = Brand;
		this.Model = Model;
		this.Year = Year;
		this.CylindersNumber = CylindersNumber;
	}
	public Car()
	{
		
	}

	public void Drive(int speed)
	{
		Console.WriteLine($"Car is driving with speed {speed} km/h");
	}
}
