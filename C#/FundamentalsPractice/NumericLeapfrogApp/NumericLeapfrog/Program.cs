int randomNumber = Random.Shared.Next(5,100);
int guessedNumber = 0;
bool gameOver = false;
int count = 0;
Console.WriteLine("Numeric Leapfrog - A number guessing game");
Console.WriteLine("Hello player, please pick a number between 5 and 100.");
Console.WriteLine("The goal is to guess within 3 of the number without going over the random number.");
Console.WriteLine("Each new guess will be added to the previous number.");
Console.WriteLine();
do
{
    Console.Write("Please enter a number: ");
    string numberText = Console.ReadLine();

    if (int.TryParse(numberText, out int number))
    {
        count++;
        guessedNumber += number;
        if (guessedNumber < randomNumber - 3)
        {
            Console.WriteLine(
                $"""
                Your guessed number is: {guessedNumber} and it is to low to win the game.
                Please put in your next guess which will be added to your previous guessed number.
                You have guessed {count} {(count == 1 ? "time" : "times")}.
                """);
            Console.WriteLine();
        }
        else if (guessedNumber > randomNumber)
        {
            Console.WriteLine($"You guessed {guessedNumber} and it was higher then {randomNumber}. So you lost!");
            Console.WriteLine($"You have guessed {count} {(count == 1 ? "time" : "times")}");
            gameOver = true;
        }
        else
        {
            Console.WriteLine($"You won the game!! the random number was: {randomNumber}");
            Console.WriteLine($"You have guessed {count} {(count == 1 ? "time" : "times")}");
            gameOver = true;
        }
    }
    else
    {
        Console.WriteLine("This is not a whole number. please try again.");
        Console.WriteLine();
    }
}while(gameOver == false);
Console.ReadLine();
