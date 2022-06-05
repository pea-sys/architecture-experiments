using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class DisplayStringRequest : MethodRequest<string>
    {
        readonly string str;

        public DisplayStringRequest(Servant servant, string str)
            : base(servant, null)
        {
            this.str = str;
        }

        public override void Execute()
        {
            servant.DisplayString(str);
        }
    }
}

