using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingleActiveInstanceSingleton
{
    internal class PrintWorker:Worker
    {
        public PrintWorker(String name) : base(name)
        {
        }
        public  override void Work(String job)
        {
            Console.WriteLine($"{this} does {job}.");
        }
    }
}
