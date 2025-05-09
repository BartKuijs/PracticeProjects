using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInformationHandler;

namespace SelfGuestBookProject;

public class GetUserInformation
{
    public static List<UserData> GetUserInfo()
    {
        List<UserData> guests = new List<UserData>();
        string AreThereMoreGuests = "";
        do
        {
            UserData g = new UserData();
            Console.Write("Please enter your first name ");
            g.FirstName = Console.ReadLine();
            Console.Write("Please enter your last name ");
            g.LastName = Console.ReadLine();
            Console.Write("Please enter your age ");
            g.UserAgeText = Console.ReadLine();
            Console.Write("Please write a message for the host. ");
            g.MessageToHost = Console.ReadLine();

            int.TryParse(g.UserAgeText, out int age);
            g.UserAge = age;

            guests.Add(g);

            Console.Write("Are there more guest thet need to be added to the guestbook? yes/no ");
            AreThereMoreGuests = Console.ReadLine();
        } while (AreThereMoreGuests.StartsWith('y') || AreThereMoreGuests.StartsWith('Y'));


        return guests;
    }
   
}
