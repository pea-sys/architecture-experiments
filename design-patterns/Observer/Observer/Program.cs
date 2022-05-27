using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// Observerパターン・・・イベント駆動の処理を分離したい時に使用
    /// 　　　　　　　　　　　Observer同士の依存関係は持たせずに部品としての独立性を保つ
    /// 　　　　　　　　　　　Publish/Scribeパターンとも呼ばれる
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);
            generator.Execute();
            Console.ReadLine();
        }
    }
}
