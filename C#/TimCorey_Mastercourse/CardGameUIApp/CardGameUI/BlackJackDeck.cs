
public class BlackJackDeck : Deck
{
    public BlackJackDeck()
    {
        CreateDeck();
        ShuffleDeck();
    }
    public override List<PlayingCard> DealCards()
    {
        List<PlayingCard> output = new List<PlayingCard>();

        for (int i = 0; i < 2; i++)
        {
            output.Add(DrawOneCard());
        }

        return output;
    }

    public PlayingCard RequestCard()
    {
        return DrawOneCard();
    }
}


