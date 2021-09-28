using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class NoRoomSelectedException : ApplicationException
    {
        public NoRoomSelectedException(string excMessage):base(excMessage)
        { }
    }
}
