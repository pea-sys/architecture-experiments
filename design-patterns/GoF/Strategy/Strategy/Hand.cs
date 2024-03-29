﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Hand
    {
        public static readonly int HANDVALUE_GUU = 0;
        public static readonly int HANDVALUE_CHO = 1;
        public static readonly int HANDVALUE_PAA = 2;
        public static Hand[] hand = {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA),
        };
        private static readonly string[] name = {
            "グー", "チョキ", "パー"
        };
        private int handvalue;
        private Hand(int handvalue)
        {
            this.handvalue = handvalue;
        }
        public static Hand GetHand(int handvalue)
        {
            return hand[handvalue];
        }


        public bool IsStrongerThan(Hand h)
        {
            return Fight(h) == 1;
        }

        public bool IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        private int Fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((this.handvalue + 1) % 3 == h.handvalue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return name[handvalue];
        }
    }
}
