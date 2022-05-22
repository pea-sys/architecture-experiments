using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SideBorder : Border
    {
        private char borderChar;
        public SideBorder(Display display , char ch) :base(display)
        {
            this.borderChar = ch;
        }
        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }
        public override int GetRows()
        {
            return display.GetRows();
        }
        public override string GetRowText(int row)
        {
            return borderChar + display.GetRowText(row) + borderChar;
        }
    }
}
