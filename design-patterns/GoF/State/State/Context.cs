using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface Context
    {
        public abstract void ChangeState(State state);
        public abstract void CallSecurityCenter(String msg);
        public abstract void ReccordLog(string msg);
    }
}
