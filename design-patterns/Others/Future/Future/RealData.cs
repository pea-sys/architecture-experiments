using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Future
{
    internal class RealData : Data
    {
        private readonly String content;
    public RealData(int count, char c)
        {
            Console.WriteLine("        making RealData(" + count + ", " + c + ") BEGIN");
            char[] buffer = new char[count];
            for (int i = 0; i < count; i++)
            {
                buffer[i] = c;
                Thread.Sleep(100);
            }
            Console.WriteLine("        making RealData(" + count + ", " + c + ") END");
            this.content = new String(buffer);
        }

        public string GetContent()
        {
            return content;
        }
    }
}
