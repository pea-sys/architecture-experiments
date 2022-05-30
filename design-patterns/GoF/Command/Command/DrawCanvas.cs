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
    public partial class DrawCanvas : UserControl, Drawable
    {
        private Color color = Color.Red;
        private int radius = 6;
        private MacroCommand history;

        public DrawCanvas()
        {
            InitializeComponent();
        }
        public MacroCommand History { get; set; }

        public void Draw(int x, int y)
        {
            using (Graphics g = CreateGraphics())
            using (Brush brush = new SolidBrush(color))
            {
                Rectangle rectangle = new Rectangle(x, y, radius, radius);
                g.FillEllipse(brush, rectangle);
            }
        }

        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (history != null)
            {
                history.Execute();
            }
        }
    }
}
