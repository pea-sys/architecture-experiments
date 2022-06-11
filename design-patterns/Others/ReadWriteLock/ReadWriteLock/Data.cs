using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    public class Data
    {
        private readonly char[] buffer;
        private readonly ReaderWriterLock rwl = new ReaderWriterLock();
        public Data(int size)
        {
            this.buffer = new char[size];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = '*';
            }
        }
        public char[] Read()
        {
            rwl.AcquireReaderLock(-1);
            try
            {
                return DoRead();
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }
        }
        public void Write(char c)
        {
            rwl.AcquireWriterLock(-1);
            try
            {
                DoWrite(c);
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }
        private char[] DoRead()
        {
            char[] newbuf = new char[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                newbuf[i] = buffer[i];
            }
            Slowly();
            return newbuf;
        }
        private void DoWrite(char c)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = c;
                Slowly();
            }
        }
        private void Slowly()
        {

            Thread.Sleep(50);

        }
    }
}
