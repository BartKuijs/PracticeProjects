







public class PokerDeck : Deck
{
    public PokerDeck()
    {
        CreateDeck();
        ShuffleDeck();
    }
    public override List<PlayingCard> DealCards()
    {
        List<PlayingCard> output = new List<PlayingCard>();

        for(int i = 0; i < 5; i++)
        {
            output.Add(DrawOneCard());
        }

        return output;
    }
}


