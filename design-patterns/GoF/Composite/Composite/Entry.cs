﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal abstract class Entry : IPrint
    {
        public abstract string GetName();
        public abstract int GetSize();
        public abstract Entry Add(Entry entry);

        public void PrintList()
        {
            PrintList("");
        }
        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return $"{GetName()}({GetSize().ToString()})"; 
        }
    }
}
