using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Bridgeパターン・・・機能と実装を別個のクラスに実装する
    /// 
    /// 顧客要望を受けて、増築し続けるようなプロジェクトの場合、本パターンは拡張性があり便利だと思います。
    /// 割と使用されているパターンだと思いますが、Bridgeパターンを知らなかった新人の頃は、コード量が増えて煩わしいと思ってました。
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));
            d1.Show();
            d2.Show();
            d3.Show();
            d3.MultiShow(5);

            Console.ReadLine();
        }
    }
}
