using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class ProgramNode : Node
    {
        private Node commandListNode;
        public override void Parse(Context context)
        {
            context.SkipToken("program");
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }
        public override string ToString()
        {
            return $"[program {commandListNode}]";
        }
    }
}
