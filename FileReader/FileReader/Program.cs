namespace FileReader;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person(){Age = 10, Name = "John Doe", PersonAddress = new Address(){City = "Lviv",PostalCode = "12345"}};
        
        FileReader<Person> frPerson = new FileReader<Person> ();
        frPerson.SaveToFile("PersonJohnDoe.json",person);
        
        Person person2 = frPerson.ReadFile("PersonJohnDoe.json");

        Console.WriteLine(person2);
    }
}

