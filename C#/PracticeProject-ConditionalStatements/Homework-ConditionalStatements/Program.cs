

// Capture a users's age from the console and then identify how old the will be in 25 years, as well as how old they were 25 years ago. 
// print that information to the console in natural language.
string input = "";

while (input == "")
{
    Console.WriteLine("How old are you?");
    input = Console.ReadLine();

    if (Int32.TryParse(input, out int value))
    {
        int agePast = value - 25;
        int ageFuture = value + 25;
        if (agePast > 0)
        {
            Console.WriteLine($"25 years ago, you were {agePast} years old");
        }
        else
        {
            Console.WriteLine("25 years ago you were not even born yet.");
        }
        if (ageFuture > 100)
        {
            Console.WriteLine("In 25 years, you will have lived a very long time and I hope you will still be alive.");
        }
        else
        {
            Console.WriteLine($"In 25 years, you will be {ageFuture} years old.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number");
        input = "";
    }
}
Console.ReadLine();