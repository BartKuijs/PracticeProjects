



public abstract class Deck
{

    protected List<PlayingCard> fullDeck = new List<PlayingCard>();
    protected List<PlayingCard> drawPile = new List<PlayingCard>();
    protected List<PlayingCard> discardPile = new List<PlayingCard>();
    protected void CreateDeck()
    {
        fullDeck.Clear();

        for (int suit = 0; suit <= 4; suit++)
        {
            for (int val = 0; val <= 13; val++)
            {
                fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)val });
            }
        }
    }

    public virtual void ShuffleDeck()
    {
       var rand = new Random();
       drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
    }

    public abstract List<PlayingCard> DealCards();

    protected virtual PlayingCard DrawOneCard()
    {
        PlayingCard output = drawPile.Take(1).First();
        drawPile.Remove(output);
        return output;
    }

    // Discard / return cards...

    public List<PlayingCard> RequestCards(List<PlayingCard> cardsToDiscard)
    {
        List<PlayingCard> output = new List<PlayingCard>();
        foreach(var card in cardsToDiscard)
        {
            output.Add(DrawOneCard());
            discardPile.Add(card);
        }

        return output;
    }
}


