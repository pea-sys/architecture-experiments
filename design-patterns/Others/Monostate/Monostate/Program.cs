using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monostate
{
    /// <summary>
    /// Monostateパターン・・・実質的にクラスのインスタンスが１つしかないパターン
    /// 
    /// Sinletonは呼び出す際にインスタンスを取得する構文を書く必要があるので状態が維持されるのは自明だけど
    /// Monostateはそれがないので、リスキーな感じはする。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            MonostateTheme monotheme = new MonostateTheme();
            Console.WriteLine("Monostate...");
            Console.WriteLine("Current theme = " + monotheme.GetTheme());
            monotheme.SetTheme("modern");
            Console.WriteLine("Current theme = " + monotheme.GetTheme());
            Console.ReadLine();
        }
    }
}
