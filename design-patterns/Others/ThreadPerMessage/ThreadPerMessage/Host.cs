using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPerMessage
{
    public class Host
    {
        private readonly Helper helper = new Helper();
        public void Request(int count, char c)
        {
            Console.WriteLine($"    request({count}, {c}) BEGIN");
            Task.Run(() =>
            {
                helper.handle(count, c);
            });

            Console.WriteLine($"    request({count}, {c}) END");
        }
    }
}
