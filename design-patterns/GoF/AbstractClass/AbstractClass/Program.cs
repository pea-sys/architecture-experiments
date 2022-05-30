using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    /// <summary>
    /// AbstractClass…抽象クラスを使うだけの基本的なパターン
    /// 
    /// 特に意識することなく使用している
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Player mplay = new MusicPlayer();
            mplay.Load("bach.mid");
            mplay.Play();

            Player vplay = new VideoPlayer();
            vplay.Load("mi2.avi");
            vplay.Play();

            Player[] player = { mplay, vplay };
            for (int i = 0; i < player.Length; i++)
            {
                player[i].Stop();
            }
            Console.ReadLine();
        }
    }
}
