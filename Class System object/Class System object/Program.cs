using System.Collections.Concurrent;

namespace Class_System_object
{

	class Person
	{
		// Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		// Constructor
		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		// Method: Returns full name
		public string GetFullName()
		{
			return $"{FirstName} {LastName}";
		}

		// Method: Returns a greeting message
		public string Greet()
		{
			return $"Hello, my name is {GetFullName()} and I am {Age} years old.";
		}

		public override bool Equals(object? obj)
		{
			if (obj is Person person)
			{
				return person.Age == Age &&
					person.FirstName == FirstName &&
					   person.LastName == LastName;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(FirstName, LastName, Age);

		}
	}

    internal class Program
    {
        static void Main(string[] args)
        {
            Person Max = new Person("Max", "Hladun", DateTime.Now.Year - 2005);

			Person Max1 = new Person("Max", "Hladun", DateTime.Now.Year - 2005);

			Max.ToString();

			Console.WriteLine(Max.GetType()); 
			Console.WriteLine(Max.GetHashCode());

			Console.WriteLine(Max1.GetHashCode());

			Console.WriteLine(Max.GetHashCode() == Max1.GetHashCode());

			Console.WriteLine(Max1.Equals(Max));
			Console.WriteLine(Max1.Equals(Max1)) ;
		}
	}
}
