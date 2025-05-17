using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookMiniProject;

public static class GuestBookMethods
{
   
    public static void WelcomeToGuestBook()
    {
        Console.WriteLine("Welcome to our celebration.");
        Console.WriteLine("Please add your name to our guest book.");
        Console.WriteLine("----------------------------------------");
    }

    public static string GetPartyName()
    {
        Console.Write("Please enter your party/group name: ");
        string output = Console.ReadLine();
        return output;
    }
    
    public static int GetPartySize()
    {
        bool isValidNumber;
        int output;
        do
        {
            Console.Write("How many people are in your party/group? ");
            isValidNumber = int.TryParse(Console.ReadLine(), out output);
            if (!isValidNumber)
            {
                Console.WriteLine("That was not a valid number.");
            }
        } while (isValidNumber == false);

        return output;
    }

    public static bool AskToContinue()
    {
        string continueLooping;
        Console.Write("Are there more guests coming? yes/no ");
        continueLooping = Console.ReadLine();
        Console.WriteLine();

        bool output = (continueLooping.StartsWith('Y') || continueLooping.StartsWith('y'));

        return output;
    }

    public static (List<string>, int) GetAllGuests()
    {
        List<string> GuestNames = new List<string>();
        int totalGuests = 0;

        do
        {
            GuestNames.Add(GetPartyName());

            totalGuests += GetPartySize();

        } while (AskToContinue());

        return (GuestNames, totalGuests);

    }

    public static void EndOfPartyResult(List<string> names, int totalAmountOfPeople)
    {
        Console.WriteLine("The names of the parties are:");
        foreach (string name in names)
        {
            Console.WriteLine($"-{name}");
        }
        Console.WriteLine();
        Console.WriteLine($"The total guest count that was at this party was: {totalAmountOfPeople}.");
    }

}
