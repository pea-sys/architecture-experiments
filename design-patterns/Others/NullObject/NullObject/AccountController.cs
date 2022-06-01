using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class AccountController
    {
        private Dictionary<string, Account> _accounts = new Dictionary<string, Account>();
        public IAccount GetAccount(string pin)
        {
            if (_accounts.ContainsKey(pin))
            {
                return _accounts[pin];
            }
            else
            {
                return new NullAccount();
            }
                
        }
    }
}
