

//bool isComplete = false;

//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//}
//else
//{
//    Console.WriteLine("The statement was false.");
//}


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "bart")
{
    Console.WriteLine("Hello Mr. Kuijs.");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}



Console.WriteLine("End of program.");


