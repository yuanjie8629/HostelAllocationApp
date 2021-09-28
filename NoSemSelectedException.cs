using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NoSemSelectedException : ApplicationException
    {
        public NoSemSelectedException(string excMessage) : base(excMessage)
        { }
    }
}
