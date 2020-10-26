using System;

namespace CardSorter
{
    //This class is inheriting from the Card.cs class to create a deck of cards
    class Deck : Card
    {
        const int NUM_CARDS = 52;  //this is the total number of cards in a deck
        private Card[] deck;  //array of cards

        public Deck()
        {
            deck = new Card[NUM_CARDS];
        }

        public Card[] GetCards { get { return deck; } }  //returns the current deck of cards

        //seed the deck of cards

        public void seedDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { HSuit = s, HValue = v };
                }
            }

            Shuffle();
        }

        //shuffle to get randomized hands
        public void Shuffle()
        {
            Random rand = new Random();
            Card card;

            //shuffle 10x...should be good enough
            for (int shuffleCount = 0; shuffleCount < 10; shuffleCount++)
            {
                for (int i = 0; i < NUM_CARDS; i++)
                {
                    //shuffle cards
                    int CardIdx = rand.Next(13);
                    card = deck[i];
                    deck[i] = deck[CardIdx];
                    deck[CardIdx] = card;
                }
            }
        }
    }
}
