using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleActiveInstanceSingleton
{
    public abstract class Worker
    {
        private static Worker active = NullWorker.GetInstance();
        private String name;
        public Worker(String name)
        {
            this.name = name;
        }
        public void Activate()
        {
            lock (this)
            {
                active = this;
            }
        }
        public override String ToString()
        {
            return "[Worker " + name + "]";
        }
        public static void ActiveWork(String job)
        {
            lock (active)
            {
                active.Work(job);
            }
        }
        public abstract void Work(String job);
    }
}
