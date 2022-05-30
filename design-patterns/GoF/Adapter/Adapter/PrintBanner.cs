using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PrintBanner: Banner, Print
    {
        public PrintBanner(string str) : base(str) { }
        public void PrintWeak()
        {
            this.ShowWithParen();
        }
        public void PrintStrong()
        {
            this.ShowWithAster();
        }
    }
}
