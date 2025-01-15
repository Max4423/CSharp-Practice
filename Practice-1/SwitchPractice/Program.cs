string day;
Console.Write("Input a day of week:");
day = Console.ReadLine();

switch (day)
{
	case "monday":
        Console.WriteLine("Study c#");
		break;
	case "tuesday":
        Console.WriteLine("Study ASP.NET");
		break;
	case "wednesday":
		Console.WriteLine("Study math");
		break;
	case "thursday":
        Console.WriteLine("Study JS");
		break;
	case "friday":
        Console.WriteLine("Study F#");
		break;
	case "saturday":
    case "sunday":
        Console.WriteLine("Chill");
		break;

	default:
        Console.WriteLine("Error in day input");
		break;
}

Console.ReadKey();