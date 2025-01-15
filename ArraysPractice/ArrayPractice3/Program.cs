/*Користувач вводить розміри двох масивів. Порівняйте їх розміри завдяки властивості Length і скажіть,
   який масив більший (або чи вони рівні).

8. Ця задача є доповненням до попередньої. Якщо два масиви мають однакові розміри, то дайте користувачу
   можливість заповнити їх значеннями. Після цього виведіть два масиви на екран і порівняйте їх.
   Якщо масиви мають однаковий розмір і всіх їх елементи рівні між собою
   (типу arr1[0] == arr2[0], arr1[1] == arr2[1] і т.д.),
   то виведіть повідомлення "Ваші масиви однакові". Інакше виведіть "Ваші масиви різні.Користувач вводить розміри двох масивів. Порівняйте їх розміри завдяки властивості Length і скажіть,
   який масив більший (або чи вони рівні).

8. Ця задача є доповненням до попередньої. Якщо два масиви мають однакові розміри, то дайте користувачу
   можливість заповнити їх значеннями. Після цього виведіть два масиви на екран і порівняйте їх.
   Якщо масиви мають однаковий розмір і всіх їх елементи рівні між собою
   (типу arr1[0] == arr2[0], arr1[1] == arr2[1] і т.д.),
   то виведіть повідомлення "Ваші масиви однакові". Інакше виведіть "Ваші масиви різні.*/

using System.Threading.Channels;

namespace ArrayPractice3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter size of array - 1: ");
			int arrSize1 = Convert.ToInt32(Console.ReadLine());

			int[] array1 = new int[arrSize1];
			Console.WriteLine();
			Console.Write("Enter size of array - 2: ");
			int arrSize2 = Convert.ToInt32(Console.ReadLine());

			int[] array2 = new int[arrSize2];


			bool isLenths1EqualsLenth2 = array1.Length == array2.Length;

			if (isLenths1EqualsLenth2)
			{
				Console.WriteLine("The array sizes are equal");

				for (int i = 0; i < array1.Length; i++)
				{
					Console.Write($"Enter the {i + 1} element of the First array: ");

					array1[i] = Convert.ToInt32(Console.ReadLine());
				}

				for (int i = 0; i < array2.Length; i++)
				{
					Console.Write($"Enter the {i + 1} element of the Second array: ");

					array2[i] = Convert.ToInt32(Console.ReadLine());
				}

				Console.WriteLine("First Array:");
				for (int i = 0; i < array1.Length; i++)
				{
					Console.Write(array1[i] + " ");
				}
				Console.WriteLine();

				Console.WriteLine("Second Array:");

				for (int i = 0; i < array2.Length; i++)
				{
					Console.Write(array2[i] + " ");

				}
				bool arraysAreEqual = false;

				for (int i = 0; i < array1.Length; i++)
				{
					if (array1[i] != array2[i])
					{
						arraysAreEqual = false;
						Console.WriteLine();
						Console.WriteLine("Your arrays are inequal");
						break;
					}
					else
						arraysAreEqual = true;
				}

				if (arraysAreEqual)
				{
					Console.WriteLine();
					Console.WriteLine("Your arrays are equal");
				}



			}

			else if (array1.Length > array2.Length)
				Console.WriteLine("array 1 is larger than array 2 ");
			else if (array1.Length < array2.Length)
				Console.WriteLine("array 2 is larger than array 1");


			while(true)
				Console.ReadKey();
		}
	}
}
