using BattleShipLiteLibrary.Models;
using BattleShipLiteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipProject;

public class UserMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to Battleship Lite");
        Console.WriteLine("created by Bart Kuijs");
        Console.WriteLine();
    }

    internal static void IdentifyWinner(PlayerInfoModel winner)
    {
        Console.WriteLine($"Congratulations to {winner.PlayersName} for winning!");
        Console.WriteLine($"{winner.PlayersName} took {GameLogic.GetShotCount(winner)} shots.");
    }

    public static void ShotCountMessage(int shotcount)
    {
        Console.WriteLine($"you needed {shotcount} shots to win");
    }
}
