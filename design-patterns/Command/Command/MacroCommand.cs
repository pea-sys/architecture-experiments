using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Command
{
    public class MacroCommand : Command
    {
        private Stack<Command> commands = new Stack<Command>();
        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
        public void Append(Command cmd)
        {
            commands.Push(cmd);
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                commands.Pop();
            }
        }
        public void Clear()
        {
            commands.Clear();
        }
    }
}
