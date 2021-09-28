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
    public partial class FrmHostel : Form
    {
        private Hostel h = new Hostel();

        public FrmHostel()
        {
            InitializeComponent();
        }

        private void FrmHostel_Load(object sender, EventArgs e)
        {
            h = HostelAllocationTest.ReadFile();

            lblTitle.Font = new Font("Lucida Calligraphy",20);
            lblTitle2.Font = new Font("Lucida Calligraphy",20);
            lblTitle.Text = "Excellence College";
            lblTitle2.Text = "Hostel Allocation App";

            btnRemoveAll.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdd fAdd = new FrmAdd(h);
            fAdd.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDelete fDel = new FrmDelete();
            fDel.ShowDialog();
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModify fMod = new FrmModify();
            fMod.ShowDialog();
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmList fLst = new FrmList();
            fLst.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSearch fSch = new FrmSearch();
            fSch.ShowDialog();
            this.Close();
        }

        private void cbxEndSem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEndSem.Checked)
                btnRemoveAll.Enabled = true;
            else
                btnRemoveAll.Enabled = false;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRemoveAll fRem = new FrmRemoveAll();
            fRem.ShowDialog();
            this.Close();
        }
    }
}
