namespace DateTimeStruct;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);
        
        Console.WriteLine(dt.ToString("yyyy/mm/dd"));

        var dt2 = dt.AddMonths(-1);
        Console.WriteLine(dt);

        Console.WriteLine(dt.Subtract(dt2).Days);

        DateOnly date = new DateOnly(dt.Year, dt.Month, dt.Day);
        Console.WriteLine(date);
        Console.WriteLine(date.DayNumber);
        TimeOnly time = new TimeOnly(dt.Hour, dt.Minute, dt.Second);
        Console.WriteLine(time);
    }
}