using System;

class Program
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		// Створення дошки
		char[,] board = new char[3, 3];
		InitializeBoard(board);

		bool isGameRunning = true;
		char currentPlayer = 'O'; // Починає гравець, що грає нуликами

		while (isGameRunning)
		{
			PrintBoard(board);

			Console.WriteLine($"Гравець {currentPlayer}, ваш хід.");
			int row, col;

			while (true)
			{
				Console.Write("Введіть номер рядка (0-2): ");
				row = ReadIndex();
				Console.Write("Введіть номер стовпчика (0-2): ");
				col = ReadIndex();

				if (row < 0 || row >= 3 || col < 0 || col >= 3)
				{
					Console.WriteLine("Помилка: індекс виходить за межі дошки. Спробуйте ще раз.");
				}
				else if (board[row, col] != ' ')
				{
					Console.WriteLine("Помилка: ця клітинка вже зайнята. Спробуйте ще раз.");
				}
				else
				{
					break;
				}
			}

			board[row, col] = currentPlayer;
			Console.Clear();

			// Перевірка на перемогу чи нічию
			if (CheckWin(board, currentPlayer))
			{
				PrintBoard(board);
				Console.WriteLine($"Гравець {currentPlayer} виграв!");
				isGameRunning = false;
			}
			else if (IsDraw(board))
			{
				PrintBoard(board);
				Console.WriteLine("Нічия!");
				isGameRunning = false;
			}
			else
			{
				// Зміна гравця
				currentPlayer = currentPlayer == 'O' ? 'X' : 'O';
			}
		}
	}

	static void InitializeBoard(char[,] board)
	{
		for (int i = 0; i < board.GetLength(0); i++)
		{
			for (int j = 0; j < board.GetLength(1); j++)
			{
				board[i, j] = ' ';
			}
		}
	}

	static void PrintBoard(char[,] board)
	{
		Console.WriteLine("  0 1 2");
		for (int i = 0; i < board.GetLength(0); i++)
		{
			Console.Write(i + " ");
			for (int j = 0; j < board.GetLength(1); j++)
			{
				Console.Write(board[i, j]);
				if (j < board.GetLength(1) - 1) Console.Write("|");
			}
			Console.WriteLine();
			if (i < board.GetLength(0) - 1) Console.WriteLine("  -----");
		}
	}

	static int ReadIndex()
	{
		int index;
		while (!int.TryParse(Console.ReadLine(), out index))
		{
			Console.WriteLine("Помилка: введіть число.");
		}
		return index;
	}

	static bool CheckWin(char[,] board, char player)
	{
		// Перевірка рядків і стовпчиків
		for (int i = 0; i < 3; i++)
		{
			if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
				(board[0, i] == player && board[1, i] == player && board[2, i] == player))
			{
				return true;
			}
		}

		// Перевірка діагоналей
		if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
			(board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
		{
			return true;
		}

		return false;
	}

	static bool IsDraw(char[,] board)
	{
		foreach (char cell in board)
		{
			if (cell == ' ')
			{
				return false;
			}
		}
		return true;
	}
}
