using System;

namespace CardSorter
{
    class Card
    {
        public enum SUIT
        {
            HEARTS,
            SPADES,
            CLUBS,
            DIAMONDS
        }

        public enum VALUE
        {
            TWO,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
            ACE
        }

        public SUIT HSuit { get; set; }
        public VALUE HValue { get; set; }
    }
}
