using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {
        Dealer dealer;
        Player player;
        Deck deck;
        public void StartNewGame() {
            dealer = new Dealer();
            player = new Player();
            deck = new Deck();
            deck.Shuffle();

            player.GiveCard(deck.GetCard());
            player.GiveCard(deck.GetCard());
            dealer.GiveCard(deck.GetCard());
            dealer.GiveCard(deck.GetCard());

        }

        public void Loop() {

            while (true)
            {
                Console.WriteLine("Player cards: ");
                player.printAllCards();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Dealer cards: ");
                dealer.printAllCards();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                if (!player.IsGameCompleted())
                {
                    if (player.WantCard())
                    {
                        player.GiveCard(deck.GetCard());
                        if (player.IsGameCompleted()) {
                            Console.WriteLine("Player lost!");
                            break;
                        }
                    }
                }
                else {
                    Console.WriteLine("Player lost!");
                    break;
                }

                if (!dealer.IsGameCompleted())
                {
                    if (dealer.WantCard())
                    {
                        dealer.GiveCard(deck.GetCard());
                        if (dealer.IsGameCompleted())
                        {
                            Console.WriteLine("DEALER lost!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("DEALER lost!");
                    break;
                }

            }

        }

    }
}
