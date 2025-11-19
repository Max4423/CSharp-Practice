namespace AsyncPizza;

public static class PizzaFactory
{
   public static async Task<Pizza> ProducePizzaAsync(string name)
   {
      await Task.Delay(1000);
      return new Pizza()
      {
         Name = name,
         Price = 300
      };
   }
}