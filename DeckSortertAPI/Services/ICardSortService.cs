using System.Collections.Generic;

namespace DeckSortertAPI.Services
{
    public interface ICardSortService
    {
        IEnumerable<string> SortCards(IEnumerable<string> cards);
    }
}
