

using PropertyTypes;

PersonModel person = new PersonModel();

person.FirstName = "Tim";
person.Password = "Corey";
person.Age = 30;
person.SSN = "123-45-6789";

Console.WriteLine(person.SSN);
Console.WriteLine(person.FullName);

HomeworkProperties address = new HomeworkProperties();

address.StreetAddress = "De donge 27";
address.City = "Drunen";
address.Country = "Netherlands";
address.PostalCode = "5152RL";

Console.WriteLine(address.FullAddress);