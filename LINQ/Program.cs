namespace LINQ;

class Program
{
	static void Main(string[] args)
	{
		List<Employee> employees = new List<Employee>()
		{
			new Employee("Max", "Mustermann", 23),
			new Employee("Ivan", "reqwr", 33),
			new Employee("Petro", "dewf", 34),
			new Employee("Semen", "we", 41),
			new Employee("Viktor", "rew", 27),
		};

		List<Employee> oldEmployees = new List<Employee>();

		foreach (var employee in employees)
			if (employee.Age > 30)
				oldEmployees.Add(employee);


		List<Employee> veryOldEmployees = MyWhere(employees, x => x.Age > 40);
		foreach (var voe in veryOldEmployees)
		{
			Console.WriteLine(voe.FirstName);
		}

		// Linq .Where

		var veryOldEmployees2 = employees.Where(x => x.Age > 30);

		foreach (var voe in veryOldEmployees2)
		{
			Console.WriteLine("LINQ " + voe.FirstName);
		}

		//Linq .Select

		var shortEmployees = employees.Select(e => new ShortEmployee() { Name = e.FirstName + " " + e.LastName, BirthYear = DateTime.Today.Year - e.Age });

		var employeeNames = employees.Select(e => e.FirstName);

		foreach (var name in employeeNames)
		{
			Console.WriteLine(name);

		}

		foreach (var shortEmployee in shortEmployees)
		{
			Console.WriteLine(shortEmployee.Name + " " + shortEmployee.BirthYear);
		}

		var employeeAge = employees.Select(e => new {Age = e.Age, BirthYear = DateTime.Now.Year - e.Age});

		foreach (var age in employeeAge)
		{
            Console.WriteLine(age.Age + " " + age.BirthYear);

		}

		//Linq .SelectMany



	var users = new List<User>
{
	new User { Name = "Max", Phones = new List<string> { "111", "222" } },
	new User { Name = "Ivan", Phones = new List<string> { "333" } },
	new User { Name = "Petro", Phones = new List<string> { "444", "555" } }
};
		var userPhoneNumbers = users.SelectMany(u => u.Phones);

			foreach (var phones in userPhoneNumbers)
		{
            Console.WriteLine(phones);
		}
	//Linq .Any

	Console.WriteLine(shortEmployees.Any(e => e.BirthYear == 1991));
	}


	static List<Employee> MyWhere(List<Employee> employees, Func<Employee, bool> predicate)
	{
		List<Employee> newEmployees = new List<Employee>();

		foreach (var employee in employees)
		{
			if (predicate.Invoke(employee))
			{
				newEmployees.Add(employee);
			}
		}
		return newEmployees;
	}

}
class Employee
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }

	public Employee(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}
}

class ShortEmployee
{
	public string Name { get; set; }
	public int BirthYear { get; set; }
}

class User
{
	public string Name { get; set; }
	public List<string> Phones { get; set; }
}