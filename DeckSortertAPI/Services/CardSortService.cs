using DeckSortertAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckSortertAPI.Services
{
    public class SortService : ICardSortService
    {
        private ICardHandler _cardHandler;
        IComparer<Card> _cardComparer;
        public SortService(ICardHandler cardHandler, IComparer<Card> cardComparer)
        {
            _cardHandler = cardHandler;
            _cardComparer = cardComparer;
        }
        /// <summary>
        /// Sort cards by suit then by rank
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public IEnumerable<string> SortCards(IEnumerable<string> cards)
        {
            var cardObjects = new List<Card>();
            foreach (var card in cards)
            {
                if (card.Length != 2 && card.Length != 3)
                {
                    throw new ArgumentException($"invalid card format :-{card}");
                }
                var cardObject = new Card
                {

                    Rank = _cardHandler.ExtractCardRank(card),
                    Suit = _cardHandler.ExtractCardSuite(card)
                };
                cardObjects.Add(cardObject);
            }
            var sortedCards = Sort(cardObjects);
            return sortedCards;
        }

        private IEnumerable<string> Sort(List<Card> cards)
        {
            cards.Sort(_cardComparer);

            return cards.Select(x => $"{_cardHandler.ConvertRankEnumToString(x.Rank)}{_cardHandler.ConvertSuitEnumToString(x.Suit)}").ToList();
        }
    }
}
