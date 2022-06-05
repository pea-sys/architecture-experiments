using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class RealResult<T> : Result<T>
    {
        private readonly T resultValue;
        public RealResult(T resultValue)
        {
            this.resultValue = resultValue;
        }
        public override T GetResultValue()
        {
            return resultValue;
        }
    }
}
