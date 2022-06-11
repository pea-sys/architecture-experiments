using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    internal class WriterThread
    {
        private static readonly Random random = new Random();
        private readonly Data data;
        private readonly String filler;
        private int index = 0;
        public WriterThread(Data data, String filler)
        {
            this.data = data;
            this.filler = filler;
        }
        public void Run()
        {

            while (true)
            {
                char c = nextchar();
                data.Write(c);
                Console.WriteLine("Write:" + c.ToString());
                Thread.Sleep(random.Next(3000));
            }

        }
        private char nextchar()
        {
            char c = filler[index];
            index++;
            if (index >= filler.Length)
            {
                index = 0;
            }
            return c;
        }
    }
}
