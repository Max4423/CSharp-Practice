namespace EncryptingInArrays
{
	internal class Program
	{
		static void Print(char[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j]);
				}
			}
		}

		static void Decrypt(char[,] arr, int encryptionKey)
		{
			Console.WriteLine();
			int key = 0;
			while (key != encryptionKey)
			{
				Console.Write("Input a decryption key: ");
				key = Convert.ToInt32(Console.ReadLine());
				if (key != encryptionKey)
				{
					Console.WriteLine("Incorrect key!");

				}
			}
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = (char)(arr[i, j] - key);
				}
			}
		}
		static void Main(string[] args)
		{
			int encryptionKey = 5;

			char[,] message =  {
				{ (char)('I' + encryptionKey), (char)('t' + encryptionKey), (char)(' ' + encryptionKey) },
				{ (char)('i' + encryptionKey), (char)('s' + encryptionKey), (char)(' ' + encryptionKey) },
				{ (char)('k' + encryptionKey), (char)('e' + encryptionKey), (char)('y' + encryptionKey) }
			};

			Print(message);
			Decrypt(message, encryptionKey);
			Print(message);
		}

	}
}
