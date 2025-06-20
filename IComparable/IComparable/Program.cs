var Max = new Person("Max", 54);
var Ivan = new Person("Ivankoo", 54);
var Kate = new Person("Kate", 25);

Console.WriteLine(Max.CompareTo(Ivan));

Person[] ps = { Max, Ivan, Kate };
Array.Sort(ps, new PersonComparer());

foreach (var item in ps)
{
	Console.WriteLine($"{item.Name} - {item.Age}");
}
class Person : IComparable<Person>
{
	public string Name { get; }
	public int Age { get; set; }
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}

	public int CompareTo(Person? person)
	{
		if (person is null)
		{
			throw new ArgumentException("Invalid person object");
		}
		return Name.CompareTo(person.Name);

	}

}

class PersonComparer : IComparer<Person>
{
	public int Compare(Person? p1, Person? p2)
	{
		if (p1 is null || p2 is null)
		{
			throw new ArgumentException();
		}
		return p1.Name.Length - p2.Name.Length;
	}
}