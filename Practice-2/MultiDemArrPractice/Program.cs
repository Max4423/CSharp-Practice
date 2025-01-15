using System.Security.Cryptography;

int[,] arr =
{
    {2, 4, 6, 8 },
    {1, 3, 5, 7 },
    {0, 9, 8, 7 }

};

int number = 0;
bool isOpen = true;

while(isOpen){

Console.SetCursorPosition(0,20);
    Console.WriteLine("\nМасив: \n");
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j <arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.SetCursorPosition(0,0);
    Console.WriteLine( "1 - Пошук позиції числа в масиві\n" +
        "2 - Заміна числа в масиві" );
    Console.Write("Ваш вибір: ");
int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            Console.Write("Введіть число для пошуку: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == number)
                    {
                        Console.WriteLine($"Число {number} знаходиться на позиції {i + 1} рядку та {j + 1} стовпці");
                    }
                }
            }
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Такої операції не існує!");
            break;
    }

    Console.ReadKey();
    Console.Clear();
}

