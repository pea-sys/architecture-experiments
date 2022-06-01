using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal class NullGoldMembership : IGoldMembership
    {
        public NullGoldMembership()
        {
            IsShippingFree = false;
        }

        public decimal GetDiscount(decimal amount)
        {
            return 0;
        }

        public bool IsShippingFree { get; set; }
    }
}
