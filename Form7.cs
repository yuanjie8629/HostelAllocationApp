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
    public partial class FrmRemoveAll : Form
    {
        public FrmRemoveAll()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("student.txt");

            writer.Close();

            this.Hide();
            FrmHostel fHostel = new FrmHostel();
            fHostel.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHostel fHostel = new FrmHostel();
            fHostel.ShowDialog();
            this.Close();
        }

    }
}
