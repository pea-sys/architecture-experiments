using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerThread
{
    /// <summary>
    /// WorkerThreadパターン・・・スレッドプールのようなもの。
    ///                            コンテキストスイッチのコストをなるべく減らすため、スレッドを使いまわす
    /// 
    /// C#ではTaskがスレッドプールを使っているので、自前で実装する必要はなさそう
    /// ThreadPool.SetMaxThreadsでスレッド数も調整できます
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel(5);   // ワーカースレッドの個数
            channel.StartWorkers();
            Task.Run(() => new ClientThread("Alice", channel).Run());
            Task.Run(() => new ClientThread("Bobby", channel).Run());
            Task.Run(() => new ClientThread("Chris", channel).Run());

            Console.ReadLine();
        }
    }
}
