namespace FactoryPattern;

public class AddressFactory: IFactory<Address>
{
    public Address CreateInstance()
    {
        return new Address
        {
            PostalCode = 12345,
            City = "Kyiv",
        };
    }
}