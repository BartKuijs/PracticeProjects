﻿

using CoreLibrary;






Generators generators = new Generators();

PersonModel person = new PersonModel 
{
    Prefix = "Mr.",
    FirstName = "Tim",
    LastName = "Corey"
};

string message = generators.WelcomeMessage(person.Prefix, person.LastName);

Console.WriteLine(message);

