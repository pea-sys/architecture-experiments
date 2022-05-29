using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drawer;

namespace Command
{
    public partial class Form : System.Windows.Forms.Form
    {
        private MacroCommand history = new MacroCommand();
        public Form()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            history.Clear();
            drawCanvas.Invalidate();
        }

        private void drawCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                Command command = new DrawCommand(drawCanvas, e.Location);
                history.Append(command);
                command.Execute();
            }
        }
    }
}
