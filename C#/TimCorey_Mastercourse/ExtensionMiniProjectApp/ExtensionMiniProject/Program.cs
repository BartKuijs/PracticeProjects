

using System.Runtime.CompilerServices;

PersonModel person = new PersonModel();

person.FirstName  = "What is your first name? ".RequestString();

person.LastName = "What is your last name? ".RequestString();

person.Age = "What is your age? ".RequestInt(0,120);

person.NumberOfChildren = "How many children do you have? ".RequestInt();


Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old and has {person.NumberOfChildren} kids.");

