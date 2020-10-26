using System;
using System.Linq;

namespace CardSorter
{
    class DealCards : Deck
    {
        private Card[] playerHand;
        private Card[] sortedHand;

        public DealCards()
        {
            playerHand = new Card[5];
            sortedHand = new Card[5];
        }

        public void Deal()
        {
            seedDeck();
            getHand();
            sortCards();
            displayCards();
        }

        public void getHand()
        {
            //deal a standard 5 cards 
            for (int i = 0; i < 5; i++)
                playerHand[i] = GetCards[i];
        }

        public void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.HValue
                              select hand;

            var index = 0;
            foreach (var element in queryPlayer.ToList())
            {
                sortedHand[index] = element;
                index++;
            }
        }

        public void displayCards()
        {
            Console.Clear();
            int x = 0;
            int y = 1;

            //display hand
            Console.WriteLine("Your Hand");
            for (int i = 0; i < 5; i++)
            {
                Draw.DrawCardOutline(x, y);
                Draw.DrawCardSuitValue(sortedHand[i], x, y);
                x++;//move to the right
            }
        }

    }
}
