using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwoPhaseTermination
{
    internal class CountupThread
    {
        long _counter = 0;
        readonly CancellationTokenSource tokenSource;
        internal CountupThread(CancellationTokenSource tokenSource)
        {
            this.tokenSource = tokenSource;
        }
        public void ShutdownRequest()
        {
            tokenSource.Cancel();
        }


        public Task Task()
        {
            return new Task(() => {
                try
                {
                    while (!tokenSource.Token.IsCancellationRequested)
                    {
                        DoWork();
                    }
                }
                finally
                {
                    DoShutdown();
                }
            },tokenSource.Token);
        }

        void DoWork()
        {
            _counter++;
            Console.WriteLine($"DoWork: counter = { _counter}");
            Thread.Sleep(1000);
        }

        void DoShutdown()
        {
            Console.WriteLine($"DoShutdown: counter = {_counter}");
        }
    }
}
