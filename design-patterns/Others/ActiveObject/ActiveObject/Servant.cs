using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiveObject
{
    public class Servant : ActiveObject
    {
        public Result<string> MakeString(int count, char fillchar)
        {
            char[] buffer = new char[count];

            for (int i = 0; i < count; i++)
            {
                buffer[i] = fillchar;
                Thread.Sleep(100);
            }

            return new RealResult<string>(new string(buffer));
        }

        public void DisplayString(string str)
        {
            Console.WriteLine($"DisplayString: {str}");
            Thread.Sleep(10);
        }
    }
}
