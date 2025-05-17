using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGuestBookProject;

public class GetInformationFromConsole
{
    public static string GetInformation(string message)
    {
        string output = "";
        Console.Write(message);
        output = Console.ReadLine();

        return output;
    }
}
