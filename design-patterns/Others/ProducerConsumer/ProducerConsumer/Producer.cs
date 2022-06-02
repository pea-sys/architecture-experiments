using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Producer
    {
        private int counter = 0;
        private Table table;
        private string food;
        public Producer(string food, Table table)
        {
            this.table = table;
            this.food = food;
        }
        public void Run()
        {
            while (true)
            {
                table.Put($"{food} No.{counter}");
                counter++;
            }
        }
    }
}
