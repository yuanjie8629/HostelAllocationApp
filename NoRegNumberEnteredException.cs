using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NoRegNumberEnteredException : ApplicationException
    {
        public NoRegNumberEnteredException(string excMessage) : base(excMessage)
        { }
    }
}
