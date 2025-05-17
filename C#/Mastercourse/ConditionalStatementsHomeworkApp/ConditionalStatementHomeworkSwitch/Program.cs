

Console.Write("What is your name? ");
string firstName = Console.ReadLine();

switch (firstName.ToLower())
{
	case "tim" or "timothy":
        Console.WriteLine("Hello professor");
        break;
    default:
        Console.WriteLine("Hello student");
        break;
}



