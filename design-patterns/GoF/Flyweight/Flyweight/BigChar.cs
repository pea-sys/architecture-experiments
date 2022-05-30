using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class BigChar
    {
        private char charname;
        private string fontdata;
        public BigChar(char charname)
        {
            this.charname = charname;
            try
            {
                StringBuilder buf = new StringBuilder();
                using (StreamReader reader = new StreamReader($"big{charname}.txt"))
                {
                   buf.AppendLine(reader.ReadToEnd());
                }
                this.fontdata = buf.ToString();
            }
            catch (IOException ex)
            {
                this.fontdata = charname + "?";
            }
        }

        public void Print()
        {
            Console.WriteLine(this.fontdata);
        }
    }
}
