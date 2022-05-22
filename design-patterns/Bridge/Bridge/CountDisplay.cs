using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void MultiShow(int times)
        {
            Open();
            for (int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
