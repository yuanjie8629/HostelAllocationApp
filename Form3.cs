using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment
{
    public partial class FrmDelete : Form
    {
        private Hostel h = new Hostel();
        public FrmDelete()
        {
            InitializeComponent();
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {
            h = HostelAllocationTest.ReadFile();

            tbxColumn.Font = new Font("Courier New", 9);
            tbxColumn.Text = h.GetStudentListTitle();

            rtbxList.Font = new Font("Courier New", 9);
            rtbxList.Text = h.GetStudentList();

            for (int i = 1; i <= h.NumOfStudent; i++)
                cbbNumber.Items.Add(i); //combobox for user to choose a student to delete
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbNumber.SelectedIndex == -1)
                    throw new NoStudentSelectedException("Please select a number that represents\nthe student you want to delete.");

                StreamWriter writer = new StreamWriter("student.txt");

                for (int i=0;i<h.NumOfStudent;i++)
                {
                    if (cbbNumber.SelectedIndex != i)
                    {
                        writer.WriteLine(h.StudentList[i].Name);
                        writer.WriteLine(h.StudentList[i].RegNumber);
                        writer.WriteLine(h.StudentList[i].Year);
                        writer.WriteLine(h.StudentList[i].Sem);
                        writer.WriteLine(h.StudentList[i].R.FloorNumber);
                        writer.WriteLine(h.StudentList[i].R.RoomNumber);
                    }
                }

                writer.Close();

                lblMessage.Text = "Student " + h.StudentList[cbbNumber.SelectedIndex].Name + " (" + h.StudentList[cbbNumber.SelectedIndex].RegNumber + ", Year " + h.StudentList[cbbNumber.SelectedIndex].Year + " sem " + h.StudentList[cbbNumber.SelectedIndex].Sem + ")\nunallocated from" + h.StudentList[cbbNumber.SelectedIndex].R.FloorNumber + " floor room " + h.StudentList[cbbNumber.SelectedIndex].R.RoomNumber + ".";

                cbbNumber.Items.Clear();
                rtbxList.Clear();

                h = HostelAllocationTest.ReadFile();

                rtbxList.Font = new Font("Courier New", 9);
                rtbxList.Text = h.GetStudentList();

                for (int i = 1; i <= h.NumOfStudent; i++) 
                    cbbNumber.Items.Add(i);
            }
            catch(NoStudentSelectedException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHostel fHostel = new FrmHostel();
            fHostel.ShowDialog();
            this.Close();
        }
    }
}
