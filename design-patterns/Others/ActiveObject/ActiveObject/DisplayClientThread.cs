using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class DisplayClientThread
    {
        private readonly ActiveObject activeObject;
        private readonly string name;

        public DisplayClientThread(string name, ActiveObject activeObject)
        {
            this.name = name;
            this.activeObject = activeObject;
        }

        public void Run()
        {
            for (int i = 0; true; i++)
            {
                string str = $"ThreadId = {Thread.CurrentThread.ManagedThreadId} {name} {i.ToString()}";
                this.activeObject.DisplayString(str);
                Thread.Sleep(200);
            }
        }
    }
}
