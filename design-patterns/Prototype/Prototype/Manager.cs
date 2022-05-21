using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    internal class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();
        internal void Register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }
        internal Product Create(string protoname)
        {
            Product p = showcase[protoname];
            return p.CreateClone();
        }
    }
}
