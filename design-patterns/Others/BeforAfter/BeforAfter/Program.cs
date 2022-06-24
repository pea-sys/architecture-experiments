using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforAfter
{
    /// <summary>
    /// Before/After・・・例外が起きても最後に必ず特定の処理を行うパターン
    /// 
    /// 参考にしたサイト(https://www.hyuki.com/dp/dpinfo.html#BeforeAfter)
    /// ただ、Javaと違いC#のtry~finallyは遅いので、パフォーマンスの懸念がある処理での乱用は禁物
    /// IDisposableインターフェースを実装したクラスで、Dispose()に最終処理を書いた方が恰好良い
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Executor executor = new Transaction();
            executor.Perform();

            using (new AutoStopwatch("Sleep計測"))
            {
                System.Threading.Thread.Sleep(200);
            }
            Console.ReadLine();
        }
    }
}
