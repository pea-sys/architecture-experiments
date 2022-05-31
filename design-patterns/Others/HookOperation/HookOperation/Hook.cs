using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookOperation
{
    public abstract class Hook
    {
        public abstract void PreHook();
        public abstract void PostHook();
    }
}
