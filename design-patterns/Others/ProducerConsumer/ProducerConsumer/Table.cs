using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Table
    {
        private Random random = new Random();
        private String food_on_table = string.Empty;

        public void Put(String food)
        {
            lock (this)
            {
                while (!string.IsNullOrEmpty(food_on_table))
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " waits (Put)");
                    Monitor.Wait(this);
                }
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Puts " + food);
                food_on_table = food;
                HeavyJob();
                Console.WriteLine(food_on_table + " is on the table.");
                Monitor.PulseAll(this);
            }
        }
        public string Eat()
        {
            lock (this)
            {

                while (string.IsNullOrEmpty(food_on_table))
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " waits (Eat)");
                    Monitor.Wait(this);
                }
                string food = food_on_table;
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Eats " + food);
                food_on_table = null;
                HeavyJob();
                Console.WriteLine("Nothing is on the table.");
                Monitor.PulseAll(this);
                return food;
            }
        }
        private void HeavyJob()
        {
            Thread.Sleep(random.Next(5000));
        }
    }
}
