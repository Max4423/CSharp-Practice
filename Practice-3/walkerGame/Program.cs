Console.CursorVisible = false;
char[,] map =
{
    {'#', '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ','x',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ','x',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','x',' ','#'},
    {'#', ' ',' ',' ',' ','#',' ','x',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#', '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
};
int userX = 6, userY = 6;
char[] bag = new char[1];   
while (true)
{
    Console.SetCursorPosition(0, 20);
    Console.Write("Сумка:");
    for (int i = 0; i < bag.Length; i++)
    {
        Console.Write(bag[i] + " ");
    }

    Console.SetCursorPosition(0, 0);

    for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(map[i, j]);
    }
    Console.WriteLine();
}

    Console.SetCursorPosition(userY, userX);
    Console.Write('@');

    ConsoleKeyInfo charkey = Console.ReadKey();

    switch (charkey.Key)
    {
        case ConsoleKey.UpArrow:
            if (map[userX - 1, userY] != '#')
            {
                userX--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (map[userX + 1, userY] != '#')
            {
                userX++;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (map[userX, userY - 1] != '#')
            {
                userY--;
            }
            break;
        case ConsoleKey.RightArrow:
            if (map[userX, userY + 1] != '#')
            {
                userY++;
            }
            break;
    }

    if (map[userX, userY] == 'x')
    {
        map[userX, userY] = 'o';   
        char[] tempbag = new char[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempbag[i] = bag[i];
        }
        tempbag[tempbag.Length - 1] = 'x';
        bag = tempbag;
    }
    Console.Clear();
}