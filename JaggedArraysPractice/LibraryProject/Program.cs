namespace LibraryProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[][] library = new string[4][]{
				new string[] { "To Kill a Mockingbird", "1984", "The Great Gatsby" },
				new string[] { "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit" },
				new string[] { "Moby Dick", "War and Peace", "Crime and Punishment" },
				new string[] { "The Odyssey", "Ulysses", "The Divine Comedy" }
				};

			while (true)
			{
				Console.Write("Enter a book name for searching: ");
				string book = Console.ReadLine();
				bool isFound = false;
				for (int i = 0; i < library.Length; i++)
				{
					for (int j = 0; j < library[i].Length; j++)
					{
						if (library[i][j] == book)
						{
							Console.WriteLine("This book is available in the library!");
							Console.WriteLine($"Shelf: library[{i}][{j}]");
							isFound = true;
							break;
						}
					}
				}
				if (isFound == false)
				{
					Console.WriteLine("This book is NOT available in the library!");
				}
			}
		}
	}
}
