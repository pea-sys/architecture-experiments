using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class NullAccount : IAccount
    {
        public CardRankType Rank => CardRankType.None;

        public string UserName => String.Empty;

        public int ID => -1;
    }
}
