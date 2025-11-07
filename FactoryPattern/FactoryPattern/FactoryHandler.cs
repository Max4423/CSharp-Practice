namespace FactoryPattern;

public static class FactoryHandler
{
    private static readonly PersonFactory? PersonFactory = new PersonFactory();
    private static readonly AddressFactory? AddressFactory = new AddressFactory();

    public static IFactory<T>? GetFactory<T>()
    {
        if (typeof(T) == typeof(Person))
        {
            return PersonFactory as IFactory<T>;
        }
        if (typeof(T) == typeof(Address))
        {
            return AddressFactory as IFactory<T>;
        }
        return default;
    }

}