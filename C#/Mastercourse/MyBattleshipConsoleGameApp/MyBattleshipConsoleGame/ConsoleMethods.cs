using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipMethodsLibrary;

namespace MyBattleshipConsoleGame;

public class ConsoleMethods
{
    public static string GetPlayerName()
    {
        Console.Write("What is your name? ");
        string playerName = Console.ReadLine();

        return playerName;
    }

    public static List<string> GetShipPlacements()
    {
        int i = 5;
        List<GridSpots> list = new List<GridSpots>();
        while (i >= 0)
        {

            Console.Write("At which location would you like to place your ship? ");
            string shipPlacementInput = Console.ReadLine();

            if(shipPlacementInput != GridSpots || ShipPlacements.Contains(shipPlacementInput))
            {
                Console.WriteLine("This is an invalid spot.");
            }
            else
            {
                ShipPlacements.Add(shipPlacementInput);
                i++;
            }

        }
        return ShipPlacements;
    }
}
