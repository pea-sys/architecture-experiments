using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Prototype
{
    internal class UnderlinePen : Product
    {
        private char ulchar;
        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }
        public void Use(string s)
        {
            int length = Encoding.GetEncoding("Shift_JIS").GetByteCount(s);
            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Product CreateClone()
        {
            return (Product)this.Clone();
        }
    }
}
