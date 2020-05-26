using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture100320
{
    class Program
    {
        static void Main(string[] args)
        {

            string YesOrNo;

            while (true)
            {
                HangmanGame game = new HangmanGame();
                game.NewGame();
                Console.WriteLine(game.GetWord());

                while (!game.IsWordGussed() && !game.IsGameOver())
                {
                    Console.Write("Eneter letter:");
                    if (game.Guess(Console.ReadLine()[0]))
                    {
                        Console.WriteLine(game.GetWord());
                        Console.WriteLine("You have lost {0}/5 lives", game.GetLivesHasBeenLost());
                    }
                    else
                    {
                        Console.WriteLine("This letter is not in the word!");
                        Console.WriteLine("You have lost {0}/5 lives", game.GetLivesHasBeenLost());
                    }
                }
                if (!game.IsGameOver())
                {
                    Console.WriteLine("You have successfully guessed the word!");
                }
                else 
                {
                    Console.WriteLine("You lost all 5 lives! GAME OVER!");
                }
                Console.WriteLine("Do You want to play again(yes/no)?");
                YesOrNo = Console.ReadLine().ToUpper();

                if (YesOrNo == "NO")
                {
                    Console.WriteLine("You answered no, goodbye!");
                     break;
                }
                else if (YesOrNo == "YES")
                {
                    Console.WriteLine("You answered yes. The games is starting again!");
                }
                else
                {
                    Console.WriteLine("Sorry, you pt in the wrong word, goodbye!");
                    break;
                }
            }

            Console.Read();
        }
    }
}
