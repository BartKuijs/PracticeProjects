
using BattleShipLiteLibrary;
using BattleShipLiteLibrary.Models;
using BattleShipProject;
using System.Numerics;
using System.Threading;

UserMessages.WelcomeMessage();


PlayerInfoModel activePlayer = PlayerInfo.CreatePlayer("Player 1");
PlayerInfoModel opponent = PlayerInfo.CreatePlayer("Player 2");

PlayerInfoModel winner = null;

do
{
    PlayerInfo.DisplayShotGrid(activePlayer);
    PlayerInfo.RecordPlayerShot(activePlayer, opponent);

    
    bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

    
    if (doesGameContinue)
    {
        // - Swap using a temp variable - 
        // PlayerInfoModel tempHolder = opponent;
        // opponent = activePlayer;
        // activePlayer = tempHolder;

        // Use Tuple to swap positions
        (activePlayer, opponent) = (opponent, activePlayer);
    }
    else
    {
        winner = activePlayer;
    }
    Thread.Sleep(1000);
    Console.Clear();
}
while(winner == null);

UserMessages.IdentifyWinner(winner);
int shotCount = GameLogic.GetShotCount(winner);
UserMessages.ShotCountMessage(shotCount);
