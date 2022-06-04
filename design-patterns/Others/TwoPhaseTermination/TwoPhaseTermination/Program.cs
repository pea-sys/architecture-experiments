using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwoPhaseTermination
{
    /// <summary>
    /// Two-Phase Termination パターン・・・スレッドの終了処理が終わってからスレッドを止めるパターン
    /// 
    /// これは設計というよりは、そうしないとバグが起きるリスクが高くなるよというお話です
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main: BEGIN");

            
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var t = new CountupThread(tokenSource);
            var task = t.Task();
            task.Start();

            Thread.Sleep(10000);

            Console.WriteLine("main: ShutdownRequest");
            t.ShutdownRequest();

            Console.WriteLine("main; join");
            task.Wait();

            Console.WriteLine("main: END");
            Console.ReadLine();
        }
    }
}
