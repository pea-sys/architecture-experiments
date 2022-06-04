using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingleActiveInstanceSingleton
{
    /// <summary>
    /// Single-Active-Instance Singletonパターン・・・たくさんのインスタンスが登場するけれど、 アクティブになっているのはそのうち1個だけ
    /// https://www.hyuki.com/dp/dpinfo.html#SingleActiveInstanceSingleton
    /// 
    /// シングルトンクラスを用いることで、排他構造を作るのは面白いなと思いました
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new PrintWorker("worker1");
            Worker worker2 = new PrintWorker("worker2");

            Worker.ActiveWork("Hello, worker!");
            worker1.Activate();
            Worker.ActiveWork("Hello, worker!");
            worker2.Activate();
            Worker.ActiveWork("Hello, worker!");

            Console.ReadLine();
        }
    }
}
