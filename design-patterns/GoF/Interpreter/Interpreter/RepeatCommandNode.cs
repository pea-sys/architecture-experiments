using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class RepeatCommandNode : Node
    {
        private int number;
        private Node commandListNode;
        public override void Parse(Context context)
        {
            context.SkipToken("repeat");
            number = context.CurrentNumber();
            context.NextToken();
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }
        public override string ToString()
        {
            return $"[repeat{number} {commandListNode}]";
        }
    }
}
