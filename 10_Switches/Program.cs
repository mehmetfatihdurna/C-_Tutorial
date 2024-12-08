// See https://aka.ms/new-console-template for more information


Console.WriteLine("What is it today: ");
String day = Console.ReadLine().ToLower();

switch (day)
{
    case "monday":
        Console.WriteLine("FirstDay");
        break;
    case "tuesday":
        Console.WriteLine("second day");
        break;
    case "wednesday":
        Console.WriteLine("third day");
        break;
    case "thursday":
        Console.WriteLine("fourth day");
        break;
    case "friday":
        Console.WriteLine("fifth day");
        break;
    case "saturday":
        Console.WriteLine("sixth day");
        break;
    case "sunday":
        Console.WriteLine("seventh day");
        break;
    default:
        Console.WriteLine("Please enter only day name");
        break;

}

Console.ReadKey();