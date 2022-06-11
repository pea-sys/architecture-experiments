using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    internal class ReaderThread
    {
        private readonly Data data;
    public ReaderThread(Data data)
        {
            this.data = data;
        }
        public void Run()
        {
            while (true)
            {
                char[] readbuf = data.Read();
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " reads " + new String(readbuf));
            }
        }
    }
}
