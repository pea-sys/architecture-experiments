using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerThread
{
    public class Channel
    {
        private static readonly int MAX_REQUEST = 100;
        private readonly BlockingCollection<Request> requestQueue = new BlockingCollection<Request>(MAX_REQUEST);

        private WorkerThread[] threadPool;

        public Channel(int threads)
        {
            threadPool = new WorkerThread[threads];
            for (int i = 0; i < threadPool.Length; i++)
            {
                threadPool[i] = new WorkerThread("Worker-" + i, this);
            }
        }
        public void StartWorkers()
        {
            foreach (var thread in threadPool)
            {
                Task.Run(() =>
                {
                    Thread.CurrentThread.Name = thread.Name;
                    thread.Run();
                });
            }
        }
        public void PutRequest(Request request)
        {
            requestQueue.Add(request);
        }
        public Request TakeRequest()
        {
            return requestQueue.Take();
        }
    }
}
