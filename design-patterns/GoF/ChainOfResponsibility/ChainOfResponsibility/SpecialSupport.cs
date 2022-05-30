using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class SpecialSupport : Support
    {
        private int number;
        public SpecialSupport(string name,int number) : base(name)
        {
            this.number = number;
        }
        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.GetNumber() == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
