using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesLibrary;

public class PokerDeck : AbstractDeckMethod
{
    public PokerDeck()
    {
        CreateDeck();
        ShuffleDeck();
    }

    public List<PlayingCard> DealPokerHand()
    {
        List<PlayingCard> output = new List<PlayingCard>();
        output = DealHand(5);

        return output;
    }
   
}

