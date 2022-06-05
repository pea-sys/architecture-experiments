using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public abstract class Result<T>
    {
        public abstract T GetResultValue();
    }
}
