using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class FutureResult<T> : Result<T>
    {
        private Result<T> result;
        private bool ready = false;
        private readonly Object lockObj = new object();

        public void SetResult(Result<T> result)
        {
            lock (lockObj)
            {
                this.result = result;
                this.ready = true;
                Monitor.PulseAll(lockObj);
            }
        }

        public override T GetResultValue()
        {
            lock (lockObj)
            {
                while (!ready)
                {
                    Monitor.Wait(lockObj);
                }

                return result.GetResultValue();
            }
        }
    }
}
