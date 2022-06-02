using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    /// <summary>
    /// Producer-Consumerパターン・・・Consumer スレッドがキューを介してデータをやり取りするパターン
    /// BlockingDictionayを使えば、テーブルの数も簡単に増やせるしもっと簡単に出来そうです
    /// https://www.hyuki.com/dp/dpinfo.html#ProducerConsumer
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Producerは3人、Consumerは3人。
               データ（ここでは「食べ物」）を置く場所（テーブル）は1つ。
               テーブルには食べ物を1つしか置けない。
               Producerはテーブルが空いていたら自分の生産した食べ物を置く。 　空いていなかったら空くまで待つ。
               Consumerはテーブルの上に置かれている食べ物をとって食べる。 　食べ物がなかったら置かれるまで待つ。
             */
            Table table = new Table();
            Task.Run(() => new Producer("Apple", table).Run());
            Task.Run(() => new Producer("Banana", table).Run());
            Task.Run(() => new Producer("Candy", table).Run());
            Task.Run(() => new Consumer(table).Run());
            Task.Run(() => new Consumer(table).Run());
            Task.Run(() => new Consumer(table).Run());
            Console.ReadLine();
        }
    }
}
