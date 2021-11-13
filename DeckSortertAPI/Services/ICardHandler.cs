using DeckSortertAPI.Models;

namespace DeckSortertAPI.Services
{
    public interface ICardHandler
    {
        string ConvertSuitEnumToString(CardSuit suit);
        string ConvertRankEnumToString(CardRank rank);
        CardRank ExtractCardRank(string card);
        CardSuit ExtractCardSuite(string card);
    }
}
