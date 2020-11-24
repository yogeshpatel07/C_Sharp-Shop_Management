namespace MyShope
{
    partial class DebtFrm
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
            this.cmbDbtrID = new System.Windows.Forms.ComboBox();
            this.gbDbtType = new System.Windows.Forms.GroupBox();
            this.rbTake = new System.Windows.Forms.RadioButton();
            this.rbGive = new System.Windows.Forms.RadioButton();
            this.lblDbtType = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDbtrType = new System.Windows.Forms.GroupBox();
            this.rbSupplier = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDbtrType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDbtrID = new System.Windows.Forms.Label();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.rbByIDNo = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.gbSrchDbtrType = new System.Windows.Forms.GroupBox();
            this.rbSrchSup = new System.Windows.Forms.RadioButton();
            this.rbSrchCust = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtSrchIn = new System.Windows.Forms.TextBox();
            this.lblEntNo = new System.Windows.Forms.Label();
            this.gbTaskStat = new System.Windows.Forms.GroupBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbPrdData.SuspendLayout();
            this.gbDbtType.SuspendLayout();
            this.gbDbtrType.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            this.gbSrchDbtrType.SuspendLayout();
            this.gbTaskStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrdData
            // 
            this.gbPrdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrdData.BackColor = System.Drawing.Color.Purple;
            this.gbPrdData.Controls.Add(this.cmbDbtrID);
            this.gbPrdData.Controls.Add(this.gbDbtType);
            this.gbPrdData.Controls.Add(this.lblDbtType);
            this.gbPrdData.Controls.Add(this.txtAmt);
            this.gbPrdData.Controls.Add(this.label2);
            this.gbPrdData.Controls.Add(this.gbDbtrType);
            this.gbPrdData.Controls.Add(this.btnRefresh);
            this.gbPrdData.Controls.Add(this.lblDbtrType);
            this.gbPrdData.Controls.Add(this.btnSave);
            this.gbPrdData.Controls.Add(this.btnEdit);
            this.gbPrdData.Controls.Add(this.btnDelete);
            this.gbPrdData.Controls.Add(this.btnNew);
            this.gbPrdData.Controls.Add(this.lblDbtrID);
            this.gbPrdData.Location = new System.Drawing.Point(12, 391);
            this.gbPrdData.Name = "gbPrdData";
            this.gbPrdData.Size = new System.Drawing.Size(1320, 233);
            this.gbPrdData.TabIndex = 0;
            this.gbPrdData.TabStop = false;
            // 
            // cmbDbtrID
            // 
            this.cmbDbtrID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDbtrID.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Bold);
            this.cmbDbtrID.FormattingEnabled = true;
            this.cmbDbtrID.Location = new System.Drawing.Point(337, 84);
            this.cmbDbtrID.Name = "cmbDbtrID";
            this.cmbDbtrID.Size = new System.Drawing.Size(260, 35);
            this.cmbDbtrID.TabIndex = 1;
            this.cmbDbtrID.SelectedIndexChanged += new System.EventHandler(this.cmbDbtrID_SelectedIndexChanged);
            // 
            // gbDbtType
            // 
            this.gbDbtType.BackColor = System.Drawing.Color.Purple;
            this.gbDbtType.Controls.Add(this.rbTake);
            this.gbDbtType.Controls.Add(this.rbGive);
            this.gbDbtType.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDbtType.ForeColor = System.Drawing.Color.Yellow;
            this.gbDbtType.Location = new System.Drawing.Point(971, 19);
            this.gbDbtType.Name = "gbDbtType";
            this.gbDbtType.Size = new System.Drawing.Size(190, 43);
            this.gbDbtType.TabIndex = 2;
            this.gbDbtType.TabStop = false;
            // 
            // rbTake
            // 
            this.rbTake.AutoSize = true;
            this.rbTake.BackColor = System.Drawing.Color.Purple;
            this.rbTake.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTake.ForeColor = System.Drawing.Color.Yellow;
            this.rbTake.Location = new System.Drawing.Point(96, 10);
            this.rbTake.Name = "rbTake";
            this.rbTake.Size = new System.Drawing.Size(88, 29);
            this.rbTake.TabIndex = 1;
            this.rbTake.Text = "Taken";
            this.rbTake.UseVisualStyleBackColor = false;
            // 
            // rbGive
            // 
            this.rbGive.AutoSize = true;
            this.rbGive.BackColor = System.Drawing.Color.Purple;
            this.rbGive.Checked = true;
            this.rbGive.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGive.ForeColor = System.Drawing.Color.Yellow;
            this.rbGive.Location = new System.Drawing.Point(6, 9);
            this.rbGive.Name = "rbGive";
            this.rbGive.Size = new System.Drawing.Size(84, 29);
            this.rbGive.TabIndex = 0;
            this.rbGive.TabStop = true;
            this.rbGive.Text = "Given";
            this.rbGive.UseVisualStyleBackColor = false;
            // 
            // lblDbtType
            // 
            this.lblDbtType.AutoSize = true;
            this.lblDbtType.BackColor = System.Drawing.Color.Purple;
            this.lblDbtType.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbtType.ForeColor = System.Drawing.Color.Yellow;
            this.lblDbtType.Location = new System.Drawing.Point(680, 25);
            this.lblDbtType.Name = "lblDbtType";
            this.lblDbtType.Size = new System.Drawing.Size(286, 32);
            this.lblDbtType.TabIndex = 47;
            this.lblDbtType.Text = "Select The Debt Type :";
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmt.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmt.Location = new System.Drawing.Point(971, 83);
            this.txtAmt.MaxLength = 15;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(190, 36);
            this.txtAmt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(680, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Enter The Amount      :";
            // 
            // gbDbtrType
            // 
            this.gbDbtrType.BackColor = System.Drawing.Color.Purple;
            this.gbDbtrType.Controls.Add(this.rbSupplier);
            this.gbDbtrType.Controls.Add(this.rbCustomer);
            this.gbDbtrType.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDbtrType.ForeColor = System.Drawing.Color.Yellow;
            this.gbDbtrType.Location = new System.Drawing.Point(337, 19);
            this.gbDbtrType.Name = "gbDbtrType";
            this.gbDbtrType.Size = new System.Drawing.Size(260, 43);
            this.gbDbtrType.TabIndex = 0;
            this.gbDbtrType.TabStop = false;
            // 
            // rbSupplier
            // 
            this.rbSupplier.AutoSize = true;
            this.rbSupplier.BackColor = System.Drawing.Color.Purple;
            this.rbSupplier.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSupplier.ForeColor = System.Drawing.Color.Yellow;
            this.rbSupplier.Location = new System.Drawing.Point(137, 10);
            this.rbSupplier.Name = "rbSupplier";
            this.rbSupplier.Size = new System.Drawing.Size(114, 29);
            this.rbSupplier.TabIndex = 1;
            this.rbSupplier.Text = "Supplier";
            this.rbSupplier.UseVisualStyleBackColor = false;
            this.rbSupplier.CheckedChanged += new System.EventHandler(this.rbSupplier_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.BackColor = System.Drawing.Color.Purple;
            this.rbCustomer.Checked = true;
            this.rbCustomer.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.ForeColor = System.Drawing.Color.Yellow;
            this.rbCustomer.Location = new System.Drawing.Point(6, 9);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(125, 29);
            this.rbCustomer.TabIndex = 0;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = false;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(818, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDbtrType
            // 
            this.lblDbtrType.AutoSize = true;
            this.lblDbtrType.BackColor = System.Drawing.Color.Purple;
            this.lblDbtrType.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbtrType.ForeColor = System.Drawing.Color.Yellow;
            this.lblDbtrType.Location = new System.Drawing.Point(17, 25);
            this.lblDbtrType.Name = "lblDbtrType";
            this.lblDbtrType.Size = new System.Drawing.Size(312, 32);
            this.lblDbtrType.TabIndex = 38;
            this.lblDbtrType.Text = "Select The Debter Type :";
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
            this.btnSave.TabIndex = 7;
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
            this.btnEdit.TabIndex = 5;
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
            this.btnDelete.TabIndex = 6;
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
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDbtrID
            // 
            this.lblDbtrID.AutoSize = true;
            this.lblDbtrID.BackColor = System.Drawing.Color.Purple;
            this.lblDbtrID.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbtrID.ForeColor = System.Drawing.Color.Yellow;
            this.lblDbtrID.Location = new System.Drawing.Point(17, 83);
            this.lblDbtrID.Name = "lblDbtrID";
            this.lblDbtrID.Size = new System.Drawing.Size(314, 32);
            this.lblDbtrID.TabIndex = 10;
            this.lblDbtrID.Text = "Enter The ID Number     :";
            // 
            // rbByName
            // 
            this.rbByName.AutoSize = true;
            this.rbByName.BackColor = System.Drawing.Color.Purple;
            this.rbByName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByName.ForeColor = System.Drawing.Color.Yellow;
            this.rbByName.Location = new System.Drawing.Point(68, 9);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(115, 29);
            this.rbByName.TabIndex = 1;
            this.rbByName.Text = "By Name";
            this.rbByName.UseVisualStyleBackColor = false;
            this.rbByName.CheckedChanged += new System.EventHandler(this.rbByName_CheckedChanged);
            // 
            // rbByIDNo
            // 
            this.rbByIDNo.AutoSize = true;
            this.rbByIDNo.BackColor = System.Drawing.Color.Purple;
            this.rbByIDNo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByIDNo.ForeColor = System.Drawing.Color.Yellow;
            this.rbByIDNo.Location = new System.Drawing.Point(189, 9);
            this.rbByIDNo.Name = "rbByIDNo";
            this.rbByIDNo.Size = new System.Drawing.Size(118, 29);
            this.rbByIDNo.TabIndex = 2;
            this.rbByIDNo.Text = "By ID No.";
            this.rbByIDNo.UseVisualStyleBackColor = false;
            this.rbByIDNo.CheckedChanged += new System.EventHandler(this.rbByIDNo_CheckedChanged);
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
            // gbSearchBy
            // 
            this.gbSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchBy.BackColor = System.Drawing.Color.Purple;
            this.gbSearchBy.Controls.Add(this.gbSrchDbtrType);
            this.gbSearchBy.Controls.Add(this.btnShow);
            this.gbSearchBy.Controls.Add(this.txtSrchIn);
            this.gbSearchBy.Controls.Add(this.lblEntNo);
            this.gbSearchBy.Controls.Add(this.gbTaskStat);
            this.gbSearchBy.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchBy.ForeColor = System.Drawing.Color.Yellow;
            this.gbSearchBy.Location = new System.Drawing.Point(12, 290);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(1320, 95);
            this.gbSearchBy.TabIndex = 1;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
            // 
            // gbSrchDbtrType
            // 
            this.gbSrchDbtrType.BackColor = System.Drawing.Color.Purple;
            this.gbSrchDbtrType.Controls.Add(this.rbSrchSup);
            this.gbSrchDbtrType.Controls.Add(this.rbSrchCust);
            this.gbSrchDbtrType.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSrchDbtrType.ForeColor = System.Drawing.Color.Yellow;
            this.gbSrchDbtrType.Location = new System.Drawing.Point(23, 35);
            this.gbSrchDbtrType.Name = "gbSrchDbtrType";
            this.gbSrchDbtrType.Size = new System.Drawing.Size(256, 43);
            this.gbSrchDbtrType.TabIndex = 0;
            this.gbSrchDbtrType.TabStop = false;
            // 
            // rbSrchSup
            // 
            this.rbSrchSup.AutoSize = true;
            this.rbSrchSup.BackColor = System.Drawing.Color.Purple;
            this.rbSrchSup.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSrchSup.ForeColor = System.Drawing.Color.Yellow;
            this.rbSrchSup.Location = new System.Drawing.Point(137, 10);
            this.rbSrchSup.Name = "rbSrchSup";
            this.rbSrchSup.Size = new System.Drawing.Size(114, 29);
            this.rbSrchSup.TabIndex = 1;
            this.rbSrchSup.Text = "Supplier";
            this.rbSrchSup.UseVisualStyleBackColor = false;
            // 
            // rbSrchCust
            // 
            this.rbSrchCust.AutoSize = true;
            this.rbSrchCust.BackColor = System.Drawing.Color.Purple;
            this.rbSrchCust.Checked = true;
            this.rbSrchCust.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSrchCust.ForeColor = System.Drawing.Color.Yellow;
            this.rbSrchCust.Location = new System.Drawing.Point(6, 9);
            this.rbSrchCust.Name = "rbSrchCust";
            this.rbSrchCust.Size = new System.Drawing.Size(125, 29);
            this.rbSrchCust.TabIndex = 0;
            this.rbSrchCust.TabStop = true;
            this.rbSrchCust.Text = "Customer";
            this.rbSrchCust.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Green;
            this.btnShow.Location = new System.Drawing.Point(1040, 37);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 40);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtSrchIn
            // 
            this.txtSrchIn.BackColor = System.Drawing.Color.Silver;
            this.txtSrchIn.Enabled = false;
            this.txtSrchIn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSrchIn.Location = new System.Drawing.Point(873, 41);
            this.txtSrchIn.MaxLength = 10;
            this.txtSrchIn.Name = "txtSrchIn";
            this.txtSrchIn.Size = new System.Drawing.Size(161, 36);
            this.txtSrchIn.TabIndex = 2;
            this.txtSrchIn.EnabledChanged += new System.EventHandler(this.txtSrchIn_EnabledChanged);
            // 
            // lblEntNo
            // 
            this.lblEntNo.AutoSize = true;
            this.lblEntNo.BackColor = System.Drawing.Color.Purple;
            this.lblEntNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblEntNo.Location = new System.Drawing.Point(603, 40);
            this.lblEntNo.Name = "lblEntNo";
            this.lblEntNo.Size = new System.Drawing.Size(264, 32);
            this.lblEntNo.TabIndex = 14;
            this.lblEntNo.Text = "Enter Debter Name :";
            // 
            // gbTaskStat
            // 
            this.gbTaskStat.BackColor = System.Drawing.Color.Purple;
            this.gbTaskStat.Controls.Add(this.rbByName);
            this.gbTaskStat.Controls.Add(this.rbByIDNo);
            this.gbTaskStat.Controls.Add(this.rbAll);
            this.gbTaskStat.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaskStat.ForeColor = System.Drawing.Color.Yellow;
            this.gbTaskStat.Location = new System.Drawing.Point(285, 35);
            this.gbTaskStat.Name = "gbTaskStat";
            this.gbTaskStat.Size = new System.Drawing.Size(312, 43);
            this.gbTaskStat.TabIndex = 1;
            this.gbTaskStat.TabStop = false;
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
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            // 
            // DebtFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1344, 636);
            this.Controls.Add(this.gbPrdData);
            this.Controls.Add(this.gbSearchBy);
            this.Controls.Add(this.gbData);
            this.Name = "DebtFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DebtFrm_FormClosed);
            this.Load += new System.EventHandler(this.DebtFrm_Load);
            this.gbPrdData.ResumeLayout(false);
            this.gbPrdData.PerformLayout();
            this.gbDbtType.ResumeLayout(false);
            this.gbDbtType.PerformLayout();
            this.gbDbtrType.ResumeLayout(false);
            this.gbDbtrType.PerformLayout();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            this.gbSrchDbtrType.ResumeLayout(false);
            this.gbSrchDbtrType.PerformLayout();
            this.gbTaskStat.ResumeLayout(false);
            this.gbTaskStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.gbData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPrdData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDbtrType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblDbtrID;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.RadioButton rbByIDNo;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtSrchIn;
        private System.Windows.Forms.Label lblEntNo;
        private System.Windows.Forms.GroupBox gbTaskStat;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbDbtrType;
        private System.Windows.Forms.RadioButton rbSupplier;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.GroupBox gbDbtType;
        private System.Windows.Forms.RadioButton rbTake;
        private System.Windows.Forms.RadioButton rbGive;
        private System.Windows.Forms.Label lblDbtType;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDbtrID;
        private System.Windows.Forms.GroupBox gbSrchDbtrType;
        private System.Windows.Forms.RadioButton rbSrchSup;
        private System.Windows.Forms.RadioButton rbSrchCust;
    }
}