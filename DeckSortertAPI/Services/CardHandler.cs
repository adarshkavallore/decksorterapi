using DeckSortertAPI.Models;
using System;

namespace DeckSortertAPI.Services
{
    public class CardHandler :ICardHandler
    {
        /// <summary>
        /// Extract Suite Information from Card
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public CardSuit ExtractCardSuite(string card)
        {
            var suit = card.Length == 2 ? card[1] : card[2];
            switch (suit)
            {
                case 'd':
                    return CardSuit.Diamonds;
                case 's':
                    return CardSuit.Spades;
                case 'c':
                    return CardSuit.Clubs;
                case 'h':
                    return CardSuit.Hearts;

                default:
                    throw new ArgumentException($"error: card \'{card}\' is invalid.");
            }
        }
        /// <summary>
        /// Extract Rank Information from Card
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public CardRank ExtractCardRank(string card)
        {
            var rank = card.Length == 2 ? card[0].ToString() : card.Substring(0, 2);
            switch (rank)
            {

                case "2":
                    return CardRank.Two;
                case "3":
                    return CardRank.Three;
                case "4":
                    return CardRank.Four;

                case "5":
                    return CardRank.Five;
                case "6":
                    return CardRank.Six;
                case "7":
                    return CardRank.Seven;
                case "8":
                    return CardRank.Eight;

                case "9":
                    return CardRank.Nine;
                case "10":
                    return CardRank.Ten;
                case "J":
                    return CardRank.Jack;
                case "Q":
                    return CardRank.Queen;
                case "K":
                    return CardRank.King;
                case "A":
                    return CardRank.Ace;

                default:
                    throw new ArgumentException($"error: card \'{card}\' is invalid.");
            }
        }
        /// <summary>
        /// Convert Suite Enum value to string value
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        public string ConvertSuitEnumToString(CardSuit suit)
        {
            switch (suit)
            {
                case CardSuit.Diamonds:
                    return "d";
                case CardSuit.Spades:
                    return "s";
                case CardSuit.Clubs:
                    return "c";
                case CardSuit.Hearts:
                    return "h";
                default:
                    throw new ArgumentException($"invalid card suit :-{suit}");
            }
        }
        /// <summary>
        /// Convert Rank Enum value to string value
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        public string ConvertRankEnumToString(CardRank rank)
        {
            switch (rank)
            {
                case CardRank.Two:
                    return "2";
                case CardRank.Three:
                    return "3";
                case CardRank.Four:
                    return "4";
                case CardRank.Five:
                    return "5";
                case CardRank.Six:
                    return "6";
                case CardRank.Seven:
                    return "7";
                case CardRank.Eight:
                    return "8";
                case CardRank.Nine:
                    return "9";
                case CardRank.Ten:
                    return "10";
                case CardRank.Jack:
                    return "J";
                case CardRank.Queen:
                    return "Q";
                case CardRank.King:
                    return "K";
                case CardRank.Ace:
                    return "A";

                default:
                    throw new ArgumentException($"invalid card rank :-{rank}");
            }
        }

        
    }
}
