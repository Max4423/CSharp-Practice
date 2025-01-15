namespace Methods
{
    internal class Program
    {
       static int Double(int number)
		{
			return number * 2;
		}


		static void DrawTriangle()
		{
			Console.WriteLine("  /|");
			Console.WriteLine(" / |");
			Console.WriteLine("/__|");
		}

		static void DrawRectangle(char filling, int rows, int columns)
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
					Console.Write(filling);
					Console.WriteLine();

			}
		}	


		static void Print(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}		
		}

		static bool IsFound(int[] array, int number)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == number)
				{
					return true;
				}
			}
					return false;
		}	

		static int EnterInt()
		{
			return Convert.ToInt32(Console.ReadLine());
		}

		static int ChangeInt(ref int x)
		{
		 x *=100;
		return x+2;
		}

			static void Main(string[] args)
        {
            int number = 5;

			int[] masyv = new int[] { 1, 2, 3, 4, 5 };

			Console.WriteLine(Double(number)); 

			DrawTriangle();

			DrawRectangle('%', 350, 5);

			Print(masyv);
			bool isFOUNDED = false;
			while (!isFOUNDED)
			{
				Console.WriteLine("Enter a number: ");
				int numberToFind = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(IsFound(masyv, numberToFind));
				if (IsFound(masyv, numberToFind))
				{
					isFOUNDED = true;
				}

				Console.WriteLine($"Value {(isFOUNDED?"was":"wasnt")} found");
			}



			for (int row = 0; row < 8; row ++)
			{
				for (int col = row; col < 8; col++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine(EnterInt()*2);

			int x = 12;
			ChangeInt(ref x);
			Console.WriteLine(x);
		}



    }
}
