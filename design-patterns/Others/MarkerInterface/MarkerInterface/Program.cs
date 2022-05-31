using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkerInterface
{
    /// <summary>
    /// MarkerInterfece・・・クラスにメタ情報を付加をするために空のインターフェースを定義する
    /// 
    /// 属性で良いような気もする。というのも空のインターフェースは抽象化も行っていないため。
    /// チーム開発でMarkerInterfaceをうまく運用するのは難しい。秩序より混乱をもたらしそう。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 100);

        }
    }
}
