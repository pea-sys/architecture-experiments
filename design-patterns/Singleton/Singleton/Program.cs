using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singletonパターン：インスタンスが1個しか存在しないことを保証するパターン
    /// 
    /// 私はデータベース接続ドライバで使用しています
    /// 外部リソースへのアクセス等の問題で複数生成されると困るような場合に、使用するといいんではないでしょうか。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");
            Singleton obj1 = Singleton.getInstance();
            Singleton obj2 = Singleton.getInstance();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }
            Console.WriteLine("End.");
            Console.ReadLine();
        }
    }
}
