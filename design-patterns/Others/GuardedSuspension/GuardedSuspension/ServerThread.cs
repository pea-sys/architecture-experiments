using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuardedSuspension
{
    internal class ServerThread
    {
        private readonly Random random;
    private readonly RequestQueue requestQueue;
    public ServerThread(RequestQueue requestQueue, String name, int seed)
        {
            this.requestQueue = requestQueue;
            this.random = new Random(seed);
        }
        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {
                Request request = requestQueue.GetRequest();
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} handles {request}");
                Thread.Sleep(random.Next(1000));
            }
        }
    }
}
