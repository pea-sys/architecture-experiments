using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal abstract class Tray : Item
    {
        protected List<Item> tray = new List<Item>();
        public Tray(string caption) : base(caption) { }

        public void Add(Item item)
        {
            tray.Add(item);
        }
    }
}
