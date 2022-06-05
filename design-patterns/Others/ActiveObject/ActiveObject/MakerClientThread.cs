using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class MakerClientThread
    {
        private readonly ActiveObject activeObject;
        private readonly char fillchar;
        private readonly string name;

        public MakerClientThread(string name, ActiveObject activeObject)
        {
            this.activeObject = activeObject;
            this.name = name;
            this.fillchar = name[0];
        }

        public void Run()
        {
            for (int i = 0; true; i++)
            {
                Result<string> result = this.activeObject.MakeString(i, fillchar);
                Thread.Sleep(100);
                var value = result.GetResultValue();
                Console.WriteLine($"ThreadId = {Thread.CurrentThread.ManagedThreadId} {name} : value = {value}");
            }
        }
    }
}
