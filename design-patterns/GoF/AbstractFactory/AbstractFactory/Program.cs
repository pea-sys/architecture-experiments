using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace AbstractFactory
{
    /// <summary>
    /// AbstractFactoryパターン・・・インターフェースの利点を活かし、
    /// 　　　　　　　　　　　　　　　構成要素が決まっている部品を最低限の情報だけで構築可能としているパターン
    ///
    /// 一般化されているドメイン領域であれば、適用しやすい
    /// 特定の部品だけ異なる仕様になる場合、使用は避けた方が良さそう
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: C# Main class.name.of.ConcreteFactory");
                Console.WriteLine("Example 1: C# Main ListFactory.ListFactory");
                Console.WriteLine("Example 2: C# Main TableFactory.TableFactory");
                Environment.Exit(0);
            }
            Factory.Factory factory = Factory.Factory.GetFactory(args[0]);

            Link asahi = factory.CreateLink("朝日新聞", "http://www.asashi.com/");
            Link yomiuri = factory.CreateLink("読売新聞", "http://www.yomiuri.co.jp/");

            Link usYahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
            Link jpYahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            Link excite = factory.CreateLink("Excite", "http://www.excite.co.jp/");
            Link google = factory.CreateLink("Google", "http://www.google.com/");

            Tray traynews = factory.CreateTray("新聞");
            traynews.Add(asahi);
            traynews.Add(yomiuri);

            Tray trayyahoo = factory.CreateTray("Yahoo!");
            trayyahoo.Add(usYahoo);
            trayyahoo.Add(jpYahoo);

            Tray traysearch = factory.CreateTray("サーチエンジン");
            traysearch.Add(trayyahoo);
            traysearch.Add(excite);
            traysearch.Add(google);

            Page page = factory.CreatePage("LinkPage", "結城 浩");
            page.Add(traynews);
            page.Add(traysearch);
            page.Output();

            Console.ReadLine();
        }
    }
}
