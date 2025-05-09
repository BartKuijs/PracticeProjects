

using System;

string[] names = new string[3];
names[0] = "Bart";
names[1] = "Bob";
names[2] = "Sue";
int number = 4;
bool isValid = true;

do
{
    Console.Write($"Please select number 1/2/3. ");
    string numberText = Console.ReadLine();
    if (numberText == "" )
    {
      
    }
    else
    {
        int.TryParse(numberText, out number);
    }

    
    if ( number == 1 || number == 2 || number == 3)
    {
        Console.WriteLine($"You selected the name: {names[number-1]}.");
        isValid = false;
    }
    else
    {
        Console.WriteLine("Please enter a valid number. ");
    }

}
while (isValid);
