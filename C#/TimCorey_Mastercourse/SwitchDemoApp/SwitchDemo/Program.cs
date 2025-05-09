

string firstName = "sue";
int age = 33;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child.");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job.");
        break;
    case >= 66:
        Console.WriteLine("Hopefully you are retired or retiring soon.");
        break;
    default:
        Console.WriteLine("Age was not in an expected range");
        break;
}


//switch (firstName.ToLower())
//{
//    //case "sue":
//    case "bart" or "sue":
//        Console.WriteLine("hello professor");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom.");
//        break;
//    default:
//        Console.WriteLine("Who are you?");
//        break;
//}

