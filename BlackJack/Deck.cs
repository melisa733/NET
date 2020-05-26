using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {

        List<Card> cards; 

        public Deck() {
            string[] suits = { "diamonds", "spades", "hearts", "clubs" };
            string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace"};
            cards = new List<Card>();

            foreach (string suit in suits) {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle() {
            var shuffled = cards.OrderBy(x => Guid.NewGuid()).ToList();
            cards = shuffled;
        }

        public Card GetCard() {
            if (cards.Count == 0)
            {
                Console.WriteLine("There is no cards anymore in deck!");
                return new Card("0", "0");
            }
            else {
                Card card = cards.Last();
                cards.Remove(card);
                return card;
            }
        }

        public void printAllCards() {
            foreach (var card in cards) {
                Console.WriteLine(card.GetTitle());
            }
        }

    }
}
