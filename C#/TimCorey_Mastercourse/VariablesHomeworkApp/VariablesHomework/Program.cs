
// a name is a string
string name;
Console.Write("What is your name? ");
name = Console.ReadLine();

// if the person is alive, we will ask for their age.
bool living;
string answer;
Console.Write("Are you alive? y/n ");
answer = Console.ReadLine();
if (answer != null && answer[0] == 'y' || answer[0] == 'Y')
{
    living = true;
}
else
{ living = false; }

// an age is an int because each year we have to add 1
int age;
Console.Write("What is your age in years? ");
age = Convert.ToInt32(Console.ReadLine());

// a phone number is a string because it can have the '+', '(' and ')' symbols
// also we won't need to use the number to add/substract/divide/multipy.
string phoneNumber;
Console.Write("What is your phone number? ");
phoneNumber = Console.ReadLine();

Console.WriteLine($"Your name is {name}. \n" +
    $"The statement: You are alive = {living}. \n" +
    $"Your phone number is: {phoneNumber}");
if (living == true)
{
    Console.WriteLine($"Your age is: {age}");
}

