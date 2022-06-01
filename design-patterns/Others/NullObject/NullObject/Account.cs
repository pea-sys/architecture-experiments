using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class Account : IAccount
    {
        public CardRankType Rank { get; }
        public string UserName { get; }
        public int ID { get; }

        public Account(CardRankType cardRankType, string username, int id)
        {
            this.Rank = cardRankType;
            this.UserName = username;
            this.ID = id;
        }
    }
}
