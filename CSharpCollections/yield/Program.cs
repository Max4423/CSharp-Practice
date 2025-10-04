using System.Collections;

namespace yield
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Company BMW = new Company(new Person[] { new Person("max"), new Person("vasyl"), new Person("ivan"), });

			foreach (var person in BMW)
			{
				Console.WriteLine(person.Name);
			}
		}
	}
	class Person
	{
		public string Name { get; }
		public Person(string name) => Name = name;
	}
	class Company: IEnumerable<Person>
	{
		Person[] personnel;
		public int Length => personnel.Length;

		public Company(Person[] personnel) => this.personnel = personnel;

		public IEnumerator<Person> GetEnumerator()
		{
			for (int i = 0; i < personnel.Length; i++)
			{
				yield return personnel[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
