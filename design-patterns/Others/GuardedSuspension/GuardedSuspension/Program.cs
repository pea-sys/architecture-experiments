using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardedSuspension
{
    /// <summary>
    /// GuardedSuspensionパターン・・・条件が満たされるまでは待ちが発生するスレッドパターン
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestQueue requestQueue = new RequestQueue();
            Task.WhenAll(
            Task.Run(() => new ClientThread(requestQueue, "Alice", 3141592).Run()),
            Task.Run(() => new ServerThread(requestQueue, "Bobby", 6535897).Run()));
            Console.ReadLine();
        }
    }
}
