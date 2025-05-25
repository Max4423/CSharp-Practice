using System;
// Базовий клас з узагальненим параметром
class Person<T>
{
	public T Id { get; }
	public Person(T id)
	{
		Id = id;
	}
}

// Варіант 1: Наслідування з тим самим параметром
class UniversalPerson<T> : Person<T>
{
	public UniversalPerson(T id) : base(id) { }
}

// Варіант 2: Неузагальнений клас, використовує string
class StringPerson : Person<string>
{
	public StringPerson(string id) : base(id) { }
}

// Варіант 3: Наслідування з іншим параметром
class IntPerson<T> : Person<int>
{
	public T Code { get; set; }
	public IntPerson(int id, T code) : base(id)
	{
		Code = code;
	}
}

// Варіант 4: Клас із двома параметрами, другий має обмеження
class MixedPerson<T, K> : Person<T> where K : struct
{
	public K Code { get; set; }
	public MixedPerson(T id, K code) : base(id)
	{
		Code = code;
	}
}
class Program
{
	static void Main()
	{
		// Варіант 1: Наслідування з тим самим типом
		Person<string> person1 = new Person<string>("34");
		UniversalPerson<int> person2 = new UniversalPerson<int>(33);
		Person<int> person3 = new UniversalPerson<int>(45);

		Console.WriteLine(person1.Id);
		Console.WriteLine(person2.Id);
		Console.WriteLine(person3.Id);

		// Варіант 2: Неузагальнений клас-нащадок
		StringPerson person4 = new StringPerson("438767");
		Person<string> person5 = new StringPerson("43875");
		Console.WriteLine(person4.Id);
		Console.WriteLine(person5.Id);

		// Варіант 3: Наслідування з іншим параметром
		IntPerson<string> person7 = new IntPerson<string>(5, "r4556");
		Person<int> person8 = new IntPerson<long>(7, 4587);
		Console.WriteLine(person7.Id);
		Console.WriteLine(person8.Id);

		// Варіант 4: Клас із двома параметрами
		MixedPerson<string, int> person9 = new MixedPerson<string, int>("456", 356);
		Person<string> person10 = new MixedPerson<string, int>("9867", 35678);
		Console.WriteLine(person9.Id);
		Console.WriteLine(person10.Id);
	}
}

