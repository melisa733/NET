using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player : BasePlayer
    {
        public override bool WantCard()
        {
            string answer;
            Console.WriteLine("Do you want another card?(Enter: yes/no)");
            answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
