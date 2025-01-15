Console.OutputEncoding = System.Text.Encoding.Unicode;
int triesCount = 5;
string password = "123456";
string userInput;

for (int i = 0; i <= triesCount; i++)
{
    Console.WriteLine("Введіть пароль");
    userInput = Console.ReadLine();
    if (userInput == password)
    {
        Console.WriteLine("Вітаємо, ви увійшли в систему");
        break;
    }
    else
    {
        Console.WriteLine("Невірний пароль");
        Console.WriteLine($"Залишилось {triesCount-i} спроби");
    }
}
