using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class IDCard : Product
    {
        private string owner;
        internal IDCard(String owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            this.owner = owner;
        }
        public override void Use()
        {
            Console.WriteLine(owner + "のカードを使います。");
        }
        public string GetOwner()
        {
            return owner;
        }
    }
}
