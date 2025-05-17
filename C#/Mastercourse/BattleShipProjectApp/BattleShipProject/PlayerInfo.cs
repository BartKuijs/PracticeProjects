using BattleShipLiteLibrary;
using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipProject;

public class PlayerInfo
{
    public static PlayerInfoModel CreatePlayer(string playerTitle)
    {
        PlayerInfoModel output = new PlayerInfoModel();

        Console.WriteLine($"Player information for {playerTitle}");
        output.PlayersName = PlayerName();
        if (output.PlayersName != "")
        {
            output.PlayersName = output.PlayersName;
        }
        else
        {
            output.PlayersName = playerTitle;
        }
        // Load up shot grid
        GameLogic.InitializeGrid(output);

        // ask the user for their 5 ship placements
        PlaceShips(output);
        // Clear
        Console.Clear();

        return output;
    }

    public static string PlayerName()
    {
        Console.Write("What is your name? ");
        string output = Console.ReadLine();
        return output;
    }

    public static void PlaceShips(PlayerInfoModel model)
    {
        do
        {
            Console.Write($"Where do you want to place ship number {model.ShipLocations.Count+1}: ");
            string location = Console.ReadLine();

            bool isValidLocation = GameLogic.PlaceShip(model, location);

            if(isValidLocation == false)
            {
                Console.WriteLine("That was not a valid location. Please try again. ");
            }

        }
        while(model.ShipLocations.Count < 5);
    }

    public static void DisplayShotGrid(PlayerInfoModel activePlayer)
    {
        string currentRow = activePlayer.ShotGrid[0].SpotLetter;

        foreach(var gridSpot in activePlayer.ShotGrid)
        {
            if(gridSpot.SpotLetter != currentRow)
            {
                Console.WriteLine();
                currentRow = gridSpot.SpotLetter;
            }
            
            if(gridSpot.SpotStatus == GridSpotStatus.Empty)
            {
                Console.Write($"  {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
            }
            else if (gridSpot.SpotStatus == GridSpotStatus.Hit || gridSpot.SpotStatus == GridSpotStatus.Sunk)
            {
                Console.Write("  X  ");
            }
            else if (gridSpot.SpotStatus == GridSpotStatus.Miss)
            {
                Console.Write("  O  ");
            }
            else if (gridSpot.SpotStatus == GridSpotStatus.Ship)
            {
                Console.Write($"  {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
            }
            else
            {
                Console.WriteLine("  ?  ");
            }
            
        }
        Console.WriteLine();
    }

    public static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
    {
        bool isValidShot = false;
        string row = "";
        int column = 0;

        do
        {
            string shot = AskForShot(activePlayer);
            (row, column) = GameLogic.SplitIntoRowAndColumn(shot);
            isValidShot = GameLogic.ValidateShot(activePlayer, row, column);

            if (isValidShot == false)
            {
                Console.WriteLine("Invalid shot location. Please try again.");
            }

        } 
        while(isValidShot == false);

        // Determine shot results
        bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);


        // Record results
        GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

        DisplayShotResults(row, column, isAHit);
    }

    private static void DisplayShotResults(string row, int column, bool isAHit)
    {
        if (isAHit)
        {
            Console.WriteLine($"{row.ToUpper()}{column} is a hit!");
        }
        else
        {
            Console.WriteLine($"{row.ToUpper()}{column} is a miss.");
        }
    }

    private static string AskForShot(PlayerInfoModel activePlayer)
    {
        Console.WriteLine(activePlayer.PlayersName);
        Console.Write("Please enter your shot selection: ");
        string output = Console.ReadLine();
        return output;
    }

    




}
