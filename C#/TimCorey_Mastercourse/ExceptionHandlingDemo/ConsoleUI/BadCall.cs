using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class BadCall
    {
        public static void BadCalls()
        {
            int[] ages = new int[] { 1, 3, 5 };

for(int i = 0; i <= ages.Length; i++)
{
    try
    {
        Console.WriteLine(ages[i]);
    }
    catch (Exception ex)
    {

        Console.WriteLine("We had an error");
        Console.WriteLine(ex);
        throw;
    }
    
}
        }
    }
}
