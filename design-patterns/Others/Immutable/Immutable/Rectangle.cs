using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Rectangle
    {
        public int Width { get; }
        public int Height { get; }
        public int Area { get; }
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.Area = width * height;
        }
    }
}
