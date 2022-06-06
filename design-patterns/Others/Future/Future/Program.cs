using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Future
{
    /// <summary>
    /// Futureパターン・・・非同期動作を行いつつ、好きなタイミングで結果取得を待つ
    /// 
    /// C#だとawaitで実現可能。他の言語でもFutureパターンがサポートされている場合が多い。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main BEGIN");
            Host host = new Host();
            Data data1 = host.Request(10, 'A');
            Data data2 = host.Request(20, 'B');
            Data data3 = host.Request(30, 'C');

            Console.WriteLine("main otherJob BEGIN");
            Thread.Sleep(2000);

            Console.WriteLine("main otherJob END");

            Console.WriteLine($"data1 = {data1.GetContent()}");
            Console.WriteLine($"data2 = {data2.GetContent()}");
            Console.WriteLine($"data3 = {data3.GetContent()}");
            Console.WriteLine("main END");

            Console.ReadLine();
        }
    }
}
