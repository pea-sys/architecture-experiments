using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Decoratorパターン・・・インターフェースを保ったまま機能追加していくパターン
    /// 
    /// 使いどころはここが参考になった
    /// https://www.oracle.com/webfolder/technetwork/jp/javamagazine/Java-ND18-DecoratorDesignPattern-ja.pdf
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Display b1 = new StringDisplay("Hello, world.");
            Display b2 = new SideBorder(b1, '#');
            Display b3 = new FullBorder(b2);
            b1.Show();
            b2.Show();
            b3.Show();

            Display b4 =
                new SideBorder(
                    new FullBorder(
                        new SideBorder(
                            new FullBorder(
                                new StringDisplay("こんにちは。")
                                ),
                                '*')
                            ),
                            '/'
                        );
            b4.Show();

            Console.ReadLine();
        }
    }
}
