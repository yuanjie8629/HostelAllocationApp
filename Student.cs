using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string regNumber;
        public string RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        private string year;
        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private string sem;
        public string Sem
        {
            get { return sem; }
            set { sem = value; }
        }

        private Room r;
        public Room R
        { get { return r; } }

        public Student(string aName, string aRegNumber, string aYear, string aSem, Room aR)
        {
            Name = aName;
            RegNumber = aRegNumber;
            Year = aYear;
            Sem = aSem;
            r = aR;
        }
    }
}
