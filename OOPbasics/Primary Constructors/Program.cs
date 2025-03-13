namespace Primary_Constructors
{
	public class User(string name, int age)
	{
		public User(string name) : this(name, 18) { } 

		public void Display() => Console.WriteLine($"Name: {name}, Age: {age}");

		public void Deconstruct(out string personName, out int personAge)
		{
			personName = name;
			personAge = age;
		}
	}

	public class qw
	{
		public int age;
		public string name;

		public void Print()
		{
			Console.WriteLine($"{age} {name}");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			User us1 = new User("Max");
			User us2 = new User("Vasyl", 34);
			qw us3 = new qw { name = "qwerty", age = 12};

			(string name, int age) = us2;

			Console.WriteLine(name);
			Console.WriteLine(age);

			us3.Print();

			us1.Display();
			us2.Display();
		}
	}
}



