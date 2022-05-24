using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Trouble
    {
        private int number;
        public Trouble(int number)
        {
            this.number = number;
        }
        public int GetNumber()
        {
            return number;
        }
        public override string ToString()
        {
            return $"[Trouble {number}]";
        }
    }
}
