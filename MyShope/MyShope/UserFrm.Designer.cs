namespace MyShope
{
    partial class UserFrm
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
            this.GbMain = new System.Windows.Forms.GroupBox();
            this.GbUpUser = new System.Windows.Forms.GroupBox();
            this.TxtNPass = new System.Windows.Forms.TextBox();
            this.TxtNUName = new System.Windows.Forms.TextBox();
            this.LblNPWord = new System.Windows.Forms.Label();
            this.LblNUName = new System.Windows.Forms.Label();
            this.RbAdmYes = new System.Windows.Forms.RadioButton();
            this.RbAdmNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUName = new System.Windows.Forms.TextBox();
            this.LblPWord = new System.Windows.Forms.Label();
            this.LblUName = new System.Windows.Forms.Label();
            this.GbHead = new System.Windows.Forms.GroupBox();
            this.RbUpUser = new System.Windows.Forms.RadioButton();
            this.RbDelUser = new System.Windows.Forms.RadioButton();
            this.RbNewUser = new System.Windows.Forms.RadioButton();
            this.GbMain.SuspendLayout();
            this.GbUpUser.SuspendLayout();
            this.GbHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMain
            // 
            this.GbMain.BackColor = System.Drawing.Color.Purple;
            this.GbMain.Controls.Add(this.GbUpUser);
            this.GbMain.Controls.Add(this.RbAdmYes);
            this.GbMain.Controls.Add(this.RbAdmNo);
            this.GbMain.Controls.Add(this.label1);
            this.GbMain.Controls.Add(this.BtnSubmit);
            this.GbMain.Controls.Add(this.TxtPass);
            this.GbMain.Controls.Add(this.TxtUName);
            this.GbMain.Controls.Add(this.LblPWord);
            this.GbMain.Controls.Add(this.LblUName);
            this.GbMain.Controls.Add(this.GbHead);
            this.GbMain.ForeColor = System.Drawing.Color.Yellow;
            this.GbMain.Location = new System.Drawing.Point(355, 100);
            this.GbMain.Name = "GbMain";
            this.GbMain.Size = new System.Drawing.Size(634, 437);
            this.GbMain.TabIndex = 4;
            this.GbMain.TabStop = false;
            // 
            // GbUpUser
            // 
            this.GbUpUser.Controls.Add(this.TxtNPass);
            this.GbUpUser.Controls.Add(this.TxtNUName);
            this.GbUpUser.Controls.Add(this.LblNPWord);
            this.GbUpUser.Controls.Add(this.LblNUName);
            this.GbUpUser.Location = new System.Drawing.Point(0, 232);
            this.GbUpUser.Name = "GbUpUser";
            this.GbUpUser.Size = new System.Drawing.Size(634, 133);
            this.GbUpUser.TabIndex = 13;
            this.GbUpUser.TabStop = false;
            this.GbUpUser.Visible = false;
            // 
            // TxtNPass
            // 
            this.TxtNPass.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNPass.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNPass.Location = new System.Drawing.Point(334, 76);
            this.TxtNPass.MaxLength = 15;
            this.TxtNPass.Name = "TxtNPass";
            this.TxtNPass.Size = new System.Drawing.Size(270, 32);
            this.TxtNPass.TabIndex = 6;
            // 
            // TxtNUName
            // 
            this.TxtNUName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNUName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNUName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNUName.Location = new System.Drawing.Point(334, 28);
            this.TxtNUName.MaxLength = 50;
            this.TxtNUName.Name = "TxtNUName";
            this.TxtNUName.Size = new System.Drawing.Size(270, 32);
            this.TxtNUName.TabIndex = 5;
            // 
            // LblNPWord
            // 
            this.LblNPWord.AutoSize = true;
            this.LblNPWord.BackColor = System.Drawing.Color.Blue;
            this.LblNPWord.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNPWord.ForeColor = System.Drawing.Color.Yellow;
            this.LblNPWord.Location = new System.Drawing.Point(26, 75);
            this.LblNPWord.Name = "LblNPWord";
            this.LblNPWord.Size = new System.Drawing.Size(299, 32);
            this.LblNPWord.TabIndex = 11;
            this.LblNPWord.Text = "Enter New Password   : ";
            // 
            // LblNUName
            // 
            this.LblNUName.AutoSize = true;
            this.LblNUName.BackColor = System.Drawing.Color.Blue;
            this.LblNUName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNUName.ForeColor = System.Drawing.Color.Yellow;
            this.LblNUName.Location = new System.Drawing.Point(26, 27);
            this.LblNUName.Name = "LblNUName";
            this.LblNUName.Size = new System.Drawing.Size(301, 32);
            this.LblNUName.TabIndex = 10;
            this.LblNUName.Text = "Enter New User Name : ";
            // 
            // RbAdmYes
            // 
            this.RbAdmYes.AutoSize = true;
            this.RbAdmYes.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAdmYes.ForeColor = System.Drawing.Color.Yellow;
            this.RbAdmYes.Location = new System.Drawing.Point(396, 179);
            this.RbAdmYes.Name = "RbAdmYes";
            this.RbAdmYes.Size = new System.Drawing.Size(62, 29);
            this.RbAdmYes.TabIndex = 10;
            this.RbAdmYes.Text = "Yes";
            this.RbAdmYes.UseVisualStyleBackColor = true;
            // 
            // RbAdmNo
            // 
            this.RbAdmNo.AutoSize = true;
            this.RbAdmNo.Checked = true;
            this.RbAdmNo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAdmNo.ForeColor = System.Drawing.Color.Yellow;
            this.RbAdmNo.Location = new System.Drawing.Point(334, 179);
            this.RbAdmNo.Name = "RbAdmNo";
            this.RbAdmNo.Size = new System.Drawing.Size(56, 29);
            this.RbAdmNo.TabIndex = 9;
            this.RbAdmNo.TabStop = true;
            this.RbAdmNo.Text = "No";
            this.RbAdmNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(26, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Is Admin                           : ";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSubmit.Location = new System.Drawing.Point(247, 371);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(161, 49);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "&SUBMIT";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPass.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPass.Location = new System.Drawing.Point(334, 128);
            this.TxtPass.MaxLength = 15;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(270, 32);
            this.TxtPass.TabIndex = 4;
            // 
            // TxtUName
            // 
            this.TxtUName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtUName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtUName.Location = new System.Drawing.Point(334, 77);
            this.TxtUName.MaxLength = 50;
            this.TxtUName.Name = "TxtUName";
            this.TxtUName.Size = new System.Drawing.Size(270, 32);
            this.TxtUName.TabIndex = 3;
            // 
            // LblPWord
            // 
            this.LblPWord.AutoSize = true;
            this.LblPWord.BackColor = System.Drawing.Color.Blue;
            this.LblPWord.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWord.ForeColor = System.Drawing.Color.Yellow;
            this.LblPWord.Location = new System.Drawing.Point(26, 127);
            this.LblPWord.Name = "LblPWord";
            this.LblPWord.Size = new System.Drawing.Size(299, 32);
            this.LblPWord.TabIndex = 2;
            this.LblPWord.Text = "Enter Password             : ";
            // 
            // LblUName
            // 
            this.LblUName.AutoSize = true;
            this.LblUName.BackColor = System.Drawing.Color.Blue;
            this.LblUName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUName.ForeColor = System.Drawing.Color.Yellow;
            this.LblUName.Location = new System.Drawing.Point(26, 77);
            this.LblUName.Name = "LblUName";
            this.LblUName.Size = new System.Drawing.Size(301, 32);
            this.LblUName.TabIndex = 1;
            this.LblUName.Text = "Enter User Name           : ";
            // 
            // GbHead
            // 
            this.GbHead.BackColor = System.Drawing.Color.Purple;
            this.GbHead.Controls.Add(this.RbUpUser);
            this.GbHead.Controls.Add(this.RbDelUser);
            this.GbHead.Controls.Add(this.RbNewUser);
            this.GbHead.ForeColor = System.Drawing.Color.Yellow;
            this.GbHead.Location = new System.Drawing.Point(0, 0);
            this.GbHead.Name = "GbHead";
            this.GbHead.Size = new System.Drawing.Size(634, 57);
            this.GbHead.TabIndex = 0;
            this.GbHead.TabStop = false;
            // 
            // RbUpUser
            // 
            this.RbUpUser.AutoSize = true;
            this.RbUpUser.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbUpUser.ForeColor = System.Drawing.Color.Yellow;
            this.RbUpUser.Location = new System.Drawing.Point(435, 19);
            this.RbUpUser.Name = "RbUpUser";
            this.RbUpUser.Size = new System.Drawing.Size(169, 29);
            this.RbUpUser.TabIndex = 2;
            this.RbUpUser.Text = "Update A User";
            this.RbUpUser.UseVisualStyleBackColor = true;
            this.RbUpUser.CheckedChanged += new System.EventHandler(this.RbUpUser_CheckedChanged);
            // 
            // RbDelUser
            // 
            this.RbDelUser.AutoSize = true;
            this.RbDelUser.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbDelUser.ForeColor = System.Drawing.Color.Yellow;
            this.RbDelUser.Location = new System.Drawing.Point(247, 19);
            this.RbDelUser.Name = "RbDelUser";
            this.RbDelUser.Size = new System.Drawing.Size(161, 29);
            this.RbDelUser.TabIndex = 1;
            this.RbDelUser.Text = "Delete A User";
            this.RbDelUser.UseVisualStyleBackColor = true;
            this.RbDelUser.CheckedChanged += new System.EventHandler(this.RbDelUser_CheckedChanged);
            // 
            // RbNewUser
            // 
            this.RbNewUser.AutoSize = true;
            this.RbNewUser.Checked = true;
            this.RbNewUser.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNewUser.ForeColor = System.Drawing.Color.Yellow;
            this.RbNewUser.Location = new System.Drawing.Point(26, 19);
            this.RbNewUser.Name = "RbNewUser";
            this.RbNewUser.Size = new System.Drawing.Size(190, 29);
            this.RbNewUser.TabIndex = 0;
            this.RbNewUser.TabStop = true;
            this.RbNewUser.Text = "Create New User";
            this.RbNewUser.UseVisualStyleBackColor = true;
            this.RbNewUser.CheckedChanged += new System.EventHandler(this.RbNewUser_CheckedChanged);
            // 
            // UserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1344, 636);
            this.Controls.Add(this.GbMain);
            this.Name = "UserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserFrm_FormClosed);
            this.GbMain.ResumeLayout(false);
            this.GbMain.PerformLayout();
            this.GbUpUser.ResumeLayout(false);
            this.GbUpUser.PerformLayout();
            this.GbHead.ResumeLayout(false);
            this.GbHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMain;
        private System.Windows.Forms.GroupBox GbUpUser;
        private System.Windows.Forms.TextBox TxtNPass;
        private System.Windows.Forms.TextBox TxtNUName;
        private System.Windows.Forms.Label LblNPWord;
        private System.Windows.Forms.Label LblNUName;
        private System.Windows.Forms.RadioButton RbAdmYes;
        private System.Windows.Forms.RadioButton RbAdmNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUName;
        private System.Windows.Forms.Label LblPWord;
        private System.Windows.Forms.Label LblUName;
        private System.Windows.Forms.GroupBox GbHead;
        private System.Windows.Forms.RadioButton RbUpUser;
        private System.Windows.Forms.RadioButton RbDelUser;
        private System.Windows.Forms.RadioButton RbNewUser;
    }
}