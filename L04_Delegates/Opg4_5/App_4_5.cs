using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static L04_Delegates.Opg4_5.Card;

namespace L04_Delegates.Opg4_5
{
    internal class App_4_5
    {
        static void Main(string[] args)
        {
            CardGame game = new CardGame();
            game.AddCard(Card.Suit.Clubs, Card.Number.Jack);
            game.AddCard(Card.Suit.Heart, Card.Number.Ace);
            game.AddCard(Card.Suit.Clubs, Card.Number.Four);
            game.AddCard(Card.Suit.Diamonds, Card.Number.Queen);
            game.AddCard(Card.Suit.Clubs, Card.Number.Ten);

            var billedKort = game.filterCardGame(FilterByBillede);
            var billedKort2 = game.filterCardGame((Card card)=>card._Suit==Card.Suit.Heart);

            //foreach (var card in billedKort)
            //{
            //    Console.WriteLine(card);
            //}
            foreach (var card in billedKort2)
            {
                Console.WriteLine(card);
            }
        }
        static public bool FilterByKlør(Card card)
        {
            if (card._Suit == Suit.Clubs)
                return true;
            else
                return false;
        }

        static public bool FilterByBillede(Card card)
        {
            if (card._Number == Number.Jack || card._Number == Number.Queen || card._Number == Number.King)
                return true;
            else
                return false;
        }

        static public bool FilterByTal(Card card)
        {
            if (!FilterByBillede(card))
                return true;
            else
                return false;
        }
    }
}
