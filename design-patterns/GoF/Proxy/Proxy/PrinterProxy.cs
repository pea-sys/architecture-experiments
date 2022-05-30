using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class PrinterProxy : Printable
    {
        private Printer real;
        private string name;
        private readonly object lockObj = new object();
        public PrinterProxy()
        {
        }
        public PrinterProxy(string name)
        {
            this.name = name;
        }

        public string PrinterName 
        {
            get => name;
            set
            {
                if (real != null)
                {
                    real.PrinterName = name;
                }
                this.name = value;
            }
        }

        public void Print(string str)
        {
            Realized();
            real.Print(str);
        }


        private void Realized()
        {
            lock (lockObj)
            {
                if (real == null)
                {
                    real = new Printer(name);
                }
            }
        }
    }
}
