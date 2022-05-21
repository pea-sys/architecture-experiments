using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class CharDisplay : AbstractDisplay
    {
        private char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }
        public override void open()
        {
            Console.Write("<<");
        }

        public override void print()
        {
            Console.Write(ch);
        }
        public override void close()
        {
            Console.WriteLine(">>");
        }

        
    }
}
