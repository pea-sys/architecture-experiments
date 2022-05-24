using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// ChainOfResponsibilityパターン・・・たらい回しパターン
    /// 
    /// たらい回しパターンと言われることが多いが、一つのパイを取り崩していくようなパターンにも使用できる
    /// 16666円を高額金種から払い出す場合等
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Support alice = new NoSupport("Alice");
            Support bob = new LimitSupport("Bob", 100);
            Support charile = new SpecialSupport("Charile", 429);
            Support diana = new LimitSupport("Diana", 200);
            Support elmo = new OddSupport("Elmo");
            Support fred = new LimitSupport("Fred", 300);

            alice.SetNext(bob).SetNext(charile).SetNext(diana).SetNext(elmo).SetNext(fred);
            for (var i = 0; i < 500; i += 33)
            {
                alice.DoSupport(new Trouble(i));
            }
            Console.ReadLine();
        }
    }
}
