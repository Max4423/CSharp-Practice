namespace RestaurantOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isOpen = true;
            Table[] tables = { new Table(1, 4), new Table(2, 8), new Table(3, 10), new Table(4,4) };
            while (isOpen)
            {
                Console.WriteLine("Адміністрування ресторану");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("Введіть номер столу:");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Введіть к-сть місць, які хочете забронювати:");
                int wishPlaces = Convert.ToInt32(Console.ReadLine());

                bool isReservationCompleted = tables[wishTable].Reserve(wishPlaces);

                if (isReservationCompleted)
                {
                    Console.WriteLine("Місця заброньовано!");
                }
                else
                {
                    Console.WriteLine("Місця не заброньовано. Недостатньо місць!");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class Table
    {
        public int Number;
        public int MaxPlaces;
        public int FreePlaces;

        public Table(int number, int maxplaces)
        {
            Number = number;
            MaxPlaces = maxplaces;
            FreePlaces = maxplaces;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Стіл #{Number}. Вільно місць:{FreePlaces} із {MaxPlaces}");
        }

        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckNumberOfTable(int number)
        {
            if(Number == number)
            { return true; }
            else
            {
                return false;
            }
        }
    }
}