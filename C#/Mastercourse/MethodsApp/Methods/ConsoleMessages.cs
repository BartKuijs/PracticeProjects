using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Methods;

public static class ConsoleMessages
{/// <summary>
/// Greets the user.
/// </summary>
/// <param name="name">Enter name of the user.</param>
    public static void SayHi(string firstName)
    {
        Console.WriteLine($"Hello {firstName}!");
        Console.WriteLine("I hope you are having a nice day.");
    }

    public static void SayGoodbye(string firstName)
    {
        Console.WriteLine($"Goodbye {firstName}.");
        Console.WriteLine("Say something nice...");
    }

    public static string GetUsersName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Tuple
    public static (string firstName, string lastName) GetFullName()
    {
        Console.Write("What is your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();

        return (firstName, lastName);
    }
}
