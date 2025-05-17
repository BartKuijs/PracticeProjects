using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InstantiatedClasses;

public static class ProcessPerson
{
    public static void GreetPerson(PersonModel person)
    {
        Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
        person.HasBeenGreeted = true;
    }
}
