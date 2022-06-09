using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPerMessage
{
    public class Helper
    {
        public void handle(int count, char c)
        {
            Console.WriteLine($"        handle({count}, {c}) BEGIN");
            for (int i = 0; i < count; i++)
            {
                slowly();
                Console.WriteLine(c);
            }
            Console.WriteLine("");
            Console.WriteLine($"        handle({count}, {c}) END");
        }
        private void slowly()
        {

            Thread.Sleep(100);
        }
    }
}
