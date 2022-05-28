using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class BigCharFactory
    {
        private Hashtable pool = new Hashtable();

        //Singletonパターン
        private static BigCharFactory singleton = new BigCharFactory();

        private BigCharFactory()
        {
        }

        public static BigCharFactory GetInstance()
        {
            return singleton;
        }
        public BigChar GetBigChar(char charname)
        {
            BigChar bc = (BigChar)pool[" " + charname];

            if (bc == null)
            {
                bc = new BigChar(charname);
                pool.Add(" " + charname, bc);
            }
            return bc;
        }
    }
}
