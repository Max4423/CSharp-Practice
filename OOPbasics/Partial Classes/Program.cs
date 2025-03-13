namespace Partial_Classes
{
	partial class Person
	{
		private int WorkExperience { get; set; }

		public Person(string fullName, int age, int workExperience)
		{
			WorkExperience = workExperience;
			FullName = fullName;
			Age = age;
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Person Max = new Person("Max", 19);

		}
	}
}
