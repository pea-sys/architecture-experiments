using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSpecificStorage
{
    /// <summary>
    /// ThreadSpecificStorageパターン・・・スレッド固有の値を保持するパターン
    /// 
    /// C#だとスレッドローカルを使えば良さそう
    /// スレッドローカルについては、以下のブログが分かりやすかったです
    /// [参考]https://ufcpp.wordpress.com/2014/02/21/%E5%AE%9F%E8%A1%8C%E3%82%B3%E3%83%B3%E3%83%86%E3%82%AD%E3%82%B9%E3%83%88/
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.WhenAll(
            Task.Run(() => new ClientThread("Alice").Run()),
            Task.Run(() => new ClientThread("Bobby").Run()),
            Task.Run(() => new ClientThread("Chris").Run()))
            .Wait();

            Console.ReadLine();
        }
    }
}
