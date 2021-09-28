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
    public partial class FrmList : Form
    {
        private Hostel h = new Hostel();
        
        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            h = HostelAllocationTest.ReadFile();

            tbxColumn.Font = new Font("Courier New", 9);
            tbxColumn.Text = h.GetStudentListTitle();

            rtbxList.Font = new Font("Courier New", 9);
            rtbxList.Text = h.GetStudentList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmHostel fHostel = new FrmHostel();
            this.Hide();
            fHostel.ShowDialog();
            this.Close();
        }
    }
}
