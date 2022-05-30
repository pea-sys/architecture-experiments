using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Banner
    {
        private string @string;
        public Banner(string @string)
        {
            this.@string = @string;
        }
        public void ShowWithParen()
        {
            Console.WriteLine("(" + @string + ")");
        }
        public void ShowWithAster()
        {
            Console.WriteLine("*" + @string + "*");
        }

    }
}
