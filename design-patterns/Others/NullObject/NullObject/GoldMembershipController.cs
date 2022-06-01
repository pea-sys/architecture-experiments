using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal class GoldMembershipController
    {
        public static IGoldMembership GetProfile(IAccount account)
        {
            // if this account has gold membership
            // return profile else return null

            if (account.Rank ==  CardRankType.Gold)
            {
                return new GoldMembership(account.UserName);
            }
            else
            {
                return new NullGoldMembership();
            }
        }
    }
}
