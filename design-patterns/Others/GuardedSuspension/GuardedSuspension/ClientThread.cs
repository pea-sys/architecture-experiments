using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuardedSuspension
{
    internal class ClientThread
    {
        private readonly Random random;
        private readonly RequestQueue requestQueue;
        public ClientThread(RequestQueue requestQueue, String name, int seed)
        {

            this.requestQueue = requestQueue;
            this.random = new Random(seed);
        }
        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {
                Request request = new Request("No." + i);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " requests " + request);
                requestQueue.PutRequest(request);

                Thread.Sleep(random.Next(1000));
            }
        }
    }
}
