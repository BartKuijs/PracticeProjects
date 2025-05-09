

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

// int age = int.Parse(ageText);

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

Console.WriteLine(age +15);

float test = 23.5f;

double testDouble = test;
decimal testDecimal = (decimal)testDouble;
int testInt = (int)testDecimal;

Console.WriteLine(testDouble);
Console.WriteLine(testDecimal);
Console.WriteLine(testInt);
