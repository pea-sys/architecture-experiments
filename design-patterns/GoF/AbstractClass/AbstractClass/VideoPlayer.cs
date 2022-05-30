using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class VideoPlayer : Player
    {
        public override void Load(string title)
        {
           Console.WriteLine($"Load {typeof(VideoPlayer).Name}");
        }

        public override void Pause()
        {
            Console.WriteLine($"Pause {typeof(VideoPlayer).Name}");
        }

        public override void Play()
        {
            Console.WriteLine($"Play {typeof(VideoPlayer).Name}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stop {typeof(VideoPlayer).Name}");
        }
    }
}
