namespace Deck.Tests
{
    using NUnit.Framework;
    using Santase.Logic.Cards;
    using Santase.Logic;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void Deck_TestCreateInstance_ShouldBeNotNull()
        {
            var deck = new Deck();

            Assert.NotNull(deck);
        }

        [Test]
        public void Deck_NewDeckCardsCount_ShouldBe24()
        {
            var deck = new Deck();

            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
        public void Deck_TestShuffle_ShouldBeDifferentObjects()
        {
            var deckOne = new Deck();
            var deckTwo = new Deck();
            
            Assert.AreNotEqual(deckOne, deckTwo);
        }

        [Test]
        public void Deck_TrumpCardIsSet_ShouldBeNotNull()
        {
            var deck = new Deck();
            
            Assert.NotNull(deck.TrumpCard);
        }

        [Test]
        public void GetNextCard_ResizeDeck_ShouldDecreaseCount()
        {
            var deck = new Deck();

            deck.GetNextCard();

            Assert.AreEqual(23, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_WhenDeckIsEmpty_ShouldThrows()
        {
            var deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws(typeof(InternalGameException), () => deck.GetNextCard());
        }

        [TestCase(CardType.King, CardSuit.Diamond)]
        [TestCase(CardType.Ace, CardSuit.Heart)]
        [TestCase(CardType.Ten, CardSuit.Club)]
        [TestCase(CardType.Jack, CardSuit.Spade)]
        [TestCase(CardType.Queen, CardSuit.Diamond)]
        public void ChangeTrumpCard_CorrectData_ShouldChange(CardType type, CardSuit suit)
        {
            var deck = new Deck();
            var card = new Card(suit, type);

            deck.ChangeTrumpCard(card);

            Assert.AreEqual(card, deck.TrumpCard);
        }
    }
}
