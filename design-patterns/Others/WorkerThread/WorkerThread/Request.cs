using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerThread
{
    public class Request
    {
        private readonly String name; // 依頼者
        private readonly int number;  // リクエストの番号
        private static readonly Random random = new Random();
        public Request(String name, int number)
        {
            this.name = name;
            this.number = number;
        }
        public void Execute()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} executes { this }");
            Thread.Sleep(random.Next(1000));
        }
        public override String ToString()
        {
            return $"[ Request from { name} No.{ number } ]";
        }
    }
}
