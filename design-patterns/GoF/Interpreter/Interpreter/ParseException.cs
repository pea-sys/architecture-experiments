﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class ParseException : Exception
    {
        public ParseException(string msg) : base(msg)
        {

        }
    }
}
