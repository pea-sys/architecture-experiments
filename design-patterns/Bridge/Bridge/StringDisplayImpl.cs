using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class StringDisplayImpl : DisplayImpl
    {
        private string @string;
        private int width;
        public StringDisplayImpl(string @string)
        {
            this.@string = @string;
            this.width = Encoding.GetEncoding("shift_jis").GetByteCount(@string);
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{@string}|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        public void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
