using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        /// <summary>
        /// TemplateMethodパターン・・・テンプレート昨日を持つパターン
        /// 
        /// サイズの大きいプログラムだと個人による実装ブレを防ぐために自然と使う
        /// 保守・運用の観点から秩序を持たせたい時に便利
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            d1.display();
            d2.display();
            d3.display();
            Console.ReadLine();
        }
    }
}
