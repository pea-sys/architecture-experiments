using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    /// <summary>
    /// Interpreterパターン・・・ミニ言語のインターフェースを提供する
    /// 
    /// コンパイラと同じ。低レイヤの操作をまとめ、高級言語にまとめあげるイメージ。
    /// ノーコードツールもこういったパターンに当てはめられると思います。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("program.txt"))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                    Node node = new ProgramNode();
                    node.Parse(new Context(line));
                    Console.WriteLine($"node = {node}");
                }
            }
            Console.ReadLine();
        }
    }
}
