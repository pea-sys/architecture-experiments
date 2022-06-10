using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSpecificStorage
{
    internal class TSLog
    {
        private readonly string filename;
        private StreamWriter writer;
        public TSLog(string filename, string threadName)
        {
            this.filename = filename;
            Thread.CurrentThread.Name = threadName;
            writer = new StreamWriter(filename, true);
        }
        public void Print(string s)
        {
            writer.WriteLine(s);
        }
        public void Close()
        {
            writer.WriteLine("==== End of log ====");
            writer.Close();
            writer.Dispose();
        }
    }
}



