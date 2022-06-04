using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleActiveInstanceSingleton
{
    internal class NullWorker : Worker
    {
        private static NullWorker singleton = new NullWorker();
        private NullWorker():base("The NullWorker")
        {

        }
        public static NullWorker GetInstance()
        {
            return singleton;
        }
        public override void Work(String job)
        {
            Console.WriteLine($"({job} is ignored by NullWorker)");
        }
    }
}
