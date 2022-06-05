using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class ActiveObjectFactory
    {
        public static ActiveObject CreateActiveObject()
        {
            var queue = new ActivationQueue();
            var scheduler = new SchedulerThread(queue);

            var proxy = new Proxy(scheduler, new Servant());

            Task.Run(() => scheduler.Run());

            return proxy;
        }
    }
}
