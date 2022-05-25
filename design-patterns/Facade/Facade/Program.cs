using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// Facadeパターン・・・窓口でインターフェースをまとめて少なくする
    /// 
    /// 誰しも自然に行っているデザインパターン。
    /// ただインターフェースを減らすのではなく、直感的なインターフェースにまとめ上げる必要がある
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            PageMaker.MakeWelcomePage("hyuki@hyuki.com", "welcome.html");
            Console.ReadLine();
        }
    }
}
