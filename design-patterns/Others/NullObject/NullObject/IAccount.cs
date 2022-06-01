using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public interface IAccount
    {
        CardRankType Rank { get; }
        string UserName { get; }
        int ID { get; }
    }
}
