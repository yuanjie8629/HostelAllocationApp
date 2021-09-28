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
    public partial class FrmModify : Form
    {
        Hostel h = new Hostel();

        public FrmModify()
        {
            InitializeComponent();
        }

        private void FrmModify_Load(object sender, EventArgs e)
        {
            h = HostelAllocationTest.ReadFile();

            tbxColumn.Font = new Font("Courier New", 9);
            tbxColumn.Text = h.GetStudentListTitle();

            rtbxList.Font = new Font("Courier New", 9);
            rtbxList.Text = h.GetStudentList();

            for (int i = 1; i <= h.NumOfStudent; i++)
                cbbNumber.Items.Add(i);

            tbxRoomAvailability.Text = "Room Number\tAvailability";

            cbbFloor.Items.Add("1st floor");
            cbbFloor.Items.Add("2nd floor");
            cbbFloor.Items.Add("3rd floor");
            cbbFloor.Items.Add("4th floor");

            cbbYear.Items.Add(1);
            cbbYear.Items.Add(2);
            cbbYear.Items.Add(3);

            cbbSem.Items.Add(1);
            cbbSem.Items.Add(2);

            lblFloor.Visible = false;
            lblTick.Visible = false;
            btnModify.Visible = false;
            tbxName.Visible = false;
            tbxRegNumber.Visible = false;
            cbbYear.Visible = false;
            cbbSem.Visible = false;
            cbbFloor.Visible = false;
            tbxRoomAvailability.Visible = false;
            rtbxRoomAvailability.Visible = false;

            foreach (Control c in Controls)
            {
                if (c is RadioButton)
                    (c as RadioButton).Visible = false;
                if (c is CheckBox)
                    (c as CheckBox).Visible = false;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                bool noCheckBoxChecked = true;
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        if ((c as CheckBox).Checked)
                        {
                            noCheckBoxChecked = false;
                            break;
                        }
                    }
                }

                if (noCheckBoxChecked)
                    throw new NoPropertyToModifySelected("Please tick the properties of the student you want to modify.");

                if (cbxName.Checked && tbxName.Text == string.Empty)
                    throw new NoNameEnteredException("Please enter the student's name.");

                if (cbxRegNumber.Checked && tbxRegNumber.Text == string.Empty)
                    throw new NoRegNumberEnteredException("Please enter the student's registration number.");

                if (cbxYear.Checked && cbbYear.SelectedIndex == -1)
                    throw new NoYearSelectedException("Please enter the student's current academic year.");

                if (cbxSem.Checked && cbbSem.SelectedIndex == -1)
                    throw new NoSemSelectedException("Please enter the student's current semester.");

                if (cbxRoom.Checked && cbbFloor.SelectedIndex == -1)
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

                if (cbxRoom.Checked && NoRadioButtonChecked)
                    throw new NoRoomSelectedException("Please choose a room.");

                if (cbxRegNumber.Checked && !(tbxRegNumber.Text.All(char.IsDigit)))
                    throw new RegNumberWrongFormatException("Invalid registration number!\nRegistration number should not contain any non-numerical character.");

                if (cbxRegNumber.Checked && tbxRegNumber.Text.Length != 7)
                    throw new RegNumberInvalidDigitsException("Invalid registration number!\nThe length of registration number should be 7 digits.");

                if (cbxRegNumber.Checked && h.CheckDuplicateRegNumber(tbxRegNumber.Text))
                    throw new RegNumberDuplicateException("Invalid registration number!\nDuplicate registration number detected.");

                if (cbxName.Checked)
                    h.StudentList[cbbNumber.SelectedIndex].Name = tbxName.Text;

                if (cbxRegNumber.Checked)
                    h.StudentList[cbbNumber.SelectedIndex].RegNumber = tbxRegNumber.Text;

                if (cbxYear.Checked)
                    h.StudentList[cbbNumber.SelectedIndex].Year = Convert.ToString(cbbYear.Text);

                if (cbxSem.Checked)
                    h.StudentList[cbbNumber.SelectedIndex].Sem = Convert.ToString(cbbSem.Text);

                if (cbxRoom.Checked)
                {
                    h.StudentList[cbbNumber.SelectedIndex].R.FloorNumber = cbbFloor.Text.Substring(0,3);
                    h.StudentList[cbbNumber.SelectedIndex].R.RoomNumber = Convert.ToString(GetRoomNumber());
                }

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

                lblMessage.Text = "Student " + h.StudentList[cbbNumber.SelectedIndex].Name + " (" + h.StudentList[cbbNumber.SelectedIndex].RegNumber + ", Year "+ h.StudentList[cbbNumber.SelectedIndex].Year + " sem "+ h.StudentList[cbbNumber.SelectedIndex].Sem + ") allocated to " + cbbFloor.Text + " room " + h.StudentList[cbbNumber.SelectedIndex].R.RoomNumber + ".";

                h = new Hostel();
                h = HostelAllocationTest.ReadFile();

                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                    {
                        (c as RadioButton).Checked = false;
                        (c as RadioButton).Visible = false;
                    }
                    if (c is CheckBox)
                        (c as CheckBox).Checked = false;
                    if (c is ComboBox)
                        (c as ComboBox).Items.Clear();
                    if (c is RichTextBox)
                        (c as RichTextBox).Clear();
                }

                tbxName.Clear();
                tbxRegNumber.Clear();

                lblFloor.Visible = false;
                lblTick.Visible = false;
                btnModify.Visible = false;
                tbxName.Visible = false;
                tbxRegNumber.Visible = false;
                cbbYear.Visible = false;
                cbbSem.Visible = false;
                cbbFloor.Visible = false;
                tbxRoomAvailability.Visible = false;
                rtbxRoomAvailability.Visible = false;

                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                        (c as RadioButton).Visible = false;
                    if (c is CheckBox)
                        (c as CheckBox).Visible = false;
                }

                for (int i = 1; i <= h.NumOfStudent; i++)
                    cbbNumber.Items.Add(i);

                cbbFloor.Items.Add("1st floor");
                cbbFloor.Items.Add("2nd floor");
                cbbFloor.Items.Add("3rd floor");
                cbbFloor.Items.Add("4th floor");

                cbbYear.Items.Add(1);
                cbbYear.Items.Add(2);
                cbbYear.Items.Add(3);

                cbbSem.Items.Add(1);
                cbbSem.Items.Add(2);

                rtbxList.Font = new Font("Courier New", 9);
                rtbxList.Text = h.GetStudentList();
            }
            catch(NoPropertyToModifySelected exc)
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

        private void cbbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTick.Visible = true;
            btnModify.Visible = true;
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                    (c as CheckBox).Visible = true;
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
            int roomNum;

            rtbxRoomAvailability.Text = "";
            for (int i = 0; i < 8; i++)
            {
                roomNum = i;
                availability[i] = h.FindRoomAvailability(cbbFloor.Text.Substring(0, 3), i + 1);
                rtbxRoomAvailability.Text += "\n\t" + (i + 1) + "\t" + availability[i] + "\n";
            }

            if (availability[0] == "available")
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

        private void cbxName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxName.Checked)
                tbxName.Visible = true;
            else
                tbxName.Visible = false;
        }

        private void cbxRegNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRegNumber.Checked)
                tbxRegNumber.Visible = true;
            else
                tbxRegNumber.Visible = false;
        }

        private void cbxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxYear.Checked)
                cbbYear.Visible = true;
            else
                cbbYear.Visible = false;
        }

        private void cbxSem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSem.Checked)
                cbbSem.Visible = true;
            else
                cbbSem.Visible = false;
        }

        private void cbxRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRoom.Checked)
            {
                lblFloor.Visible = true;
                tbxRoomAvailability.Visible = true;
                rtbxRoomAvailability.Visible = true;
                cbbFloor.Visible = true;
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                        (c as RadioButton).Visible = false;
                }
                lblFloor.Visible = false;
                tbxRoomAvailability.Visible = false;
                rtbxRoomAvailability.Visible = false;
                cbbFloor.Visible = false;
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
