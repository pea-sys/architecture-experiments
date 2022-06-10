using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSpecificStorage
{
    internal class Log
    {
        private static readonly ThreadLocal<TSLog> tsLogCollection = new ThreadLocal<TSLog>();

        public static void Print(String s)
        {
            GetTSLog().Print(s);
        }


        public static void Close()
        {
            GetTSLog().Close();
        }

        // スレッド固有のログを得る
        private static TSLog GetTSLog()
        {
            TSLog tsLog = tsLogCollection.Value;

            // そのスレッドからの呼び出しがはじめてなら、新規作成して登録する
            if (tsLog == null)
            {
                tsLog = new TSLog(Thread.CurrentThread.ManagedThreadId + "-log.txt", Thread.CurrentThread.ManagedThreadId.ToString());
                tsLogCollection.Value = tsLog;
            }

            return tsLog;
        }
    }
}
