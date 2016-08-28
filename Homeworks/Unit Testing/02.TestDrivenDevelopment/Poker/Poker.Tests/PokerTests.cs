namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class PokerTests
    {
        [TestMethod]
        public void CardToString_TestReturnedString_ShouldBeCorrectValue()
        {
            var card = new Card(CardFace.Four, CardSuit.Spades);

            var cardString = card.ToString();

            Assert.AreEqual("Four Spades", cardString);
        }

        [TestMethod]
        public void HandToString_TestReturnedString_ShouldBeCorrectValue()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades)
            };
            var expectedResult = "HAND: Ace of Diamonds, Four of Hearts, Jack of Spades, King of Clubs, Eight of Spades";
            var hand = new Hand(cards);

            var handString = hand.ToString();

            Assert.AreEqual(expectedResult, handString);
        }

        [TestMethod]
        public void PokerHandsCheckerIsValidHand_GivenValidHand_ShouldReturnTrue()
        {
            var pokerChecker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            var expectedResult = pokerChecker.IsValidHand(hand);

            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        public void PokerHandsCheckerIsValidHand_GivenInvalidHand_ShouldReturnFalse()
        {
            var pokerChecker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            var expectedResult = pokerChecker.IsValidHand(hand);

            Assert.IsFalse(expectedResult);
        }

        [TestMethod]
        public void PokerHandsCheckerIsFlush_GivenFlushHand_ShouldReturnTrue()
        {
            var pokerChecker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            var expectedResult = pokerChecker.IsFlush(hand);

            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        public void PokerHandsCheckerIsFlush_GivenNotFlushHand_ShouldReturnFalse()
        {
            var pokerChecker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            var expectedResult = pokerChecker.IsFlush(hand);

            Assert.IsFalse(expectedResult);
        }

        [TestMethod]
        public void PokerHandsCheckerIsFourOfAKind_GivenFourOfAKind_ShouldReturnTrue()
        {
            var pokerChecker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            var expectedResult = pokerChecker.IsFourOfAKind(hand);

            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        public void PokerHandsCheckerIsFourOfAKind_GivenNotFourOfAKind_ShouldReturnFalse()
        {
            var pokerChecker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            var expectedResult = pokerChecker.IsFourOfAKind(hand);

            Assert.IsFalse(expectedResult);
        }
    }
}
