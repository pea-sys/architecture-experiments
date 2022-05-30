using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class LimitSupport : Support
    {
        private int limit;
        public LimitSupport(string name, int limit) : base(name)
        {
            this.limit = limit;
        }
        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.GetNumber() < limit)
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
