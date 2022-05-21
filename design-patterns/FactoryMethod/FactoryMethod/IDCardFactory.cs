using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class IDCardFactory : Factory
    {
        private List<string> owner = new List<string>(); 
        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            owner.Add(((IDCard)product).GetOwner());
        }
    }
}
