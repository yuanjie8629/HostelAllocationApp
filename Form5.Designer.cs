namespace Assignment
{
    partial class FrmSearch
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
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnRegNumber = new System.Windows.Forms.RadioButton();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxRegNumber = new System.Windows.Forms.TextBox();
            this.tbxColumn = new System.Windows.Forms.TextBox();
            this.rtbxList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Location = new System.Drawing.Point(76, 33);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(108, 17);
            this.rbtnName.TabIndex = 0;
            this.rbtnName.Text = "Search by name :";
            this.rbtnName.UseVisualStyleBackColor = true;
            this.rbtnName.CheckedChanged += new System.EventHandler(this.rbtnName_CheckedChanged);
            // 
            // rbtnRegNumber
            // 
            this.rbtnRegNumber.AutoSize = true;
            this.rbtnRegNumber.Location = new System.Drawing.Point(455, 33);
            this.rbtnRegNumber.Name = "rbtnRegNumber";
            this.rbtnRegNumber.Size = new System.Drawing.Size(171, 17);
            this.rbtnRegNumber.TabIndex = 1;
            this.rbtnRegNumber.Text = "Search by registration number :";
            this.rbtnRegNumber.UseVisualStyleBackColor = true;
            this.rbtnRegNumber.CheckedChanged += new System.EventHandler(this.rbtnRegNumber_CheckedChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(190, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxRegNumber
            // 
            this.tbxRegNumber.Location = new System.Drawing.Point(632, 33);
            this.tbxRegNumber.Name = "tbxRegNumber";
            this.tbxRegNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxRegNumber.TabIndex = 3;
            // 
            // tbxColumn
            // 
            this.tbxColumn.Location = new System.Drawing.Point(12, 102);
            this.tbxColumn.Name = "tbxColumn";
            this.tbxColumn.ReadOnly = true;
            this.tbxColumn.Size = new System.Drawing.Size(794, 20);
            this.tbxColumn.TabIndex = 4;
            // 
            // rtbxList
            // 
            this.rtbxList.Location = new System.Drawing.Point(12, 128);
            this.rtbxList.Name = "rtbxList";
            this.rtbxList.ReadOnly = true;
            this.rtbxList.Size = new System.Drawing.Size(794, 225);
            this.rtbxList.TabIndex = 5;
            this.rtbxList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result :";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "<< Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(62, 359);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Location = new System.Drawing.Point(353, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(17, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbxList);
            this.Controls.Add(this.tbxColumn);
            this.Controls.Add(this.tbxRegNumber);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.rbtnRegNumber);
            this.Controls.Add(this.rbtnName);
            this.Name = "FrmSearch";
            this.Text = "Search Student";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnRegNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxRegNumber;
        private System.Windows.Forms.TextBox tbxColumn;
        private System.Windows.Forms.RichTextBox rtbxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMessage;
    }
}