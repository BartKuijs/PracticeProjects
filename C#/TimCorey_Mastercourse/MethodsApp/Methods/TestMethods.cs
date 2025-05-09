using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

public static class TestMethods
{/// <summary>
/// Method that asks user for input to add things to a list.
/// Returns a list.
/// </summary>
/// <param name="value">The key of items that you want to put in a list.</param>
/// <returns></returns>
    public static List<string> AddStringList(string value)
    {
        List<string> list = new List<string>();
        bool isValid = true;
        do
        {
            Console.Write($"Please input {value}: ");
            string input = Console.ReadLine();

            if (input != "")
            {
                list.Add(input);
            }
            else
            {
                isValid = false;
            }

        } while (isValid);
        return list;
    }
}
