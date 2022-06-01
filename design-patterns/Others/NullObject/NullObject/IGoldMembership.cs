using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal interface IGoldMembership
    {
        decimal GetDiscount(decimal amount);
        bool IsShippingFree { get; set; }
    }
}
