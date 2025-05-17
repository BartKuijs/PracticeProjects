

/*
Console.Write("What year is it? ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("What is your age? ");
int age = Convert.ToInt32(Console.ReadLine());

int birthYear = year - age;

Console.WriteLine($"Your birthyear is probably {birthYear}.");

 */

Console.Write("What year is it? ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("What is your birthyear? ");
int birthYear = Convert.ToInt32(Console.ReadLine());

int age = year - birthYear;

Console.WriteLine($"Your age is probably {age}.");

