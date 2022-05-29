using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class CommandNode : Node
    {
        private Node node;

        public override void Parse(Context context)
        {
            if (context.CurrentToken().Equals("repeat"))
            {
                node = new RepeatCommandNode();
                node.Parse(context);
            }
            else
            {
                node = new PrimitiveCommandNode();
                node.Parse(context);
            }
        }

        public override string ToString()
        {
            return node.ToString();
        }
    }
}
