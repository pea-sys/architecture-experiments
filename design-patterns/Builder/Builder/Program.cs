using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Builderパターン・・・特定の構造を持ったインスタンスを構築する
    /// 
    /// Director役がいるので要件が将来に渡って、変更になるリスクが少ないと予見される場合には使用しやすい
    /// そういったケースは中々少ないようには思う
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Program.Usage();
                Environment.Exit(0);
            }
            if (args[0].Equals("plain"))
            {
                TextBuilder textbuilder = new TextBuilder();
                Director director = new Director(textbuilder);
                director.Construct();
                string result = textbuilder.Result;
                Console.WriteLine(result);
            }
            else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlbuilder = new HTMLBuilder();
                Director director = new Director(htmlbuilder);
                director.Construct();
                string filename = htmlbuilder.Filename;
                Console.WriteLine(filename + "が作成されました。");
            }
            else
            {
                Program.Usage();
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
        public static void Usage()
        {
            Console.WriteLine("Usage: C# Main plain     プレーンテキストで文書作成");
            Console.WriteLine("Usage: C# Main html      htmlファイルで文書作成");
        }
    }
}
