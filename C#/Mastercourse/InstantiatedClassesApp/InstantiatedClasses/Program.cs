

using InstantiatedClasses;
using System.Threading.Channels;

// PersonModel person = new PersonModel();

//List<PersonModel> people = new List<PersonModel>();

//PersonModel person = new PersonModel();

//person.firstName = "Tim";
//person.lastName = "Corey";

//people.Add(person);

//person = new PersonModel();

//person.firstName = "Sue";
//person.lastName = "Smith";

//people.Add(person);

//foreach (PersonModel p in people)
//{
//    Console.WriteLine(p.firstName +" "+ p.lastName);
//}

List<PersonModel> people = new List<PersonModel>();
string firstName = "";

do
{
    Console.Write("What is your first name (or type exit to stop): ");
    firstName = Console.ReadLine();
    Console.Write("What is your last name (or type exit to stop): ");
    string lastName = Console.ReadLine();

    if (firstName.ToLower() != "exit")
    {
        PersonModel person = new PersonModel();
        person.FirstName = firstName;
        person.LastName = lastName;
        people.Add(person);
    }

} while (firstName.ToLower() != "exit");

foreach(PersonModel person in people)
{
    ProcessPerson.GreetPerson(person);
}


