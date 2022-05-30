using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Balking
{
    /// <summary>
    /// Boakingパターン・・・「オブジェクトの状態が不都合なときメソッドの実行を行わない」 というパターンです。
    /// 
    /// メソッドの実行を行わないスレッドはロックしないで、他のことをさせている
    /// 参考URL:https://www.hyuki.com/dp/dpinfo.html#Balking
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Dish dish = new Dish();

            Action action = () =>
            {
                while (true)
                {
                    dish.wash();
                    Console.WriteLine($"    Work : {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(random.Next(5000));
                }
            };

            Task thread1 = new Task(action);
            Task thread2 = new Task(action);
            Task thread3 = new Task(action);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadLine();
        }
    }
}
