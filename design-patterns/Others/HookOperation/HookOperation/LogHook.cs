using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookOperation
{
    internal class LogHook : Hook
    {
        public override void PostHook()
        {
            Console.WriteLine("LogHook:PostHook");
        }

        public override void PreHook()
        {
            Console.WriteLine("LogHook:PreHook");
        }
    }
}
