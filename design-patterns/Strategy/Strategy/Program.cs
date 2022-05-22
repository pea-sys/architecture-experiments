using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Strategyパターン・・・アルゴリズムを切り替えるパターン
    /// 
    /// 設定や曜日によって振る舞いを変えたいが、インターフェースは変えなくて良いので拡張性はある
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: C# Main radomeseed1 ane randomeseed2");
                Console.WriteLine("Example: C# Main 314 15");
                Environment.Exit(0);
            }
            int seed1 = int.Parse(args[0]);
            int seed2 = int.Parse(args[1]);
            Player player1 = new Player("Taro", new WinningStrategy(seed1));
            Player player2 = new Player("Hanako", new ProbStrategy(seed2));
            for (int i = 0; i < 10000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();
                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine($"Winner: {player1}");
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine($"Winner: {player2}");
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }

                Console.WriteLine("Total result:");
                Console.WriteLine(player1.ToString());
                Console.WriteLine(player2.ToString());
            }

            Console.ReadLine();
        }
    }
}
