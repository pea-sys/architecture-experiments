using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton singleton = new Singleton();
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }
        public static Singleton getInstance()
        {
            return singleton;
        }
    }
}
