using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FrmSearch : Form
    {
        private Hostel h = new Hostel();

        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            h = HostelAllocationTest.ReadFile();

            tbxColumn.Font = new Font("Courier New", 9);
            tbxColumn.Text = h.GetStudentListTitle();

            tbxName.Enabled = false;
            tbxRegNumber.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int[] indexOfStudents;

                if (!(rbtnName.Checked) && !(rbtnRegNumber.Checked))
                    throw new NoSearchMethodSelectedException("Please select at least one method to search.");

                if (rbtnName.Checked && tbxName.Text == string.Empty)
                    throw new NoNameEnteredException("Please enter the student's name.");

                if (rbtnRegNumber.Checked && tbxRegNumber.Text == string.Empty)
                    throw new NoRegNumberEnteredException("Please enter the student's registration number.");

                if (rbtnName.Checked)
                    indexOfStudents = h.FindStudentsByName(tbxName.Text);
                else
                    indexOfStudents = h.FindStudentsByRegNumber(tbxRegNumber.Text);

                rtbxList.Font = new Font("Courier New", 9);
                rtbxList.Text = h.GetStudentList(indexOfStudents);
            }
            catch(NoSearchMethodSelectedException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoNameEnteredException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoRegNumberEnteredException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnName.Checked)
            {
                tbxName.Enabled = true;
                btnSearch.Enabled = true;
            }
            else
            {
                tbxName.Clear();
                tbxName.Enabled = false;
            }
        }

        private void rbtnRegNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRegNumber.Checked)
            {
                tbxRegNumber.Enabled = true;
                btnSearch.Enabled = true;
            }
            else
            {
                tbxRegNumber.Clear();
                tbxRegNumber.Enabled = false;
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
