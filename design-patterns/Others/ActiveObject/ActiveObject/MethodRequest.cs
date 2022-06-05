using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public abstract class MethodRequest<T>
    { 

        protected Servant servant;
        protected FutureResult<T> future;
        protected MethodRequest(Servant servant, FutureResult<T> future)
        {
            this.servant = servant;
            this.future = future;
        }
        public abstract void Execute();
    }
}
