namespace FactoryPattern;

public class PersonFactory : IFactory<Person>
{
    public Person CreateInstance()
    {
        return new Person
        {
            Name = "Max",
            Age = 30
        };
    }
}