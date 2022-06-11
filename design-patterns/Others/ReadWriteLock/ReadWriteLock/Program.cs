using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    /// <summary>
    /// ReadWriteLockパターン・・・読み込みスレッドは互いにロックせず、書き込みスレッドは他のスレッドとは同時に動かせないロック
    /// 
    /// C#ではReaderWriterLockがある。javaでも似たようなものはあるようだ。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(10);
            Task.WhenAll(
            Task.Run(() => new ReaderThread(data).Run()),
            Task.Run(() => new ReaderThread(data).Run()),
            Task.Run(() => new ReaderThread(data).Run()),
            Task.Run(() => new ReaderThread(data).Run()),
            Task.Run(() => new WriterThread(data, "ABCDEFGHIJKLMNOPQTSTUVWXYZ").Run()),
            Task.Run(() => new WriterThread(data, "abcdefghijklmnopqrstuvwxyz").Run())
            );

            Console.ReadLine();
        }
    }
}
