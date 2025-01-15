using System.Globalization;

Dictionary<string, string> capitals = new Dictionary<string, string>();

capitals.Add("Ukraine", "Kyiv");

capitals.Add("USA", "Washington");
capitals.Add("France", "Paris");
capitals.Add("Germany", "Berlin");
capitals.Add("Japan", "Tokyo");
capitals.Add("Canada", "Ottawa");
capitals.Add("United Kingdom", "London");
capitals.Add("Australia", "Canberra");
capitals.Add("Brazil", "Brasilia");
capitals.Add("India", "New Delhi");
capitals.Add("Italy", "Rome");
capitals.Add("Spain", "Madrid");
capitals.Add("Mexico", "Mexico City");


foreach (KeyValuePair<string, string> capital in capitals)
{
    Console.WriteLine($"The capital of {capital.Key} is {capital.Value}");
}

capitals.Remove("USA");

foreach (string country in capitals.Keys)
{
    Console.WriteLine(country);
}


Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

foreach(string capital in capitals.Values)
{
    Console.WriteLine(capital);
}