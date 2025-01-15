namespace HealthBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 0, maxhealth = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 5);

                Console.Write("Input value: ");
                health = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Max value: ");
                maxhealth = Convert.ToInt32(Console.ReadLine());
                if (health > maxhealth)
                {
                    Console.WriteLine("Health cannot be higher than max health!");
                    continue;
                }
                Console.Write("Press Enter");

                Console.SetCursorPosition(0, 0);

                DrawBar(health, maxhealth, ConsoleColor.Red);
                DrawBar(12, 21, ConsoleColor.Blue, 1, '@');

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position = 0, char symbol = ' ')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');
        }
    }
}

