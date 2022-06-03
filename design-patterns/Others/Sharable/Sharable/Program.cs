using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharable
{
    /// <summary>
    /// Sharableパターン・・・オブジェクトを共有するパターン
    /// 
    /// [参考URL](https://www.hyuki.com/dp/dpinfo.html#Sharable)
    /// 状態維持したいオブジェクトを共有する場合に使用
    /// 大きいオブジェクトや使用頻度の高いオブジェクトを共有する場合は、Flyweightパターン
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster mon1 = Monster.CreateMonster("Pikachu");
            mon1.GoRight();
            mon1.GoRight();
            mon1.GoRight();

            Monster mon2 = Monster.CreateMonster("Dodrio");
            mon2.GoLeft();
            mon2.GoLeft();

            Monster mon3 = Monster.CreateMonster("Metapod");
            mon3.GoRight();
            mon3.GoRight();
            mon3.GoRight();

            Monster pika = Monster.CreateMonster("Pikachu");
            Console.WriteLine(pika);
            Console.ReadLine();
        }
    }
}
