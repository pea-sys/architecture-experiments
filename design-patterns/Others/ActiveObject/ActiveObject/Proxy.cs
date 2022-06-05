using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class Proxy : ActiveObject
    {
        private readonly SchedulerThread scheduler;
        private readonly Servant servant;
        public Proxy(SchedulerThread scheduler, Servant servant)
        {
            this.scheduler = scheduler;
            this.servant = servant;
        }
        public Result<String> MakeString(int count, char fillchar)
        {
            FutureResult<String> future = new FutureResult<String>();
            scheduler.Invoke(new MakeStringRequest(servant, future, count, fillchar));
            return future;
        }
        public void DisplayString(String @string)
        {
            scheduler.Invoke(new DisplayStringRequest(servant, @string));
        }
    }
}
