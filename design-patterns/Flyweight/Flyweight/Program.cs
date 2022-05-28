using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// Flyweightパターン・・・作成済みのオブジェクトを使いまわす
    /// 
    /// 作成済みオブジェクトをメモリにプーリングする。
    /// プーリングされたオブジェクトは参照され続けるので、GCされない
    /// 常にプログラムに常駐していても良いオブジェクトを登録するようにする
    /// 描画(OnPaint)に使用するオブジェクト等が適していると思う
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: C# Main digits");
                Console.WriteLine("Example: C# Main 1212123");
                System.Environment.Exit(0);
            }

            BigString bs= new BigString(args[0]);
            bs.Print();
            Console.ReadLine();
        }
    }
}
