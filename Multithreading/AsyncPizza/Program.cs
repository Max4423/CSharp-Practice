// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using AsyncPizza;

await RunProgramAsync();

async Task RunProgramAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var pizza1 = PizzaFactory.ProducePizzaAsync("Margherita");
    var pizza2 = PizzaFactory.ProducePizzaAsync("Pepperoni");

    var pizza3 = PizzaFactory.ProducePizzaAsync("Cheese");

    await Task.WhenAll(pizza1, pizza2, pizza3);
    sw.Stop();

    Console.WriteLine(sw.Elapsed.Seconds + " seconds");

    Console.WriteLine($"My pizaa is {pizza1.Result.Name} and it costs {pizza1.Result.Price}");
    Console.WriteLine($"My pizaa is {pizza2.Result.Name} and it costs {pizza2.Result.Price}");
    Console.WriteLine($"My pizaa is {pizza3.Result.Name} and it costs {pizza3.Result.Price}");
}