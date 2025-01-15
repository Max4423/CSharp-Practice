Console.OutputEncoding = System.Text.Encoding.UTF8;
int money, food;
int foodUnitPrice = 10;
bool moneyEnought;

Console.WriteLine($"Вітаємо в пекарні. Сьогодні їда по {foodUnitPrice}");
Console.Write("Скільки у вас золота: ");
money = Convert.ToInt32(Console.ReadLine());
Console.Write("Скільки їди вам потрібно: ");
food = Convert.ToInt32(Console.ReadLine());

moneyEnought = money >= foodUnitPrice * food;
food *= Convert.ToInt32(moneyEnought);
money -= food * foodUnitPrice;

Console.WriteLine($"У вас в сумці {food} їди та {money} золота");