

int age;
bool isValidAge;

do
{
    Console.Write("What is your age? ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false || age < 0 || age > 130)
    {
        Console.WriteLine("That was an invalid age. ");
    }
} while (!isValidAge || age < 0 || age > 130);

Console.WriteLine($"Your age is {age}");

int x = 0;

while (x <= 5)
{
    Console.WriteLine(x);
    x++;
}


