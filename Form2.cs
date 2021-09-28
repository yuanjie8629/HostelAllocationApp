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
    public partial class FrmAdd : Form
    {
        private Hostel h = new Hostel();

        public FrmAdd(Hostel aHostel)
        {
            InitializeComponent();
            h = aHostel;
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            h = HostelAllocationTest.ReadFile();

            cbbFloor.Items.Add("1st floor");
            cbbFloor.Items.Add("2nd floor");
            cbbFloor.Items.Add("3rd floor");
            cbbFloor.Items.Add("4th floor");

            tbxRoomAvailability.Text = "Room Number\tAvailability";

            cbbYear.Items.Add(1);
            cbbYear.Items.Add(2);
            cbbYear.Items.Add(3);

            cbbSem.Items.Add(1);
            cbbSem.Items.Add(2);

            foreach (Control c in Controls)
            {
                if (c is RadioButton)
                    (c as RadioButton).Visible = false;
            }
        }

        private void cbbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is RadioButton)
                    (c as RadioButton).Visible = false;
            }

            string[] availability = new string[8];

            rtbxRoomAvailability.Text = "";
            for (int i = 0; i < 8; i++)
            {
                availability[i] = h.FindRoomAvailability(cbbFloor.Text.Substring(0, 3), i+1);
                rtbxRoomAvailability.Text += "\n\t" + (i+1) + "\t" + availability[i] + "\n";
            }

            if(availability[0] == "available")
                rbtn1.Visible = true;
            if (availability[1] == "available")
                rbtn2.Visible = true;
            if (availability[2] == "available")
                rbtn3.Visible = true;
            if (availability[3] == "available")
                rbtn4.Visible = true;
            if (availability[4] == "available")
                rbtn5.Visible = true;
            if (availability[5] == "available")
                rbtn6.Visible = true;
            if (availability[6] == "available")
                rbtn7.Visible = true;
            if (availability[7] == "available")
                rbtn8.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxName.Text == string.Empty)
                    throw new NoNameEnteredException("Please enter the student's name.");

                if (tbxRegNumber.Text == string.Empty)
                    throw new NoRegNumberEnteredException("Please enter the student's registration number.");

                if (cbbYear.SelectedIndex == -1)
                    throw new NoYearSelectedException("Please enter the student's current academic year.");

                if (cbbSem.SelectedIndex == -1)
                    throw new NoSemSelectedException("Please enter the student's current semester.");

                if (cbbFloor.SelectedIndex == -1)
                    throw new NoFloorSelectedException("Please choose a floor.");

                bool NoRadioButtonChecked = true;
                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                    {
                        if ((c as RadioButton).Checked)
                        {
                            NoRadioButtonChecked = false;
                            break;
                        }
                    }
                }

                if (NoRadioButtonChecked)
                    throw new NoRoomSelectedException("Please choose a room.");

                if (!(tbxRegNumber.Text.All(char.IsDigit)))
                    throw new RegNumberWrongFormatException("Invalid registration number!\nRegistration number should not contain any \nnon-numerical character.");

                if (tbxRegNumber.Text.Length != 7)
                    throw new RegNumberInvalidDigitsException("Invalid registration number!\nThe length of registration number should be 7 digits.");

                if (h.CheckDuplicateRegNumber(tbxRegNumber.Text))
                    throw new RegNumberDuplicateException("Invalid registration number!\nDuplicate registration number detected.");

                Room r = new Room(cbbFloor.Text.Substring(0, 3), Convert.ToString(GetRoomNumber()));
                Student s = new Student(tbxName.Text, tbxRegNumber.Text, cbbYear.Text, cbbSem.Text, r);
                h.AddStudent(s);

                StreamWriter writer = new StreamWriter("student.txt");

                //write student in ascending order, k = floor number, j = room number
                for (int k = 1; k < 5; k++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        for (int i = 0; i < h.NumOfStudent; i++)
                        {
                            if (Convert.ToInt32(h.StudentList[i].R.FloorNumber.Substring(0, 1)) == k && h.StudentList[i].R.RoomNumber == Convert.ToString(j))
                            {
                                writer.WriteLine(h.StudentList[i].Name);
                                writer.WriteLine(h.StudentList[i].RegNumber);
                                writer.WriteLine(h.StudentList[i].Year);
                                writer.WriteLine(h.StudentList[i].Sem);
                                writer.WriteLine(h.StudentList[i].R.FloorNumber);
                                writer.WriteLine(h.StudentList[i].R.RoomNumber);
                            }
                        }
                    }
                }

                writer.Close();

                lblMessage.Text = "New Student " + tbxName.Text + " (" + tbxRegNumber.Text + ", Year "+ cbbYear.Text + " sem "+ cbbSem.Text + ")\nallocated to " + cbbFloor.Text + " room " + GetRoomNumber() + ".";

                h = new Hostel();
                h = HostelAllocationTest.ReadFile();

                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                    {
                        (c as RadioButton).Checked = false;
                        (c as RadioButton).Visible = false;
                    }
                    if (c is ComboBox)
                        (c as ComboBox).Items.Clear();
                    if (c is RichTextBox)
                        (c as RichTextBox).Clear();
                }

                tbxName.Clear();
                tbxRegNumber.Clear();

                cbbFloor.Items.Add("1st floor");
                cbbFloor.Items.Add("2nd floor");
                cbbFloor.Items.Add("3rd floor");
                cbbFloor.Items.Add("4th floor");

                cbbYear.Items.Add(1);
                cbbYear.Items.Add(2);
                cbbYear.Items.Add(3);

                cbbSem.Items.Add(1);
                cbbSem.Items.Add(2);
            }
            catch (NoNameEnteredException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoRegNumberEnteredException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoYearSelectedException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoSemSelectedException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoRoomSelectedException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (NoFloorSelectedException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (RegNumberInvalidDigitsException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (RegNumberWrongFormatException exc)
            {
                lblMessage.Text = exc.Message;
            }
            catch (RegNumberDuplicateException exc)
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

        private int GetRoomNumber()
        {
            if (rbtn1.Checked)
                return 1;
            else if (rbtn2.Checked)
                return 2;
            else if (rbtn3.Checked)
                return 3;
            else if (rbtn4.Checked)
                return 4;
            else if (rbtn5.Checked)
                return 5;
            else if (rbtn6.Checked)
                return 6;
            else if (rbtn7.Checked)
                return 7;
            else
                return 8;
        }
    }
}
