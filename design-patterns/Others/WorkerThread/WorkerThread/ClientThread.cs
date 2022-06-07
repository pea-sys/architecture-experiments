using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerThread
{
    public class ClientThread
    {
        private readonly Channel channel;
        private static readonly Random random = new Random();

        public ClientThread(string name, Channel channel)
        {
            Thread.CurrentThread.Name = name;
            this.channel = channel;
        }

        public void Run()
        {
            for (int i = 0; true; i++)
            {
                Request request = new Request(Thread.CurrentThread.Name, i);
                channel.PutRequest(request);
                Thread.Sleep(random.Next(1000));
            }
        }
    }
}
