
bool exit = false;

do
{
    Console.Write("What is your name? Type (exit) to exit the program. ");
    string? userInput = Console.ReadLine();

  
    if (userInput.ToLower() == "exit")
    {
        exit = true;
        return;
    }
    else if (userInput.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Professor {userInput}.");
    }
    else
    {
        Console.WriteLine($"Welcome student {userInput}");
    }
}while (exit == false);



