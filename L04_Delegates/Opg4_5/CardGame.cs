using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static L04_Delegates.Opg4_5.Card;

namespace L04_Delegates.Opg4_5
{
    internal class CardGame
    {
        public List<Card> Cards;

        public CardGame() {
        Cards = new List<Card>();
        }

        public void AddCard(Card.Suit suit, Card.Number number) {
            Card card = new Card(suit,number);
            Cards.Add(card);
        }

        public List<Card> filterCardGame(Card.FilterCardDelegate filter) {
            List<Card> cards = new List<Card>();
            foreach (Card card in Cards)
            {
                if(filter(card)) cards.Add(card);
            }
            return cards;
        }

        
    }
}
