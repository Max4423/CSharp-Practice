using System;

namespace GenericsMetanit
{
	class Company<T>
	{
		public T CEO { get; set; }
		public Company(T ceo)
		{
			CEO = ceo;
		}
	}
	class Person<T>
	{
		public T Id { get;}
		public string Name { get; set; }
		public static T? Code;
		public Person(T id, string name)
		{
			Id = id;
			Name = name;
		}
	}

	class FewUniqParams<T, K>
	{
		public T Id { get; }
		public K Password { get; set; }
		public string Name { get; }
		public FewUniqParams(T id, K password, string name)
		{
			Id = id;
			Name = name;
			Password = password;
		}
	}

	internal class Program
	{
		static void Swap <T> (ref T x, ref T y)
		{
			T temp = x;
			x = y;
			y = temp;
		}
		static void Main(string[] args)
		{
			Person <int> ceo = new Person <int>(1, "John Doe");
			Person<int>.Code = 234;


			Person <string> manager = new Person<string>("F2", "Jane Smith");
			Person<string>.Code = "A1B2C3";	
			Company <Person<int>> BMW = new Company<Person<int>> (ceo);

			FewUniqParams<int, string> fw = new FewUniqParams<int, string>(1,"max1234", "Max");

			var x = 3;
			var y = 1234;
			Swap<int>(ref x, ref y);
			Console.WriteLine(x);
			Console.WriteLine(y);
		}
	}
}
