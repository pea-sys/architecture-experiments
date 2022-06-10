using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSpecificStorage
{
    internal class ClientThread
    {
        private readonly string name;
        public ClientThread(string name)
        {
            this.name = name;
        }
        public void Run()
        {

            Console.WriteLine($"{this.name} BEGIN");
            for (int i = 0; i < 10; i++)
            {
                Log.Print($"i = {i}");
                Thread.Sleep(100);
            }
            Log.Close();
            Console.WriteLine($"{this.name} END");
        }
    }
}
