/* Напишіть програму, в якій спочатку є пустий масив. Також є меню з наступних пунктів:
    
    1 - показати масив
    (виводиться значення всіх елементів. Якщо масив пустий - повідомлення "Масив пустий")
    
    2 - відредагувати значення
    (Якщо масив не пустий - програма питає індекс елементу, значення якого треба ввести. Після чого перевіряє,
    чи користувач ввів коректний індекс. Якщо так - питає значення, користувач вводить, воно записується.
    Якщо ні - каже "Ви ввели неправильний індекс, спробуйте знову в діапазоні від 0 до X". Якщо масив
    пустий - виводиться повідомлення "Масив пустий")
    
    3 - добавити новий елемент
    (додається новий елемент до масиву і вводиться його значення)

    4 - видалити елемент
    (програма запитує індекс елементу (в циклі, з перевіркою на коректність) і видаляє елемент. Якщо масив
    пустий - виводиться повідомлення "Масив пустий")

    0 - вихід*/


namespace ArraysOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[0];
			while (true)
			{
				Console.WriteLine("Меню:");
				Console.WriteLine("1 - показати масив");
				Console.WriteLine("2 - відредагувати значення");
				Console.WriteLine("3 - добавити новий елемент");
				Console.WriteLine("4 - видалити елемент");
				Console.WriteLine("0 - вихід");
				Console.Write("Виберіть пункт меню: ");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						ShowArray(array);
						break;
					case "2":
						EditArray(ref array);
						break;
					case "3":
						AddElement(ref array);
						break;
					case "4":
						DeleteElement(ref array);
						break;
					case "0":
						return;
					default:
						Console.WriteLine("Неправильний вибір, спробуйте знову.");
						break;
				}
			}
		}

		static void ShowArray(int[] array)
		{
			if (array.Length == 0)
			{
				Console.WriteLine("Масив пустий");
			}
			else
			{
				Console.WriteLine("Елементи масиву: " + string.Join(", ", array));
			}
		}

		static void EditArray(ref int[] array)
		{
			if (array.Length == 0)
			{
				Console.WriteLine("Масив пустий");
				return;
			}

			Console.Write("Введіть індекс елементу для редагування: ");
			if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < array.Length)
			{
				Console.Write("Введіть нове значення: ");
				if (int.TryParse(Console.ReadLine(), out int newValue))
				{
					array[index] = newValue;
				}
				else
				{
					Console.WriteLine("Неправильне значення.");
				}
			}
			else
			{
				Console.WriteLine($"Ви ввели неправильний індекс, спробуйте знову в діапазоні від 0 до {array.Length - 1}");
			}
		}

		static void AddElement(ref int[] array)
		{
			Console.Write("Введіть значення нового елементу: ");
			if (int.TryParse(Console.ReadLine(), out int newValue))
			{
				Array.Resize(ref array, array.Length + 1);
				array[^1] = newValue;
			}
			else
			{
				Console.WriteLine("Неправильне значення.");
			}
		}
		static void DeleteElement(ref int[] array)
		{
			if (array.Length == 0)
			{
				Console.WriteLine("Масив пустий");
				return;
			}

			Console.Write("Введіть індекс елементу для видалення: ");
			if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < array.Length)
			{
				for (int i = index; i < array.Length - 1; i++)
				{
					array[i] = array[i + 1];
				}
				Array.Resize(ref array, array.Length - 1);
			}
			else
			{
				Console.WriteLine($"Ви ввели неправильний індекс, спробуйте знову в діапазоні від 0 до {array.Length - 1}");
			}
		}
	}
}
