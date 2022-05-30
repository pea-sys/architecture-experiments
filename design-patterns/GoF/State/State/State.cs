using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface State
    {
        public abstract void DoClock(Context context, int hour);
        public abstract void DoUse(Context context);
        public abstract void DoAlarm(Context context);
        public abstract void DoPhone(Context context);
    }
}
