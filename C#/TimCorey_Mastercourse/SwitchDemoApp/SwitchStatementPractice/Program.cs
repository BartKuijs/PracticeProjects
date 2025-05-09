
Console.Write("What is your name? ");
string? firstName = Console.ReadLine();
Console.Write("What is your age? ");
int age = Convert.ToInt32(Console.ReadLine());

switch (firstName.ToLower(), age)
{
    case ("bart", 33):
            Console.WriteLine("Hi Bart of age 33.");
        break;
    case ("bart", < 20):
        Console.WriteLine("Hi Bart of age below 20.");
        break;
        case ("asd", < 20):
        Console.WriteLine("You are someone with the age below 20.");
        break;
    default:
        Console.WriteLine("Something is wrong.");
        break;
}

