
Console.Write("Please enter your age: ");
string? input = Console.ReadLine();

Console.WriteLine();

int age = int.Parse(input);

int ageIn25Years = age + 25;
int age25YearsAgo = age - 25;

Console.WriteLine($"You would be {ageIn25Years} years old in 25 years.");
Console.WriteLine($"You were {age25YearsAgo} years old 25 years ago.");

