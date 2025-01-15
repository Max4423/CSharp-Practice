
Console.WriteLine("Hello!");
Console.WriteLine("Are u here?");
errorMessage(12);

static void errorMessage(int a, int b = 2)
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bad internet connection");
    Console.WriteLine(a * b);
    Console.ForegroundColor = defaultColor;
}
