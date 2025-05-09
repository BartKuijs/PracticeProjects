

// Welcome user to app
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This application was built by Bart Kuijs");
Console.WriteLine("----------------------------------------");
Console.WriteLine();

// Ask for first name
Console.Write("What is your first name: ");
var firstName = Console.ReadLine();
Console.WriteLine();

// Greet user
Console.WriteLine($"Hi {firstName}. Have a nice day.");

Console.ReadLine();

