namespace MyShope
{
    partial class StoreFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPrdData = new System.Windows.Forms.GroupBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbSuppID = new System.Windows.Forms.ComboBox();
            this.cmbPrdID = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPrdID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.txtPrdQnt = new System.Windows.Forms.TextBox();
            this.lblPrdQnt = new System.Windows.Forms.Label();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtEntNo = new System.Windows.Forms.TextBox();
            this.lblEntNo = new System.Windows.Forms.Label();
            this.gbTaskStat = new System.Windows.Forms.GroupBox();
            this.rbSuppID = new System.Windows.Forms.RadioButton();
            this.rbProdID = new System.Windows.Forms.RadioButton();
            this.rbEntNo = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.gbPrdData.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            this.gbTaskStat.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPrdData
            // 
            this.gbPrdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrdData.BackColor = System.Drawing.Color.Purple;
            this.gbPrdData.Controls.Add(this.lblUnit);
            this.gbPrdData.Controls.Add(this.cmbSuppID);
            this.gbPrdData.Controls.Add(this.cmbPrdID);
            this.gbPrdData.Controls.Add(this.btnRefresh);
            this.gbPrdData.Controls.Add(this.lblPrdID);
            this.gbPrdData.Controls.Add(this.btnSave);
            this.gbPrdData.Controls.Add(this.btnEdit);
            this.gbPrdData.Controls.Add(this.btnDelete);
            this.gbPrdData.Controls.Add(this.btnNew);
            this.gbPrdData.Controls.Add(this.lblSuppID);
            this.gbPrdData.Controls.Add(this.txtPrdQnt);
            this.gbPrdData.Controls.Add(this.lblPrdQnt);
            this.gbPrdData.Location = new System.Drawing.Point(12, 391);
            this.gbPrdData.Name = "gbPrdData";
            this.gbPrdData.Size = new System.Drawing.Size(1320, 233);
            this.gbPrdData.TabIndex = 3;
            this.gbPrdData.TabStop = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Purple;
            this.lblUnit.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Yellow;
            this.lblUnit.Location = new System.Drawing.Point(598, 67);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(67, 32);
            this.lblUnit.TabIndex = 41;
            this.lblUnit.Text = "Unit";
            // 
            // cmbSuppID
            // 
            this.cmbSuppID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppID.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.cmbSuppID.FormattingEnabled = true;
            this.cmbSuppID.Location = new System.Drawing.Point(425, 110);
            this.cmbSuppID.Name = "cmbSuppID";
            this.cmbSuppID.Size = new System.Drawing.Size(284, 35);
            this.cmbSuppID.TabIndex = 40;
            // 
            // cmbPrdID
            // 
            this.cmbPrdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrdID.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.cmbPrdID.FormattingEnabled = true;
            this.cmbPrdID.Location = new System.Drawing.Point(425, 26);
            this.cmbPrdID.Name = "cmbPrdID";
            this.cmbPrdID.Size = new System.Drawing.Size(284, 35);
            this.cmbPrdID.TabIndex = 39;
            this.cmbPrdID.SelectedIndexChanged += new System.EventHandler(this.cmbPrdID_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(818, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPrdID
            // 
            this.lblPrdID.AutoSize = true;
            this.lblPrdID.BackColor = System.Drawing.Color.Purple;
            this.lblPrdID.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdID.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdID.Location = new System.Drawing.Point(17, 25);
            this.lblPrdID.Name = "lblPrdID";
            this.lblPrdID.Size = new System.Drawing.Size(373, 32);
            this.lblPrdID.TabIndex = 38;
            this.lblPrdID.Text = "Enter The Product ID               :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(618, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(218, 175);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(418, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNew.Location = new System.Drawing.Point(18, 175);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(137, 40);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.BackColor = System.Drawing.Color.Purple;
            this.lblSuppID.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppID.ForeColor = System.Drawing.Color.Yellow;
            this.lblSuppID.Location = new System.Drawing.Point(17, 109);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(372, 32);
            this.lblSuppID.TabIndex = 12;
            this.lblSuppID.Text = "Enter The Supplier ID              :";
            // 
            // txtPrdQnt
            // 
            this.txtPrdQnt.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrdQnt.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdQnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrdQnt.Location = new System.Drawing.Point(425, 67);
            this.txtPrdQnt.MaxLength = 20;
            this.txtPrdQnt.Name = "txtPrdQnt";
            this.txtPrdQnt.Size = new System.Drawing.Size(167, 36);
            this.txtPrdQnt.TabIndex = 2;
            // 
            // lblPrdQnt
            // 
            this.lblPrdQnt.AutoSize = true;
            this.lblPrdQnt.BackColor = System.Drawing.Color.Purple;
            this.lblPrdQnt.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdQnt.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdQnt.Location = new System.Drawing.Point(17, 67);
            this.lblPrdQnt.Name = "lblPrdQnt";
            this.lblPrdQnt.Size = new System.Drawing.Size(374, 32);
            this.lblPrdQnt.TabIndex = 10;
            this.lblPrdQnt.Text = "Enter The Product Quantity  :";
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchBy.BackColor = System.Drawing.Color.Purple;
            this.gbSearchBy.Controls.Add(this.btnShow);
            this.gbSearchBy.Controls.Add(this.txtEntNo);
            this.gbSearchBy.Controls.Add(this.lblEntNo);
            this.gbSearchBy.Controls.Add(this.gbTaskStat);
            this.gbSearchBy.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchBy.ForeColor = System.Drawing.Color.Yellow;
            this.gbSearchBy.Location = new System.Drawing.Point(12, 290);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(1320, 95);
            this.gbSearchBy.TabIndex = 4;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Green;
            this.btnShow.Location = new System.Drawing.Point(981, 41);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 40);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtEntNo
            // 
            this.txtEntNo.BackColor = System.Drawing.Color.Silver;
            this.txtEntNo.Enabled = false;
            this.txtEntNo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEntNo.Location = new System.Drawing.Point(793, 43);
            this.txtEntNo.Name = "txtEntNo";
            this.txtEntNo.Size = new System.Drawing.Size(182, 36);
            this.txtEntNo.TabIndex = 1;
            this.txtEntNo.EnabledChanged += new System.EventHandler(this.txtEntNo_EnabledChanged);
            // 
            // lblEntNo
            // 
            this.lblEntNo.AutoSize = true;
            this.lblEntNo.BackColor = System.Drawing.Color.Purple;
            this.lblEntNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblEntNo.Location = new System.Drawing.Point(510, 43);
            this.lblEntNo.Name = "lblEntNo";
            this.lblEntNo.Size = new System.Drawing.Size(210, 32);
            this.lblEntNo.TabIndex = 14;
            this.lblEntNo.Text = "Enter Entry No :";
            // 
            // gbTaskStat
            // 
            this.gbTaskStat.BackColor = System.Drawing.Color.Purple;
            this.gbTaskStat.Controls.Add(this.rbSuppID);
            this.gbTaskStat.Controls.Add(this.rbProdID);
            this.gbTaskStat.Controls.Add(this.rbEntNo);
            this.gbTaskStat.Controls.Add(this.rbAll);
            this.gbTaskStat.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaskStat.ForeColor = System.Drawing.Color.Yellow;
            this.gbTaskStat.Location = new System.Drawing.Point(17, 38);
            this.gbTaskStat.Name = "gbTaskStat";
            this.gbTaskStat.Size = new System.Drawing.Size(487, 43);
            this.gbTaskStat.TabIndex = 0;
            this.gbTaskStat.TabStop = false;
            // 
            // rbSuppID
            // 
            this.rbSuppID.AutoSize = true;
            this.rbSuppID.BackColor = System.Drawing.Color.Purple;
            this.rbSuppID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuppID.ForeColor = System.Drawing.Color.Yellow;
            this.rbSuppID.Location = new System.Drawing.Point(210, 8);
            this.rbSuppID.Name = "rbSuppID";
            this.rbSuppID.Size = new System.Drawing.Size(141, 29);
            this.rbSuppID.TabIndex = 4;
            this.rbSuppID.Text = "Supplier ID";
            this.rbSuppID.UseVisualStyleBackColor = false;
            this.rbSuppID.CheckedChanged += new System.EventHandler(this.rbSuppID_CheckedChanged);
            // 
            // rbProdID
            // 
            this.rbProdID.AutoSize = true;
            this.rbProdID.BackColor = System.Drawing.Color.Purple;
            this.rbProdID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProdID.ForeColor = System.Drawing.Color.Yellow;
            this.rbProdID.Location = new System.Drawing.Point(68, 8);
            this.rbProdID.Name = "rbProdID";
            this.rbProdID.Size = new System.Drawing.Size(136, 29);
            this.rbProdID.TabIndex = 2;
            this.rbProdID.Text = "Product ID";
            this.rbProdID.UseVisualStyleBackColor = false;
            this.rbProdID.CheckedChanged += new System.EventHandler(this.rbProdID_CheckedChanged);
            // 
            // rbEntNo
            // 
            this.rbEntNo.AutoSize = true;
            this.rbEntNo.BackColor = System.Drawing.Color.Purple;
            this.rbEntNo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntNo.ForeColor = System.Drawing.Color.Yellow;
            this.rbEntNo.Location = new System.Drawing.Point(357, 8);
            this.rbEntNo.Name = "rbEntNo";
            this.rbEntNo.Size = new System.Drawing.Size(120, 29);
            this.rbEntNo.TabIndex = 3;
            this.rbEntNo.Text = "Enrty No.";
            this.rbEntNo.UseVisualStyleBackColor = false;
            this.rbEntNo.CheckedChanged += new System.EventHandler(this.rbEntNo_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.BackColor = System.Drawing.Color.Purple;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.Yellow;
            this.rbAll.Location = new System.Drawing.Point(6, 9);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 29);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.BackColor = System.Drawing.Color.Purple;
            this.gbData.Controls.Add(this.dGView);
            this.gbData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.ForeColor = System.Drawing.Color.Black;
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(1320, 278);
            this.gbData.TabIndex = 5;
            this.gbData.TabStop = false;
            // 
            // dGView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGView.Location = new System.Drawing.Point(3, 22);
            this.dGView.Name = "dGView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGView.Size = new System.Drawing.Size(1314, 253);
            this.dGView.TabIndex = 0;
            // 
            // StoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1344, 636);
            this.Controls.Add(this.gbPrdData);
            this.Controls.Add(this.gbSearchBy);
            this.Controls.Add(this.gbData);
            this.Name = "StoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StoreFrm_FormClosed);
            this.Load += new System.EventHandler(this.StoreFrm_Load);
            this.gbPrdData.ResumeLayout(false);
            this.gbPrdData.PerformLayout();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            this.gbTaskStat.ResumeLayout(false);
            this.gbTaskStat.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrdData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblPrdID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.TextBox txtPrdQnt;
        private System.Windows.Forms.Label lblPrdQnt;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtEntNo;
        private System.Windows.Forms.Label lblEntNo;
        private System.Windows.Forms.GroupBox gbTaskStat;
        private System.Windows.Forms.RadioButton rbProdID;
        private System.Windows.Forms.RadioButton rbEntNo;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.RadioButton rbSuppID;
        private System.Windows.Forms.ComboBox cmbPrdID;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbSuppID;
    }
}