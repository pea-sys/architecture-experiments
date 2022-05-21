using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
namespace Prototype
{
    internal class Program
    {
        /// <summary>
        /// Prototypeパターン・・・不特定多数の状態を持つインスタンスを複製可能とするパターン
        /// 
        /// 例えば、ユーザーが描いた絵、数式、文章、ノーコードツールでのパイプライン作成など
        /// 個々のオブジェクト要素として分割して管理したい場合に使えそう
        /// ただ、複製はディープコピーじゃないので注意が必要
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            UnderlinePen upen = new UnderlinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            Product p1 = manager.Create("strong message");
            p1.Use("Hello, world");
            Product p2 = manager.Create("warning box");
            p2.Use("Hello, world");
            Product p3 = manager.Create("slash box");
            p3.Use("Hello, world");
            Console.ReadLine();
        }
    }
}
