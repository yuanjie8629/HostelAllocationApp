using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NoPropertyToModifySelected : ApplicationException
    {
        public NoPropertyToModifySelected(string excMessage):base(excMessage)
        { }
    }
}
