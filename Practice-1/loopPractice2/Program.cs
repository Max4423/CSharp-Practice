Console.OutputEncoding = System.Text.Encoding.Unicode;
float money;
int years;
int percent;
Console.Write("Введіть к-сть грошей на вклад: ");
money = Convert.ToSingle(Console.ReadLine());
Console.Write("Введіть роки: ");
years = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть річну ставку у відсотках: ");
percent = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i < years; i++ )
{
    money += money / 100 * percent;
    Console.WriteLine($"У році {i+1} у вас {money} грошей");
    Console.ReadKey();
}