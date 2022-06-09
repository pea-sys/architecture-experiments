using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPerMessage
{
    /// <summary>
    /// ThreadPerMessageパターン・・・要求毎にスレッドを生成する
    /// 
    /// 仕事を依頼したら後は関知しない役割を持つクラスに適用可能
    /// とはいえ、非同期処理を備えたクラスというだけな気もします
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main BEGIN");
            Host host = new Host();
            host.Request(10, 'A');
            host.Request(20, 'B');
            host.Request(30, 'C');
            Console.WriteLine("main END");
            Console.ReadLine();
        }
    }
}
