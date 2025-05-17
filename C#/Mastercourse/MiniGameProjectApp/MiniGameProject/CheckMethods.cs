using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameProject;

public static class CheckMethods
{
    public static string WhichTypeOfSpells(string typeFire, string typeWater)
    {
        bool typeOfSpellCheck = false;
        string output = "";
        do
        {
            output = GetData.GetStringFromUser($"Would you like to use: {typeFire} or {typeWater} spells? type {typeFire}/{typeWater} ");
            if (output.ToLower() == typeFire || output.ToLower() == typeWater)
            {
                typeOfSpellCheck |= true;
                
            }
            else
            {
                Console.WriteLine($"This was not a valid option. Please enter {typeFire} or {typeWater}. ");
            }

        } while (typeOfSpellCheck == false);

        return output;
    }
}
