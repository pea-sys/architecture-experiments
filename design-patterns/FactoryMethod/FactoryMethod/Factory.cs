using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class Factory
    {
        public Product Create(String owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
        protected abstract Product CreateProduct(String owner);
        protected abstract void RegisterProduct(Product product);
    }
}
