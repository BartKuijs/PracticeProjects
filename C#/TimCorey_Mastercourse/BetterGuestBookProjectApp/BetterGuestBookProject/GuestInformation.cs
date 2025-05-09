using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGuestBookProject;

public class GuestInformation
{
    public static List<GuestModel> GetGuestInformation()
    {
        string moreGuestsComing = "";
        List<GuestModel> guests = new List<GuestModel>();
        do
        {
            GuestModel guest = new GuestModel();

            guest.FirstName = GetInformationFromConsole.GetInformation("What is your first name? ");
            guest.LastName = GetInformationFromConsole.GetInformation("What is your last name? ");
            guest.MessageToHost = GetInformationFromConsole.GetInformation("What message would you like to tell your host? ");
            moreGuestsComing = GetInformationFromConsole.GetInformation("Are more guests coming? yes/no ");
            
            guests.Add(guest);

            Console.Clear();

        } while (moreGuestsComing.ToLower() == "yes" || moreGuestsComing.StartsWith('y') || moreGuestsComing.StartsWith('Y'));

        return guests;
    }

    public static void PrintGuestInformation(List<GuestModel> guests)
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);
        }
    }
}
