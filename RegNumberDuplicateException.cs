﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class RegNumberDuplicateException : ApplicationException
    {
        public RegNumberDuplicateException(string excMessage) : base(excMessage)
        { }
    }
}
