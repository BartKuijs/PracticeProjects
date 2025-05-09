using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BattleShipLiteLibrary;

public static class GameLogic
{
    public static int GetShotCount(PlayerInfoModel player)
    {
        int shotCount = 0;

        foreach(var shot in player.ShotGrid)
        {
            if(shot.SpotStatus != GridSpotStatus.Empty)
            {
                shotCount++;
            }
        }
        return shotCount;
    }

    public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
    {
        bool isAHit = false;
        foreach (var ship in opponent.ShipLocations)
        {
            if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
            {
                isAHit = true;
                ship.SpotStatus = GridSpotStatus.Sunk;
            }
        }
        return isAHit;

    }

    public static void InitializeGrid(PlayerInfoModel model)
    {
        List<string> letters = new List<string>
        {
            "A",
            "B",
            "C",
            "D",
            "E",
        };

        List<int> numbers = new List<int>
        {
            1,
            2,
            3,
            4,
            5
        };

        foreach (string letter in letters)
        {
            foreach (int number in numbers)
            {
                AddGridSpot(model, letter, number);
            }
        }

    }

    public static void MarkShotResult(PlayerInfoModel player, string row, int column, bool isAHit)
    {

        foreach (var gridSpot in player.ShotGrid)
        {
            if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
            {
                if (isAHit)
                {
                    gridSpot.SpotStatus = GridSpotStatus.Hit;

                }
                else
                {
                    gridSpot.SpotStatus = GridSpotStatus.Miss;
                }
            }
        }
    }

    public static bool PlaceShip(PlayerInfoModel model, string location)
    {
        bool output = false;
        (string row, int column) = SplitIntoRowAndColumn(location);

        bool isValidLocation = ValidateGridLocation(model, row, column);
        bool isShipSpotOpen = ValidateShipLocation(model, row, column);

        if (isValidLocation && isShipSpotOpen)
        {

            model.ShipLocations.Add(new GridSpotModel
            {
                SpotLetter = row.ToUpper(),
                SpotNumber = column,
                SpotStatus = GridSpotStatus.Ship
            });
            output = true;
        }
        return output;
    }

    private static bool ValidateShipLocation(PlayerInfoModel model, string row, int column)
    {
        bool isValidLocation = true;
        foreach(var ship in model.ShipLocations)
        {
            if(ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
            {
                isValidLocation = false;
            }
        }
        return isValidLocation;
    }

    private static bool ValidateGridLocation(PlayerInfoModel model, string row, int column)
    {
        bool isValidLocation = false;
        foreach(var ship in model.ShotGrid)
        {
            if(ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
            {
                isValidLocation = true;
            }
        }
        return isValidLocation;
    }

    public static bool PlayerStillActive(PlayerInfoModel player)
    {
        bool isActive = false;

        foreach(var ship in player.ShipLocations)
        {
            if(ship.SpotStatus != GridSpotStatus.Sunk)
            {
                isActive = true;
            }
        }
        
        return isActive;

    }

    public static (string row, int column) SplitIntoRowAndColumn(string shot)
    {
        string row = "";
        int column = 0;
        if (shot.Length != 2)
        {
            row = "";
            column = 0;
            
        }
        else 
        {
            //(row, column) = (Convert.ToString(shot[0]), int.Parse(shot[1].ToString()));
            row = shot[0].ToString();
            string columnText = Convert.ToString(shot[1]);
            int.TryParse(columnText, out column);
            //column = int.Parse(shotArray[1].ToString());
        }
        
        return (row, column);

    }

    public static bool ValidateShot(PlayerInfoModel player, string row, int column)
    {
        bool isValidShot = false;
        foreach (var gridSpot in player.ShotGrid)
        {
            if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
            {
                if(gridSpot.SpotStatus == GridSpotStatus.Empty)
                {
                    isValidShot = true;
                }
            }
        }
        return isValidShot;
        
    }

    private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
    {
        GridSpotModel spot = new GridSpotModel
        {
            SpotLetter = letter,
            SpotNumber = number,
            SpotStatus = GridSpotStatus.Empty
        };

        model.ShotGrid.Add(spot);
    }


}
