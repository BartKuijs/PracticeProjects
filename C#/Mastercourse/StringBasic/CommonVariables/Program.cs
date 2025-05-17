

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Bart";
//firstName = "123";
lastName = "Kuijs";

//filePath = "C:\\Temp\\Demo";
filePath = @"C:\Temp\Demo";

//Console.WriteLine(firstName + " " + lastName);

string testString = $@"The file for {firstName} is at C:\SampleFiles";

// string interpolation
Console.WriteLine($"Hello {firstName} {lastName}");

Console.WriteLine(filePath);
Console.WriteLine(testString);

Console.ReadLine();



