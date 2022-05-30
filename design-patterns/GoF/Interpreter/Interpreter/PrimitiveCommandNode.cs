using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class PrimitiveCommandNode : Node
    {
        private string name;

        public override void Parse(Context context)
        {
            name = context.CurrentToken();
            context.SkipToken(name);
            if (!name.Equals("go") && !name.Equals("right") && !name.Equals("left"))
            {
                throw new ParseException(name + " is undefined");
            }
        }

        public override string ToString()
        {
            return name;
        }

        public void Print()
        {
            Console.WriteLine("do:" + name);
        }
    }
}
