/*Напишіть програму, в якій користувач вводить розмір масиву. Програма перевіряє, щоб це число було
   обов'язково більше за 0. Після чого створюється масив відповідного розміру типу int і користувач
   вводить значення кожного елементу. Виведіть масив на екран.
Виведіть на екран суму всіх елементів масиву.
Виведіть на екран максимальний і мінімальний елемент масиву.
Виведіть середнє арифметичне масиву*/

using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace ArrayPractice2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			void Liniya(int size)
			{
				Console.WriteLine();
				for (int i = 0; i < size; i++)
				{
					Console.Write("-");
				}
				Console.WriteLine();

			}
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int size = 0;
			while (size <= 0)
			{
				Console.Write("Введіть розмір масиву: ");
				size = Convert.ToInt32(Console.ReadLine());
				if (size <= 0)
					Console.WriteLine("Розмір повинен бути > 0!");
			}


			int[] userArr = new int[size];

			for (int i = 0; i < userArr.Length; i++)
			{
				Console.Write($"Введіть {i + 1} елемент масиву: ");
				userArr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Ваш масив: ");

			for (int i = 0; i < userArr.Length; i++)
			{
				Console.Write(userArr[i] + "   ");
			}

			//Виведіть на екран суму всіх елементів масиву.
			Console.WriteLine("\nСума Вашого масиву: ");
			int sumArr = 0;
			for (int i = 0; i < userArr.Length; i++)
			{
				sumArr += userArr[i];
			}
			Console.WriteLine(sumArr);

			//Виведіть на екран максимальний і мінімальний елемент масиву.


			Console.Write("\nМаксимальний елемент Вашого масиву: ");

			int maxElement = int.MinValue;
			for (int i = 0; i < userArr.Length; i++)
			{
				if (userArr[i] > maxElement)
					maxElement = userArr[i];

			}
			Console.WriteLine(maxElement);
			Console.Write("Мінімальний елемент Вашого масиву: ");

			int minElement = int.MaxValue;
			for (int i = 0; i < userArr.Length; i++)
			{
				if(userArr[i] < minElement)
					minElement = userArr[i];
			}
			Console.WriteLine(minElement);

			//Виведіть середнє арифметичне масиву
			Console.Write("Cереднє арифметичне Вашого масиву:");
			double mean = sumArr / (double)userArr.Length;
			Console.WriteLine(mean);


			//Після заповнення першого масиву створіть другий, куди скопіюйте всі
			//елементи першого масиву.Під кінець виведіть обидва масиви, щоб перевірити, чи вони рівні.

			int[] newUserArr = new int[userArr.Length];

			for (int i = 0; i < newUserArr.Length; i++)
				newUserArr[i] = userArr[i];

			Liniya(50);
			Console.WriteLine("\nOld Array:");
			for (int i = 0; i < userArr.Length; i++)
			{
				Console.Write(userArr[i] + " ");
			}

			Liniya(50);
			Console.WriteLine("\nCopied Array:");

			newUserArr[0] = 99999999;
			for (int i = 0; i < newUserArr.Length; i++)
				Console.Write(newUserArr[i] + " ");

			Liniya(50);
			Console.WriteLine("\nOld Array:");
			for (int i = 0; i < userArr.Length; i++)
			{
				Console.Write(userArr[i] + " ");
			}

			Liniya(50);

			Console.WriteLine("Reversed array:");
			for (int i = userArr.Length - 1; i >= 0 ; i--)
				Console.Write(userArr[i] + " ");


			Liniya(50);

			Console.WriteLine("Even values in array:");

			for (int i = 0; i < userArr.Length; i++)
				if (userArr[i] % 2 == 0)
					Console.Write(userArr[i] + " ");

			Liniya(50);

			Console.WriteLine("Odd values in array:");

			int oddCounter = 0;
			for (int i = 0; i < userArr.Length; i++)
				if (userArr[i] % 2 == 1)
				{ 	
					Console.Write(userArr[i] + " ");
					Console.WriteLine();
					oddCounter++;
				}
			Console.WriteLine($"{oddCounter} odd values");


			Liniya(50);

		
		}
	}
}
