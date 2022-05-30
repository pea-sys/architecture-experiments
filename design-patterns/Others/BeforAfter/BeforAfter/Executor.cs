using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforAfter
{
    public abstract class Executor
    {
        protected abstract void Before();
        protected abstract void Execute();
        protected abstract void After();
        public void Perform()
        {
            Before();
            try
            {
                Execute();
            }
            finally
            {
                After();
            }
        }
    }
}
