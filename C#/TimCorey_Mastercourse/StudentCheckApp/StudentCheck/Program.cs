

//Console.Write("What is your first name? ");
//string firstName = Console.ReadLine();
//Console.Write("What is your age in years? ");
//int age = int.Parse(Console.ReadLine());

//int waitYears = 21 - age;

//if (age < 21)
//{
//    Console.WriteLine($"To start this class I recommend that you should wait {waitYears} year(s), {firstName}.");
//}
//else if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
//{
//    Console.WriteLine($"Welcome to class Professor {firstName}");
//}
//else
//{
//    Console.WriteLine($"Welcome to class {firstName}");
//}

Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

Console.Write("What is your age in years? ");
string ageText = Console.ReadLine();

string formattedName;

if (int.TryParse(ageText, out int age) == false)
{
    Console.WriteLine("You did not provide a valid age.");
    return;
}
if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}


if (age < 21)
{
    Console.WriteLine($"To start this class I recommend you wait {21 - age} year(s), {formattedName}.");
}
else
{
    Console.WriteLine($"Welcome to class {formattedName}");
}

//if (int.TryParse(ageText, out int age))
//{


//    if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
//    {
//        formattedName = $"Professor {firstName}";
//    }
//    else
//    {
//        formattedName = firstName;
//    }


//    if (age < 21)
//    {
//        Console.WriteLine($"To start this class I recommend you wait {21 - age} year(s), {formattedName}.");
//    }
//    else
//    {
//        Console.WriteLine($"Welcome to class {formattedName}");
//    }
//}
//else
//{
//    Console.WriteLine("You did not provide a valid age.");
//}


