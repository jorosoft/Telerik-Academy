using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var result = "HAND: ";
            
            foreach (var card in this.Cards)
            {
                result += card.Face + " of " + card.Suit + ", ";
            }

            return result.Substring(0, result.Length - 2);
        }
    }
}
