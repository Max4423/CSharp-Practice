namespace LINQC_
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			//Знайди всі парні числа.
			var evenNumbers = numbers.Where(n => (n % 2 == 0));

			ShowCollection(evenNumbers);
			//Знайди суму всіх непарних чисел.
			int oddSum = numbers.Where(n => (n % 2 !=0)).Sum();
			Console.WriteLine(oddSum);
			//Виведи найбільше і найменше число.
			int max = numbers.Max();
			Console.WriteLine(max);
			int min = numbers.Min();
			Console.WriteLine(min);

			//Знайди середнє арифметичне всіх чисел.

			double mean = numbers.Average();
			Console.WriteLine(mean);

			List<string> words = new List<string> { "cat", "dog", "apple", "car", "banana", "carrot", "cucumber", "avocado" };

			//Виведи всі слова, які починаються з літери "c".
			var c = words.Where(c => c.ToLower().StartsWith("c"));
			ShowCollection(c);
			//Знайди найдовше слово.
			string longest = words.OrderByDescending(x => x.Length).First();

			Console.WriteLine(longest);
			//Виведи список унікальних перших літер(тобто без повторів).
			var uniqueFirstLeters = words.Select(x => x.First()).Distinct();
			ShowCollection(uniqueFirstLeters);
			//Відсортуй слова за довжиною.
			var sorted = words.OrderBy(x => x.Length);
			ShowCollection(sorted);
			List<Student> students = new List<Student>
{
	new Student { Name = "Max", Age = 19, Group = "A" },
	new Student { Name = "Ivan", Age = 22, Group = "B" },
	new Student { Name = "Petro", Age = 21, Group = "A" },
	new Student { Name = "Olya", Age = 20, Group = "C" },
	new Student { Name = "Katya", Age = 19, Group = "B" },
};

			Console.WriteLine("=====================================");
			//	//Знайди всіх студентів старших за 20 років.
			var oldStudents = students.Where(x => x.Age > 20);

			foreach (var st in oldStudents)
			{
				Console.WriteLine(st.Name);
			}
			//Згрупуй студентів за групами та виведи результат.

			var grouppedStudents = students.GroupBy(x => x.Group);
			foreach (var gs in grouppedStudents)
			{
				Console.WriteLine(gs.Key);
				foreach (var s in gs)
				{
					Console.WriteLine(s.Name + " " + s.Group + " " + s.Age);
				}
			}
			//Порахуй кількість студентів у кожній групі.
			foreach (var gs in grouppedStudents)
			{
				Console.WriteLine(gs.Key + " " + gs.Count()); 
			}
			//Знайди імена студентів, які починаються на "M" або "K".

			var MorK = students.Where(n => (n.Name.ToUpper().StartsWith("M")) || n.Name.ToUpper().StartsWith("K"));

			foreach (var item in MorK)
			{
				Console.WriteLine(item.Name);
			}




			var orders = new[]
			{
	new { OrderId = 1, ProductId = 1 },
	new { OrderId = 2, ProductId = 2 },
	new { OrderId = 3, ProductId = 3 },
	new { OrderId = 4, ProductId = 1 },
};

			var products = new[]
			{
	new { ProductId = 1, Name = "Laptop" },
	new { ProductId = 2, Name = "Phone" },
	new { ProductId = 3, Name = "Tablet" },
			};
	//Зроби join, щоб отримати список замовлень з назвами продуктів.

var orderList = orders.Join(products, o => o.ProductId, p => p.ProductId, (o, p) => new { OrderId = o.OrderId, ProductName = p.Name });
			foreach (var o in orderList)
			{
				Console.WriteLine($"OrderId: {o.OrderId} ProductName: {o.ProductName}");
			}


			//Порахуй, скільки разів кожен продукт замовляли.

			var productsCount = orderList
				.GroupBy(p => p.ProductName)
				.Select(n => new { Product = n.Key, Count = n.Count() });

			foreach (var item in productsCount)
			{
				Console.WriteLine($"{item.Product}: {item.Count} times");
			}



		}
		public static void ShowCollection<T>(IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				Console.Write(item + " ");
			}

			Console.WriteLine();
		}
	}

	class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Group { get; set; }
	}


}
