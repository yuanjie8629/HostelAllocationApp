﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NoYearSelectedException : ApplicationException
    {
        public NoYearSelectedException(string excMessage) : base(excMessage)
        { }
    }
}
