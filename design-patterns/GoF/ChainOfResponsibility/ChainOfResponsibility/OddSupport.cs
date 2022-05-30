using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class OddSupport : Support
    {
        public OddSupport(string name) : base(name)
        {

        }
        protected override bool Resolve(Trouble trouble)
        {
            if ( trouble.GetNumber() % 2 == 1)
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
