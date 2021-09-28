namespace Assignment
{
    partial class FrmList
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxColumn
            // 
            this.tbxColumn.Location = new System.Drawing.Point(13, 40);
            this.tbxColumn.Name = "tbxColumn";
            this.tbxColumn.ReadOnly = true;
            this.tbxColumn.Size = new System.Drawing.Size(810, 20);
            this.tbxColumn.TabIndex = 0;
            // 
            // rtbxList
            // 
            this.rtbxList.Location = new System.Drawing.Point(13, 81);
            this.rtbxList.Name = "rtbxList";
            this.rtbxList.ReadOnly = true;
            this.rtbxList.Size = new System.Drawing.Size(810, 317);
            this.rtbxList.TabIndex = 1;
            this.rtbxList.Text = "";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "<< Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.rtbxList);
            this.Controls.Add(this.tbxColumn);
            this.Name = "FrmList";
            this.Text = "Hostel Allocation List";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxColumn;
        private System.Windows.Forms.RichTextBox rtbxList;
        private System.Windows.Forms.Button btnReturn;
    }
}