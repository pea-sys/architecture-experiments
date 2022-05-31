using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookOperation
{
    internal class Print
    {
        private Hook hook;
        private string data;
        public Print(string data, Hook hook)
        {
            this.data = data;
            this.hook = hook;
        }
        public Print(string data) : this(data, new NullHook())
        {
        }
        public void Write()
        {
            hook.PreHook();
            Console.WriteLine(data);
            hook.PostHook();
        }
    }
}
