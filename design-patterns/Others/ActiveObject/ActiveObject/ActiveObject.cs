using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    public interface ActiveObject
    {
        Result<String> MakeString(int count, char fillchar);
        void DisplayString(String @string);
    }
}
