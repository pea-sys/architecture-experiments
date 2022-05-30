using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Prototype
{
    internal class MessageBox:Product
    {
        private char decochar;
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Product CreateClone()
        {
           return (Product)Clone();
        }

        public void Use(string s)
        {
            int length = Encoding.GetEncoding("Shift_JIS").GetByteCount(s);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{decochar} {s} {decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
        }
    }
}
