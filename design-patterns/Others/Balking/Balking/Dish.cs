using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Balking
{
    public class Dish
    {
        private Random random = new Random();
        private volatile bool washing = false;
        
        public void wash()
        {
            lock(this) {
                if (washing)
                {
                    Console.WriteLine($"    Balk : {Thread.CurrentThread.ManagedThreadId}");
                    return;
                }
                washing = true;
            }
            RawWash();
            washing = false;
        }
        private void RawWash()
        {
            Console.WriteLine($"Start washing :{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(random.Next(5000));
            Console.WriteLine($"End washing :{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
