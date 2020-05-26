using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer : BasePlayer
    {
        public override bool WantCard()
        {
            if (CountPoints() < 17)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
