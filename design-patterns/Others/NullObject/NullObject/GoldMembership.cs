using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal class GoldMembership : IGoldMembership
    {
        public GoldMembership(string userName)
        {
            // get gold member profile of this user

            IsShippingFree = true;
        }

        public bool IsShippingFree { get; set; }

        public decimal GetDiscount(decimal amount)
        {
            decimal discount = 100;

            //calculate discount

            return discount;
        }
    }
}
