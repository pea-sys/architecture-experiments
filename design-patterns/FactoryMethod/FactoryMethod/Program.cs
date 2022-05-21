using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        /// <summary>
        /// FactoryMethodパターン・・・TemplateMethodパターンをインスタンス生成に適用したもの
        /// 
        /// Factoryクラスを通さずに直接インスタンスをNewするのは避けるべし
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("空条丈太郎");
            Product card2 = factory.Create("吉良吉影");
            Product card3 = factory.Create("岸辺露伴");

            card1.Use();
            card2.Use();
            card3.Use();
            Console.ReadLine();
        }
    }
}
