Console.OutputEncoding = System.Text.Encoding.UTF8;
bool isOpen = true;
string[,] books =
{
    {"Ivan Franko","Taras Shevchenko","Lesya Ukrainka"},
    {"Robert Martin", "Jessie Shell", "Panas Myrnyy"},
    {"Steven King", "Hovard Lackraft", "Brem Stoker"}
};

while (isOpen)
{
    Console.SetCursorPosition(0, 20);
    Console.WriteLine("\nВесь список авторів:\n");
    for (int i = 0; i < books.GetLength(0); i++)
    {
        for (int j = 0; j < books.GetLength(1); j++)
        {
            Console.Write(books[i, j] + " | ");
        }
        Console.WriteLine("");
    }
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Library");
    Console.WriteLine("1 - дізнатись ім'я автора по індексу.\n 2 - знайти книгу по автору \n 3 - вихід ");
    Console.WriteLine("\n Виберіть пункт меню: ");

    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1 :
            int line, column;
            Console.WriteLine("Введіть номер полиці: ");
            line = (Convert.ToInt32(Console.ReadLine())) - 1;
            Console.WriteLine("Введіть номер cтовбця: ");
            column = (Convert.ToInt32(Console.ReadLine())) - 1;

            if (line >= books.GetLength(0) || column >= books.GetLength(1))
            {
                Console.WriteLine("Такої книги не існує!");
                break;
            }
            Console.WriteLine("Це автор: " + books[line, column]);
            break;
        case 2:
            bool authorIsFound = false;
            string author;
            Console.Write("Введіть автора: ");
            author = Console.ReadLine();
            for (int i = 0; i < books.GetLength(0); i++)
            {
                for (int j = 0; j < books.GetLength(1); j++)
                {
                    if (author.ToLower() == books[i, j].ToLower())
                    {
                        authorIsFound = true;
                        Console.WriteLine($"Книга автора {author} знаходиться на полиці {i + 1} стовбці {j + 1}");
                    }
                }
            }

            if (authorIsFound == false)
            {
                Console.WriteLine("Такого автора не знайдено!");
            }
            break;
        case 3:
            isOpen = false;
            break;
        default:
            Console.WriteLine("Такого пункту меню не існує!");
            break;  
    }

    if (isOpen)
    {
        Console.WriteLine("\n Натисніть будь-яку клавішу для продовження...");
    }
    Console.ReadKey();
    Console.Clear();
}