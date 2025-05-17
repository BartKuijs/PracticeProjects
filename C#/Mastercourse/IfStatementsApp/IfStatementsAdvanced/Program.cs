
Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

Console.Write("What is your last name? ");
string lastName = Console.ReadLine();


if (firstName.ToLower() == "bart" &&
    lastName.ToLower() == "kuijs")
{
    Console.WriteLine("Hello Professor Kuijs");
}
else if (firstName.ToLower() == "bart" ||
         lastName.ToLower() == "kuijs")
{
    Console.WriteLine("Hello student.");
}
else
{
    Console.WriteLine("You do not have a great name.");
}

//if (firstName.ToLower() == "bart" && 
//    lastName.ToLower() == "kuijs")
//{
//    Console.WriteLine("Hello Mr. Kuijs");
//}
//else if (firstName.ToLower() == "bart")
//{
//    Console.WriteLine($"Hello Bart {lastName}");
//}
//else if (lastName.ToLower() == "kuijs")
//{
//    Console.WriteLine($"Hello {firstName} Kuijs");
//}
//else
//{
//    Console.WriteLine($"There are better names.");
//}


//if (firstName.ToLower() == "bart")
//{
//    Console.WriteLine("You have a cool first name.");
//}
//if (lastName.ToLower() == "kuijs")
//{
//    Console.WriteLine("You have a great last name");
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cool.");
//}

int age = 45;

// ==, >, >=, <, <=, !=

if (age != 45)
{
    Console.WriteLine("Sorry you aren't at a great age.");
}
else if ((age >= 40) && (age < 50))
{
    Console.WriteLine("You are in your 40's");
}

