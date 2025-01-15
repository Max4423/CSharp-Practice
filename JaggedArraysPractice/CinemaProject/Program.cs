namespace CinemaProject
{
	internal class Program
	{

		static void PrintSeats(bool[][] seats)
		{
			Console.WriteLine("Seats in Cinema:");
			for (int i = 0; i < seats.Length; i++)
			{
				for (int j = 0; j < seats[i].Length; j++)
				{
					if (seats[i][j] == false)
					{
						Console.Write(0 + " ");
					}
					else
					{
						Console.Write(1 + " ");
					}
				}
				Console.WriteLine();
			}
		}
		
		static void BookSeat(bool[][] seats)
		{
			Console.Write("Please, enter a number of row:");
			int row = int.Parse(Console.ReadLine()) - 1;
			if (row < 0 || row >= seats.Length)
			{
				Console.WriteLine("Invalid row number!");
				return;
			}
			Console.Write("Please, enter a number of seat:");
			int seat = int.Parse(Console.ReadLine()) - 1;
			if (seat < 0 || seat >= seats[row].Length)
			{
				Console.WriteLine("Invalid seat number!");
				return;
			}
			if (seats[row][seat] == false)
			{
				seats[row][seat] = true;
				Console.WriteLine("Seat booked successfully!");
			}
			else
			{
				Console.WriteLine("Seat is already booked!");
			}
		}
		static void Main(string[] args)
		{
			bool[][] seats = new bool[3][]
			{
				new bool[] { false, false, false, false, false, false, false },
				new bool[] { false, false, false, false, false },
				new bool[] { false, false, false, false, false, false}
			};

			while (true)
			{
				int choice = 0;
				Console.WriteLine("1. Print seats");
				Console.WriteLine("2. Book a seat");
				Console.WriteLine("3. Exit");
				Console.Write("Please, enter your choice: ");
				choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						PrintSeats(seats);
						break;
					case 2:
						BookSeat(seats);
						break;
					case 3:
						return;
					default:
						Console.WriteLine("Invalid choice!");
						break;
				}
			}
		}
	}
}
