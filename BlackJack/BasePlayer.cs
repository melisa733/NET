using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    abstract class BasePlayer
    {
        List<Card> cards;

        public BasePlayer() {
            cards = new List<Card>();
        }

        public void printAllCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card.GetTitle());
            }
        }
        public List<Card> GetCards() {
            return cards;
        }

        public int CountPoints() {
            int result = 0;

            foreach (var card in cards) {
                result = card.GetPoints();
            }

            return result;
        }

        public bool IsGameCompleted() {
            if (CountPoints() >= 21)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void GiveCard(Card card) {
            cards.Add(card);
        }

        public abstract bool WantCard();
    }
}
