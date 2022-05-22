using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class WinningStrategy : Strategy
    {
        private Random random;
        private bool won = false;
        private Hand prevHand;
        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }

        public Hand NextHand()
        {
            if (!won)
            {
                prevHand = Hand.GetHand(random.Next(3));
            }
            return prevHand;
        }

        public void Study(bool win)
        {
            won = win;
        }
    }
}
