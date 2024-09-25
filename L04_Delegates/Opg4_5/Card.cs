using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace L04_Delegates.Opg4_5
{
    internal class Card
    {
        public enum Suit { Spades, Heart,Clubs, Diamonds };
        public enum Number { Ace,One,Two,Three,Four,Five,Six,Seven,Eigth,Nine,Ten,Jack,Queen,King };

        public Suit _Suit;
        public Number _Number;

        public Card(Suit suit, Number number) {
            _Suit = suit;
            _Number = number;
        }

        public override string ToString()
        {
            return _Suit + " " + _Number;
        }

        public delegate bool FilterCardDelegate(Card card);
    }
}
