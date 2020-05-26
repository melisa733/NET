using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {

        string suit;
        string rank;

        public Card(string suit, string rank) {
            this.suit = suit;
            this.rank = rank;
        }

        public string GetTitle() {
            return suit + " " + rank;
        }

        public int GetPoints()
        {
            switch (rank) {
                case "jack":
                case "queen":
                case "king":
                    return 10;
                case "ace":
                    return 11;
                default:
                    return int.Parse(rank);
            }
        }
    }
}
