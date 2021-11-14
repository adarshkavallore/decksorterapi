using DeckSortertAPI.Models;
using System.Collections.Generic;

namespace DeckSortertAPI.Services
{
    public class CardComparer : IComparer<Card>
    {
        /// <summary>
        /// Compare two cards by  suits then by rank
        /// </summary>
        /// <param name="firstCard"></param>
        /// <param name="secondCard"></param>
        /// <returns></returns>
        public int Compare(Card firstCard, Card secondCard)
        {
            if (firstCard.Suit ==secondCard.Suit&&firstCard.Rank==secondCard.Rank)
            {
                return 0;
            }
            if (firstCard.Suit > secondCard.Suit)
            {
                return 1;
            }
            if (firstCard.Suit < secondCard.Suit)
            {
                return -1;
            }
            return firstCard.Rank > secondCard.Rank ? 1 : -1;


        }
    }
}
