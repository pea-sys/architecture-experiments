using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class StringDisplay : AbstractDisplay
    {
        private string @string;
        private int width;

        public StringDisplay(String @string)
        {
            this.@string = @string;
            this.width = System.Text.Encoding.GetEncoding(932).GetByteCount(@string);
        }
        public override void open()
        {
            printLine();
        }
        public override void print()
        {
            Console.WriteLine("|" + @string + "|");
        }
        public override void close()
        {
            printLine();
        }

        private void printLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
