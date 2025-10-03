namespace Records;

class Program
{
    static void Main(string[] args)
    {
        Person Max = new Person("Max", 20);

        Console.WriteLine(Max.FirstName);
        Console.WriteLine(Max.FirstName);

        
        Person2 Max2 = new Person2("Max2", 20);
        Person2 Max3 = Max2 with { FirstName = "Max3" };
        
        
        string lastname = "Hladun";
        string firstName = "Max";
        
        (lastname, firstName) = (firstName, lastname);

        var tupple = (123, 3.12, "Hello");

        Console.WriteLine(tupple);
            
    }
}

class Person
{
    public Person(string firstName, int age)
    {
        FirstName = firstName;
        Age = age;
    }

    public string FirstName { get; init; }
    public int Age { get; set; }

    public static bool operator == (Person person1, Person person2)
    {
        return person1.FirstName == person2.FirstName && person1.Age == person2.Age;
    }
    
    public static bool operator != (Person person1, Person person2)
    {
        return person1.FirstName != person2.FirstName && person1.Age != person2.Age;
    }
}

record Person2
{
    public Person2(string firstName, int age)
    {
        FirstName = firstName;
        Age = age;
    }

    public string FirstName { get; init; }
    public int Age { get; set; }
}

