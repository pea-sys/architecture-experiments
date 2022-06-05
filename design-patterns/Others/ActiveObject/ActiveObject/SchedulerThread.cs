using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class SchedulerThread
    {
        private readonly ActivationQueue queue;

        public SchedulerThread(ActivationQueue queue)
        {
            this.queue = queue;
        }

        public void Invoke(MethodRequest<string> request)
        {
            queue.PutRequest(request);
        }

        public void Run()
        {
            while (true)
            {
                var request = queue.TakeRequest();
                request.Execute();
            }
        }
    }
}
