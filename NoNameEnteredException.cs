﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NoNameEnteredException : ApplicationException
    {
        public NoNameEnteredException(string excMessage) : base(excMessage)
        { }
    }
}
