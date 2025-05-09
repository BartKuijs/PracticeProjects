using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMethodsLibrary;

public class PlayerInfo
{
    public string PlayerName { get; set; }
    public List<GridSpots> PlayerShipLocations { get; set; }
    public List<GridSpots> PlayerShotLoactions { get; set; }

}
