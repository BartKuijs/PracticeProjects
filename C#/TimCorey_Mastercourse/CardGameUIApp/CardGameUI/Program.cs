


BlackJackDeck pokerdeck = new BlackJackDeck();
var playerHand = pokerdeck.DealCards();

foreach (var card in playerHand)
{
    Console.WriteLine($"{card.Value} of {card.Suit}");
}


