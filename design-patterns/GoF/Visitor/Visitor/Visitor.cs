﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal abstract class Visitor
    {
        public abstract void Visit(File file);
        public abstract void Visit(Directory file);
    }
}
