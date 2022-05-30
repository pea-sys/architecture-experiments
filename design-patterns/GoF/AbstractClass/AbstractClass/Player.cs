using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Player
    {
        public abstract void Load(String title);
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }
}
