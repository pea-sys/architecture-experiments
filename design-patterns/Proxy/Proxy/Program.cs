using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// Proxyパターン・・・重い処理以外を代役が処理する
    /// 
    /// Proxyパターンにはさまざまな種類がある。
    /// 本プロジェクトはVirtual Proxyパターンです。
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Printable p = new PrinterProxy("Alice");
            Console.WriteLine($"名前は現在{p.PrinterName}です。");
            p.PrinterName = "Bob";
            Console.WriteLine($"名前は現在{p.PrinterName}です。");
            p.Print("Hello, world");
            Console.ReadLine();
        }
    }
}
