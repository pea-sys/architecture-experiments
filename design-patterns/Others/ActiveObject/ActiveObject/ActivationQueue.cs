using System.Collections.Concurrent;

namespace ActiveObject
{
    public class ActivationQueue
    {
        static readonly int MaxMethodRequest = 100;
        private readonly BlockingCollection<MethodRequest<string>> requestQueue;

        public ActivationQueue()
        {
            this.requestQueue = new BlockingCollection<MethodRequest<string>>(MaxMethodRequest);
        }

        public void PutRequest(MethodRequest<string> request)
        {
            this.requestQueue.Add(request);
        }

        public MethodRequest<string> TakeRequest()
        {
            return this.requestQueue.Take();
        }
    }

}
