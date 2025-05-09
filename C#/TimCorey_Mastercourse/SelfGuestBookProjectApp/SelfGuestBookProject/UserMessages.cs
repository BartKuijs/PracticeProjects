using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformationHandler;

namespace SelfGuestBookProject;


public class UserMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the party. \nThe host would like to ask you to fill in this guestbook.");
    }

    public static void EndMessage(List<UserData> guests)
    {
        int ageAverage = 0;
        foreach (UserData guest in guests)
        {
            ageAverage += guest.UserAge;
            Console.WriteLine(guest.FirstName + " " + guest.LastName);
            Console.WriteLine(guest.UserAge);
            Console.WriteLine(guest.MessageToHost);

        }
        Console.WriteLine($"The average age of the guests is: {ageAverage / guests.Count}");
    }

}
