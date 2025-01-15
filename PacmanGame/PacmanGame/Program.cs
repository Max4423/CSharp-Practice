using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
namespace PacmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            char[,] map = ReadMap("map.txt");

            int packX = 1;
            int packY = 1;

            int score = 0;
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0,11);
                Console.WriteLine($"Points: {score}");
                Console.SetCursorPosition(packX, packY);
                Console.Write("@");
                ConsoleKeyInfo pressKey = Console.ReadKey();

                HandleInput(pressKey, ref packX, ref packY, map, ref score);

                
                
            }
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetLengthOfLine(file), file.Length];

            for (int y = 0; y < map.GetLength(1); y++)
                for (int x = 0; x < map.GetLength(0); x++)
                    map[x, y] = file[y][x];

            return map;
        }

        private static int GetLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");
            }
        }

        private static void HandleInput(ConsoleKeyInfo pressKey, ref int packX, ref int packY, char[,] map, ref int score)
        {
            int[] direction = GetDirection(pressKey);

            int nextPackX = packX + direction[0];
            int nextPackY = packY + direction[1];

            char nextCell = map[nextPackX, nextPackY];
            if (nextCell == ' ' || nextCell == '*')
            {
                packX = nextPackX;
                packY = nextPackY;
                Task.Run(() => Console.Beep(400, 150));
                if (nextCell == '*')
                {
                    score++;
                    map[nextPackX, nextPackY] = ' ';
                }
            }


        }

        private static int[] GetDirection(ConsoleKeyInfo pressKey)
        {
            int[] direction = { 0, 0 };
            if (pressKey.Key == ConsoleKey.UpArrow)
            {
                direction[1] = -1;
            }
            else if (pressKey.Key == ConsoleKey.DownArrow)
            {
                direction[1] = 1;
            }
            else if (pressKey.Key == ConsoleKey.RightArrow)
            {
                direction[0] = 1;
            }
            else if (pressKey.Key == ConsoleKey.LeftArrow)
            {
                direction[0] = -1;
            }

            return direction;
        }
    }
}
