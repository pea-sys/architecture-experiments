using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command;

namespace Drawer
{
    internal class DrawCommand : Command.Command
    {
        protected Drawable drawable;
        private Point position;

        public DrawCommand(Drawable drawable, Point position)
        {
            this.drawable = drawable;
            this.position = position;
        }
        public void Execute()
        {
            drawable.Draw(position.X, position.Y);
        }
    }
}
