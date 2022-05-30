using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforAfter
{
    public class Transaction : Executor
    {
        private bool committed = false;
        protected override void Before()
        {
            Console.WriteLine("Begin");
            Console.WriteLine("Create Query");
        }

        protected override void Execute()
        {
            Console.WriteLine("Commit");
            committed = true;
        }
        protected override void After()
        {
            if (!committed)
            {
                Console.WriteLine("Rollback");
            }
        }
    }
}
