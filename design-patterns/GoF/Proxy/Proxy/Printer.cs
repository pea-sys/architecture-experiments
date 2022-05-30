using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    public class Printer : Printable
    {


        public Printer()
        {
            HeavyJob("Printerのインスタンスを生成中");
        }
        public Printer(string name)
        {
            this.PrinterName = name;
            HeavyJob($"Printerのインスタンス({name})を生成中");
        }

        public string PrinterName {get; set;}


        public void Print(string str)
        {
            Console.WriteLine($"=== {PrinterName} ===");
            Console.WriteLine(str);
        }


        private void HeavyJob(string msg)
        {
            Console.Write(msg);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
            }
            catch (ThreadInterruptedException ex) when ( true )
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("完了。");
        }
    }
}
