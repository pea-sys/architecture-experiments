using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuardedSuspension
{
    internal class RequestQueue
    {
        private readonly Queue<Request> queue = new Queue<Request>();
        private readonly object lockObj = new object();
        public  Request GetRequest()
        {
            lock (lockObj)
            {
                while (queue.Count == 0)
                {

                    Monitor.Wait(lockObj);

                }
                return queue.Dequeue();
            }
            
        }
        public void PutRequest(Request request)
        {
            lock (lockObj)
            {

                queue.Enqueue(request);
                Monitor.PulseAll(lockObj);
            }
        }
    }
}
