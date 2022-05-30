using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Game;

internal class Program
{
    /// <summary>
    /// Mementoパターン・・・状態のスナップショット・復元を行うパターン
    /// 
    /// スナップショットを取るデータを一元化するのは非常に重要
    /// このパターンを使用して、実務でリファクタリングしたいモジュールがあるので是非使いたい
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Gamer gamer = new Gamer(100);
        Memento memento = gamer.CreateMemento();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"===={i.ToString()}");
            Console.WriteLine($"現状:{gamer}");
            gamer.Bet();

            Console.WriteLine($"所持金は{gamer.GetMoney().ToString()}円になりました。");
            if (gamer.GetMoney() > memento.GetMoney())
            {
                Console.WriteLine($"    （だいぶ増えたので、現在の状態を保存しておこう）");
                memento = gamer.CreateMemento();
            }
            else if (gamer.GetMoney() < memento.GetMoney() / 2)
            {
                Console.WriteLine($"    （だいぶ減ったので、以前の状態に復帰しよう）");
                gamer.RestoreMemento(memento);
            }
            Thread.Sleep(1000);
        }
        Console.ReadLine();
    }
}
