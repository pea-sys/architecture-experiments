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
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Executor executor = new Transaction();
            executor.Perform();
            Console.ReadLine();
        }
    }
}
