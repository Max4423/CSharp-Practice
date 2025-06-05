using System.Xml.Linq;

var Max = new Person("Max", 20, new Company("Microsoft", 213));

//var Vasyl = Max;
var Vasyl = (Person)Max.Clone();

Vasyl.Name = "Vasyl";

Console.WriteLine(Max.Name);
Console.WriteLine(Vasyl.Name);
Console.WriteLine(Max.Equals(Vasyl));

Console.WriteLine(Vasyl.Work.NumberOfEmployees);

class Person : ICloneable
{
	public string Name { get; set; }
	public int Age { get; set; }
	public Company Work;
	public Person(string name, int age, Company work)
	{
		Name = name;
		Age = age;
		Work = work;
	}
	//superficial copying

	//public object Clone()
	//{
	//	return new Person(Name, Age, Work);
	//}

	//deep copying

	public object Clone()
	{
		return new Person(Name, Age, new Company(Work.Name, Work.NumberOfEmployees));
	}
}

class Company
{
	public string Name { get; set; }
	public int NumberOfEmployees { get; }
	public Company(string name, int numberOfEmployees )
	{
		Name = name;
		NumberOfEmployees = numberOfEmployees;
	}
}