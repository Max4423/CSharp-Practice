Console.OutputEncoding = System.Text.Encoding.Unicode;
Random rand = new Random();
float health1 = rand.Next(90, 100);
int armor1 = rand.Next(5, 20);
int damage1 = rand.Next(25, 65);

float health2 = rand.Next(80, 150);
int armor2 = rand.Next(20, 40);
int damage2 = rand.Next(65, 100);

Console.WriteLine($"Гладіатор #1:" +
    $" Здоров'я: {health1}" +
    $" Броня: {armor1}" +
    $" Урон: {damage1}");

Console.WriteLine($"Гладіатор #2:" +
    $" Здоров'я: {health2}" +
    $" Броня: {armor2}" +
    $" Урон: {damage2}");

while (health1 > 0 && health2 > 0)
{
    health1 -= Convert.ToSingle(rand.Next(0, damage2 +1))/100 * armor1;
    health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

    Console.WriteLine($"Здоров'я гладіатора 1 {health1}");

    Console.WriteLine($"Здоров'я гладіатора 2 {health2}");
}

if (health1 <= 0 && health2 <= 0)
{
    Console.WriteLine("Нічия!");
}
else if (health1 > health2)
{
    Console.WriteLine("Переміг гладіатор #1");
}
else if (health2 > health1)
{
    Console.WriteLine("Переміг гладіатор #2");
}