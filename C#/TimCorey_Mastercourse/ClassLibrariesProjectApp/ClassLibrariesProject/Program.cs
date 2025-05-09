

using HomeworkClassLibrary;

PersonModel person = new PersonModel();

Console.Write("What is your first name? ");
person.FirstName = Console.ReadLine();

Console.Write("What is your last name? ");
person.LastName = Console.ReadLine();


Console.WriteLine($"Hello {person.FirstName} {person.LastName}");