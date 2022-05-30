using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface Printable
    {
        string PrinterName { set; get; }
        void Print(string str);

    }
}
