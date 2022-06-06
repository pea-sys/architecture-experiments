using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Future
{
    public class Host
    {
        public Data Request(int count, char c)
        {
            Console.WriteLine("    request(" + count + ", " + c + ") BEGIN");

            // (1) FutureDataのインスタンスを作る
            FutureData future = new FutureData();

            // (2) RealDataを作るための新しいスレッドを起動する
            Task.Run(() =>
            {
                RealData realdata = new RealData(count, c);
                future.SetRealData(realdata);
            });

            Console.WriteLine("    request(" + count + ", " + c + ") END");

            // (3) FutureDataのインスタンスを戻り値とする
            return future;
        }
    }
}
