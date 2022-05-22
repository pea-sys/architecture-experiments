using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class File : Entry
    {
        private string name;
        private int size;
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
        public override string GetName()
        {
            return name;
        }
        public override int GetSize()
        {
            return size;
        }
        public override Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }
        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
        }
    }
}
