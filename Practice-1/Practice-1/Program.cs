Console.OutputEncoding = System.Text.Encoding.Unicode;
int health, armor, damage;
int precentConverter = 100;
Console.WriteLine("Введіть к-сть здоров'я, броні та урону");
health = Convert.ToInt32 (Console.ReadLine());
armor = Convert.ToInt32 (Console.ReadLine());
damage = Convert.ToInt32 (Console.ReadLine());

health -= damage * armor / precentConverter;
Console.WriteLine($"Вам було нанесено {damage} урону, у вас залишилось {health} здоров'я");