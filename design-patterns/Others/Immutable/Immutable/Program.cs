using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Immutableなオブジェクトの作成
            Rectangle rect = new Rectangle(100, 100);
            Console.WriteLine($"[{rect.GetType().Name}]Width={rect.Width.ToString()} Height={ rect.Height.ToString()} Area={rect.Area.ToString()}");
            // 匿名型のオブジェクトでもImmutableになる
            var anonymous = new {Width = 100, Height = 100, Area= 100 * 100 };
            Console.WriteLine($"[{anonymous.GetType()}]Width={rect.Width.ToString()} Height={ rect.Height.ToString()} Area={rect.Area.ToString()}");

            Console.Read();
        }
    }
}
