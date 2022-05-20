using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Book
    {
        private string name;
        internal Book(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}
