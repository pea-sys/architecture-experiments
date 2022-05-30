using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class AbstractDisplay
    {
        public abstract void open();
        public abstract void print();
        public abstract void close();
        public void display()
        {
            open();
            for (int i = 0; i< 5; i++)
            {
                print();
            }
            close();
        }
    }
}
