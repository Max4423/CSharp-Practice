namespace WhatKeyUPressed
{
    internal class Program
    {
		static void Main(string[] args)
        {
			while (true)
            {
				ConsoleKey PressedKey = Console.ReadKey().Key;

				int keyCode = (int)PressedKey;
				Console.WriteLine("You pressed: " + keyCode + " " + PressedKey);

				if (PressedKey == ConsoleKey.Escape)
				{
					break;
				}
			}
        }
    }
}
