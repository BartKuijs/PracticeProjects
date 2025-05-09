using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameProject;

public static class GetData
{
    public static string GetStringFromUser(string message)
    {
        Console.Write(message);
        string output = Console.ReadLine();
        return output;
    }

    
}
