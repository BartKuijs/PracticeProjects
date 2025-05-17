using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework;

public class WelcomeMethods
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to the program.");
    }

    public static string GetUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    public static void HelloName(string name)
    {
        Console.WriteLine($"Hello {name}.");
    }
}
