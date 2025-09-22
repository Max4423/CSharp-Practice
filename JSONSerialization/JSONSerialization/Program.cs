using System.Text.Json;

namespace JSONSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car BMW = new Car("BMW", "M5", 2023,4,2);

            string json = JsonSerializer.Serialize(BMW, new JsonSerializerOptions {WriteIndented = true });

			Console.WriteLine(json);

            Car BMWCopied = JsonSerializer.Deserialize<Car>(json);


            Car c = JsonSerializer.Deserialize<Car>(json);



			Console.WriteLine("-----Objects array serialization-----");
            Car[] cars = { BMW, new Car("Mercedes", "E211", 2012, 6, 3.3) };

            string jsn = JsonSerializer.Serialize(cars, new JsonSerializerOptions() { WriteIndented = true });
			Console.WriteLine(jsn);

            Car[] carsDes = JsonSerializer.Deserialize<Car[]>(jsn);

            foreach (var car in carsDes)
            {
				Console.WriteLine(car.Model);
            }
        }
    }
}
