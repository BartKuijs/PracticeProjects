

using System.Data;

double firstNumber = 2.5;
double secondNumber = 5.8;
double thirdNumber = 8.7;

double plus = firstNumber + secondNumber + thirdNumber;
double divide = firstNumber / secondNumber / thirdNumber;
double minus = firstNumber - secondNumber - thirdNumber;
double multiply = firstNumber * secondNumber * thirdNumber;
double remains = thirdNumber % secondNumber % firstNumber;

Console.WriteLine($"If we add 2.5 + 5.8 + 8.7 together it will be: {plus}");
Console.WriteLine();
Console.WriteLine($"If we divide 2.5 / 5.8 / 8.7 together it will be: {divide}");
Console.WriteLine();
Console.WriteLine($"If we substract 2.5 - 5.8 - 8.7 together it will be: {minus}");
Console.WriteLine();
Console.WriteLine($"If we multiply 2.5 * 5.8 * 8.7 together it will be: {multiply}");
Console.WriteLine();
Console.WriteLine("The remainder of 8.7/5.8 = 2.9 and the remainder of 2.9/2.5 is:");
Console.WriteLine(remains);

