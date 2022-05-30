using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class StringDisplay : Display
    {
        private string @string;
        public StringDisplay(string @string)
        {
            this.@string = @string;
        }

        public override int GetColumns()
        {
            return Encoding.GetEncoding("shift_jis").GetByteCount(@string);
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return @string;
            }
            else
            {
                return null;
            }
        }
    }
}
