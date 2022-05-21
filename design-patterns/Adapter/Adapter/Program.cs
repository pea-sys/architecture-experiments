using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {    /// <summary>
         /// Adapterパターン・・・新しく別のインターフェースに適合させる場合のラッパーを作成する
         /// 
         /// 外部から提供された弄れないライブラリであったり、共通ライブラリに使用することはある
         /// 特に制約がないのであれば、リファクタリングした方が良いと思う
         /// </summary>
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
            Console.ReadLine();
        }
    }
}
