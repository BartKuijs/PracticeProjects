using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesLibrary;

public abstract class AbstractDeckMethod
{
    // CardDeck
    internal List<PlayingCard> baseDeck = new List<PlayingCard>();
    // ShuffledDeck
    internal List<PlayingCard> shuffledDeck = new List<PlayingCard>();
    // Discard Pile
    internal List<PlayingCard> discardPile = new List<PlayingCard>();

    internal void CreateDeck()
    {
        for(int type = 0; type < 4;  type++)
        {
            for(int val = 0; val < 13; val++)
            {
                baseDeck.Add(new PlayingCard() { TypeOfCard = (CardType)type, Value = (CardValue)val });
            }
        }
    }

    public void ShuffleDeck()
    {
        var rnd = new Random();
        shuffledDeck = baseDeck.OrderBy(x => rnd.Next()).ToList();

        
    }

    public PlayingCard DrawCard()
    {
        PlayingCard output = shuffledDeck.Take(1).First();
        shuffledDeck.Remove(output);
        return output;
    }

    internal List<PlayingCard> DealHand(int numberOfCards)
    {
        List<PlayingCard> output = new List<PlayingCard>();
        for(int i = 0; i < numberOfCards; i++)
        {
            output.Add(DrawCard());
        }
        return output;
    }

    public void DiscardCard(List<PlayingCard> playersHand)
    {
        PlayingCard output = playersHand.Take(1).First();
        playersHand.Remove(output);
        discardPile.Add(output);
    }

    









   
}
