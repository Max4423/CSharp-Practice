Console.OutputEncoding = System.Text.Encoding.UTF8;
int[] sectors = { 6, 28, 15, 15, 17 };
bool isOpen = true;
while (isOpen)
{
    Console.SetCursorPosition(0, 18);
    for (int i = 0; i < sectors.Length; i++)
    {
        Console.WriteLine($"В секторі {i + 1} вільно {sectors[i]} місць");
    }

    Console.SetCursorPosition (0, 0);
    Console.WriteLine("Реєстрація рейсу");
    Console.WriteLine("1 - забронювати місця \n" +
        "2 - вийти із програми");
    Console.WriteLine();
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int userSector, userPlaceAmount;
            Console.Write("У якому секторі хочете забронювати місце? ");
            userSector = (Convert.ToInt32(Console.ReadLine()) - 1);
            Console.Write("Скільки місць хочете забронювати?");
            userPlaceAmount = Convert.ToInt32(Console.ReadLine());
            if (sectors.Length <= userSector || userSector < 0)
            {
                 Console.WriteLine("Такого сектора не існує!"); 
                break;
            }
            if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
            {
                Console.WriteLine($"В секторі {userSector+1} недостатньо місць! " +
                    $"Залишок: {sectors[userSector]}");
                break;
            }
            sectors[userSector] -= userPlaceAmount;
            Console.WriteLine("Місця успішно заброньовані!");
            break;
        case 2:
            isOpen = false;
            break;
    }
    Console.ReadKey();
    Console.Clear();
}
