using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Consumer
    {
        private Table table;
        public Consumer(Table table)
        {
            this.table = table;
        }
        public void Run()
        {
            while(true)
            {
                table.Eat();
            }
        }
    }
}
