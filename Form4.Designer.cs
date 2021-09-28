namespace Assignment
{
    partial class FrmModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxColumn = new System.Windows.Forms.TextBox();
            this.rtbxList = new System.Windows.Forms.RichTextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbbNumber = new System.Windows.Forms.ComboBox();
            this.lblTick = new System.Windows.Forms.Label();
            this.cbxName = new System.Windows.Forms.CheckBox();
            this.cbxRegNumber = new System.Windows.Forms.CheckBox();
            this.cbxYear = new System.Windows.Forms.CheckBox();
            this.cbxSem = new System.Windows.Forms.CheckBox();
            this.cbxRoom = new System.Windows.Forms.CheckBox();
            this.tbxRoomAvailability = new System.Windows.Forms.TextBox();
            this.rtbxRoomAvailability = new System.Windows.Forms.RichTextBox();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn6 = new System.Windows.Forms.RadioButton();
            this.rbtn7 = new System.Windows.Forms.RadioButton();
            this.rbtn8 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxRegNumber = new System.Windows.Forms.TextBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbSem = new System.Windows.Forms.ComboBox();
            this.cbbFloor = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxColumn
            // 
            this.tbxColumn.Location = new System.Drawing.Point(12, 33);
            this.tbxColumn.Name = "tbxColumn";
            this.tbxColumn.ReadOnly = true;
            this.tbxColumn.Size = new System.Drawing.Size(784, 20);
            this.tbxColumn.TabIndex = 0;
            // 
            // rtbxList
            // 
            this.rtbxList.Location = new System.Drawing.Point(12, 59);
            this.rtbxList.Name = "rtbxList";
            this.rtbxList.ReadOnly = true;
            this.rtbxList.Size = new System.Drawing.Size(784, 180);
            this.rtbxList.TabIndex = 1;
            this.rtbxList.Text = "";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(143, 495);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 590);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "<< Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbbNumber
            // 
            this.cbbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNumber.FormattingEnabled = true;
            this.cbbNumber.Location = new System.Drawing.Point(229, 249);
            this.cbbNumber.Name = "cbbNumber";
            this.cbbNumber.Size = new System.Drawing.Size(121, 21);
            this.cbbNumber.TabIndex = 4;
            this.cbbNumber.SelectedIndexChanged += new System.EventHandler(this.cbbNumber_SelectedIndexChanged);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(9, 306);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(183, 13);
            this.lblTick.TabIndex = 5;
            this.lblTick.Text = "Tick the part that you wish to modify :";
            // 
            // cbxName
            // 
            this.cbxName.AutoSize = true;
            this.cbxName.Location = new System.Drawing.Point(9, 342);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(60, 17);
            this.cbxName.TabIndex = 6;
            this.cbxName.Text = "Name :";
            this.cbxName.UseVisualStyleBackColor = true;
            this.cbxName.CheckedChanged += new System.EventHandler(this.cbxName_CheckedChanged);
            // 
            // cbxRegNumber
            // 
            this.cbxRegNumber.AutoSize = true;
            this.cbxRegNumber.Location = new System.Drawing.Point(9, 370);
            this.cbxRegNumber.Name = "cbxRegNumber";
            this.cbxRegNumber.Size = new System.Drawing.Size(128, 17);
            this.cbxRegNumber.TabIndex = 7;
            this.cbxRegNumber.Text = "Registration Number :";
            this.cbxRegNumber.UseVisualStyleBackColor = true;
            this.cbxRegNumber.CheckedChanged += new System.EventHandler(this.cbxRegNumber_CheckedChanged);
            // 
            // cbxYear
            // 
            this.cbxYear.AutoSize = true;
            this.cbxYear.Location = new System.Drawing.Point(9, 396);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(104, 17);
            this.cbxYear.TabIndex = 8;
            this.cbxYear.Text = "Academic Year :";
            this.cbxYear.UseVisualStyleBackColor = true;
            this.cbxYear.CheckedChanged += new System.EventHandler(this.cbxYear_CheckedChanged);
            // 
            // cbxSem
            // 
            this.cbxSem.AutoSize = true;
            this.cbxSem.Location = new System.Drawing.Point(9, 428);
            this.cbxSem.Name = "cbxSem";
            this.cbxSem.Size = new System.Drawing.Size(76, 17);
            this.cbxSem.TabIndex = 9;
            this.cbxSem.Text = "Semester :";
            this.cbxSem.UseVisualStyleBackColor = true;
            this.cbxSem.CheckedChanged += new System.EventHandler(this.cbxSem_CheckedChanged);
            // 
            // cbxRoom
            // 
            this.cbxRoom.AutoSize = true;
            this.cbxRoom.Location = new System.Drawing.Point(9, 461);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(60, 17);
            this.cbxRoom.TabIndex = 10;
            this.cbxRoom.Text = "Room :";
            this.cbxRoom.UseVisualStyleBackColor = true;
            this.cbxRoom.CheckedChanged += new System.EventHandler(this.cbxRoom_CheckedChanged);
            // 
            // tbxRoomAvailability
            // 
            this.tbxRoomAvailability.Location = new System.Drawing.Point(587, 290);
            this.tbxRoomAvailability.Name = "tbxRoomAvailability";
            this.tbxRoomAvailability.ReadOnly = true;
            this.tbxRoomAvailability.Size = new System.Drawing.Size(194, 20);
            this.tbxRoomAvailability.TabIndex = 12;
            // 
            // rtbxRoomAvailability
            // 
            this.rtbxRoomAvailability.Location = new System.Drawing.Point(587, 316);
            this.rtbxRoomAvailability.Name = "rtbxRoomAvailability";
            this.rtbxRoomAvailability.ReadOnly = true;
            this.rtbxRoomAvailability.Size = new System.Drawing.Size(194, 248);
            this.rtbxRoomAvailability.TabIndex = 13;
            this.rtbxRoomAvailability.Text = "";
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(567, 330);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(14, 13);
            this.rbtn1.TabIndex = 14;
            this.rbtn1.TabStop = true;
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(567, 357);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(14, 13);
            this.rbtn2.TabIndex = 15;
            this.rbtn2.TabStop = true;
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(567, 384);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(14, 13);
            this.rbtn3.TabIndex = 16;
            this.rbtn3.TabStop = true;
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Location = new System.Drawing.Point(567, 409);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(14, 13);
            this.rbtn4.TabIndex = 17;
            this.rbtn4.TabStop = true;
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(567, 436);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(14, 13);
            this.rbtn5.TabIndex = 18;
            this.rbtn5.TabStop = true;
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.Location = new System.Drawing.Point(567, 464);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(14, 13);
            this.rbtn6.TabIndex = 19;
            this.rbtn6.TabStop = true;
            this.rbtn6.UseVisualStyleBackColor = true;
            // 
            // rbtn7
            // 
            this.rbtn7.AutoSize = true;
            this.rbtn7.Location = new System.Drawing.Point(567, 489);
            this.rbtn7.Name = "rbtn7";
            this.rbtn7.Size = new System.Drawing.Size(14, 13);
            this.rbtn7.TabIndex = 20;
            this.rbtn7.TabStop = true;
            this.rbtn7.UseVisualStyleBackColor = true;
            // 
            // rbtn8
            // 
            this.rbtn8.AutoSize = true;
            this.rbtn8.Location = new System.Drawing.Point(567, 516);
            this.rbtn8.Name = "rbtn8";
            this.rbtn8.Size = new System.Drawing.Size(14, 13);
            this.rbtn8.TabIndex = 21;
            this.rbtn8.TabStop = true;
            this.rbtn8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Location = new System.Drawing.Point(215, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 52);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(34, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 23;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(143, 340);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(176, 20);
            this.tbxName.TabIndex = 23;
            // 
            // tbxRegNumber
            // 
            this.tbxRegNumber.Location = new System.Drawing.Point(143, 366);
            this.tbxRegNumber.Name = "tbxRegNumber";
            this.tbxRegNumber.Size = new System.Drawing.Size(176, 20);
            this.tbxRegNumber.TabIndex = 24;
            // 
            // cbbYear
            // 
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(143, 392);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 21);
            this.cbbYear.TabIndex = 25;
            // 
            // cbbSem
            // 
            this.cbbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSem.FormattingEnabled = true;
            this.cbbSem.Location = new System.Drawing.Point(143, 426);
            this.cbbSem.Name = "cbbSem";
            this.cbbSem.Size = new System.Drawing.Size(121, 21);
            this.cbbSem.TabIndex = 26;
            // 
            // cbbFloor
            // 
            this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFloor.FormattingEnabled = true;
            this.cbbFloor.Location = new System.Drawing.Point(632, 258);
            this.cbbFloor.Name = "cbbFloor";
            this.cbbFloor.Size = new System.Drawing.Size(121, 21);
            this.cbbFloor.TabIndex = 27;
            this.cbbFloor.SelectedIndexChanged += new System.EventHandler(this.cbbFloor_SelectedIndexChanged);
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(584, 261);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(36, 13);
            this.lblFloor.TabIndex = 28;
            this.lblFloor.Text = "Floor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pick a number that represents the student :";
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.cbbFloor);
            this.Controls.Add(this.cbbSem);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.tbxRegNumber);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtn8);
            this.Controls.Add(this.rbtn7);
            this.Controls.Add(this.rbtn6);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.rtbxRoomAvailability);
            this.Controls.Add(this.tbxRoomAvailability);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.cbxSem);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxRegNumber);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.cbbNumber);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.rtbxList);
            this.Controls.Add(this.tbxColumn);
            this.Name = "FrmModify";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FrmModify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxColumn;
        private System.Windows.Forms.RichTextBox rtbxList;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cbbNumber;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.CheckBox cbxName;
        private System.Windows.Forms.CheckBox cbxRegNumber;
        private System.Windows.Forms.CheckBox cbxYear;
        private System.Windows.Forms.CheckBox cbxSem;
        private System.Windows.Forms.CheckBox cbxRoom;
        private System.Windows.Forms.TextBox tbxRoomAvailability;
        private System.Windows.Forms.RichTextBox rtbxRoomAvailability;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn6;
        private System.Windows.Forms.RadioButton rbtn7;
        private System.Windows.Forms.RadioButton rbtn8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxRegNumber;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.ComboBox cbbSem;
        private System.Windows.Forms.ComboBox cbbFloor;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label label1;
    }
}