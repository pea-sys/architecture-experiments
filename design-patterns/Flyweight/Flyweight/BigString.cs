using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class BigString
    {
        private BigChar[] bigChars;
        public BigString(string @string)
        {
            bigChars = new BigChar[@string.Length];
            BigCharFactory factory = BigCharFactory.GetInstance();
            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i] = factory.GetBigChar(@string[i]);
            }
        }
        public void Print()
        {
            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i].Print();
            }
        }
    }
}
