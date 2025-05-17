using Methods;

//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

// DRY - Don't Repeat Yourself
// SOLID - SRP (Single Responsibility Principle), 

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);

//ConsoleMessages.SayGoodbye(name);

//Console.WriteLine(CalculatingMethod.Add(2.2, 5.8));

//var fullName = ConsoleMessages.GetFullName();
// Discard character '_' 
//(string firstName, _) = ConsoleMessages.GetFullName();
(string firstName, string lastName) = ConsoleMessages.GetFullName();

Console.WriteLine($"First name: {firstName}");
Console.WriteLine($"Last name: {lastName}");





//double[] vals = new double[] { 2, 5, 6, 21, 52, 68};
//Console.WriteLine(CalculatingMethod.AddAll(vals));

//int x = 12;
//int y = 13;

//CalculatingMethod.CalculatingMinus(x, y);
//CalculatingMethod.CalculatingPlus(x);
//CalculatingMethod.CalculatingMultiply(x);


//List<string> names = TestMethods.AddStringList("Name");

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}