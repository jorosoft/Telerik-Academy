namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            var tempHand = new HashSet<string>();
            foreach (var card in hand.Cards)
            {
                tempHand.Add(card.ToString());
            }

            if (tempHand.Count != hand.Cards.Count)
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var largeGroup = hand.Cards
                .GroupBy(c => c.Face)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();
            if (largeGroup.Count() == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (hand.Cards.All(c => c.Suit == CardSuit.Clubs)
                || hand.Cards.All(c => c.Suit == CardSuit.Diamonds)
                || hand.Cards.All(c => c.Suit == CardSuit.Hearts)
                || hand.Cards.All(c => c.Suit == CardSuit.Spades))
            {
                return true;
            }

            return false;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
