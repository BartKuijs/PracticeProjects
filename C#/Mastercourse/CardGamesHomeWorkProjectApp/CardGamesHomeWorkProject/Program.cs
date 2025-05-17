
using CardGamesLibrary;


PokerDeck pokerDeck = new PokerDeck();

List<PlayingCard> handPlayer1 = pokerDeck.DealPokerHand();


foreach(var card in handPlayer1)
{
    Console.WriteLine($"{card.Value.ToString()} of {card.TypeOfCard.ToString()}");
}
