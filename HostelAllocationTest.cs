using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment
{
    public static class HostelAllocationTest
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists("student.txt"))
                Application.Run(new FrmHostel());
            else
                MessageBox.Show("\"student.txt\" not found");
        }

        public static Hostel ReadFile()
        {
            Hostel h = new Hostel();
            Student s;
            Room r;

            try
            {
                string name, regNumber, year, sem, floorNumber, roomNumber;

                StreamReader reader = new StreamReader("student.txt");
                name = reader.ReadLine();

                while (name != null)
                {
                    regNumber = reader.ReadLine();
                    year = reader.ReadLine();
                    sem = reader.ReadLine();
                    floorNumber = reader.ReadLine();
                    roomNumber = reader.ReadLine();

                    r = new Room(floorNumber, roomNumber);
                    s = new Student(name, regNumber, year, sem, r);
                    h.AddStudent(s);

                    name = reader.ReadLine();
                }
                reader.Close();
            }
            catch (IOException exc)
            {
                MessageBox.Show("File error " + exc.Message);
            }

            return h;
        }
    }
}
