namespace FileReader;

public record Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address PersonAddress { get; set; }
}