using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Balking
{
    public class Worker 
    {
        private Random random = new Random();
        private Dish dish;
        public Worker(Dish dish)
        {
            this.dish = dish;
        }
        

    }
}
