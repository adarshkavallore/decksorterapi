namespace DeckSortertAPI.Models
{
    public class Card
    {
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }

    }

    public enum CardRank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
    }
    public enum CardSuit
    {
        Diamonds,
        Spades,
        Clubs,
        Hearts
    }
}
