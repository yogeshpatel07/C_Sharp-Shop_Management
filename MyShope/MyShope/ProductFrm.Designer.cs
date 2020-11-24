namespace MyShope
{
    partial class ProductFrm
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
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrise = new System.Windows.Forms.Label();
            this.gbPrdData = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.lblPrdName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtPrise = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lblPrdId = new System.Windows.Forms.Label();
            this.gbTaskStat = new System.Windows.Forms.GroupBox();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbPrdID = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtPrdID = new System.Windows.Forms.TextBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbPrdData.SuspendLayout();
            this.gbTaskStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.gbSearchBy.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Purple;
            this.lblUnit.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Yellow;
            this.lblUnit.Location = new System.Drawing.Point(12, 108);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(346, 32);
            this.lblUnit.TabIndex = 12;
            this.lblUnit.Text = "Enter The Unit                        :";
            // 
            // lblPrise
            // 
            this.lblPrise.AutoSize = true;
            this.lblPrise.BackColor = System.Drawing.Color.Purple;
            this.lblPrise.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrise.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrise.Location = new System.Drawing.Point(12, 66);
            this.lblPrise.Name = "lblPrise";
            this.lblPrise.Size = new System.Drawing.Size(345, 32);
            this.lblPrise.TabIndex = 10;
            this.lblPrise.Text = "Enter The Minimum Price :";
            // 
            // gbPrdData
            // 
            this.gbPrdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrdData.BackColor = System.Drawing.Color.Purple;
            this.gbPrdData.Controls.Add(this.txtType);
            this.gbPrdData.Controls.Add(this.lblType);
            this.gbPrdData.Controls.Add(this.btnRefresh);
            this.gbPrdData.Controls.Add(this.txtPrdName);
            this.gbPrdData.Controls.Add(this.lblPrdName);
            this.gbPrdData.Controls.Add(this.btnSave);
            this.gbPrdData.Controls.Add(this.btnEdit);
            this.gbPrdData.Controls.Add(this.btnDelete);
            this.gbPrdData.Controls.Add(this.btnNew);
            this.gbPrdData.Controls.Add(this.txtDesc);
            this.gbPrdData.Controls.Add(this.lblDesc);
            this.gbPrdData.Controls.Add(this.txtUnit);
            this.gbPrdData.Controls.Add(this.lblUnit);
            this.gbPrdData.Controls.Add(this.txtPrise);
            this.gbPrdData.Controls.Add(this.lblPrise);
            this.gbPrdData.Location = new System.Drawing.Point(12, 297);
            this.gbPrdData.Name = "gbPrdData";
            this.gbPrdData.Size = new System.Drawing.Size(1320, 327);
            this.gbPrdData.TabIndex = 0;
            this.gbPrdData.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.BackColor = System.Drawing.SystemColors.Control;
            this.txtType.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtType.Location = new System.Drawing.Point(420, 150);
            this.txtType.MaxLength = 50;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(889, 36);
            this.txtType.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Purple;
            this.lblType.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Yellow;
            this.lblType.Location = new System.Drawing.Point(12, 150);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(345, 32);
            this.lblType.TabIndex = 41;
            this.lblType.Text = "Enter The Product Type     :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(1050, 271);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPrdName
            // 
            this.txtPrdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrdName.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrdName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrdName.Location = new System.Drawing.Point(420, 24);
            this.txtPrdName.MaxLength = 50;
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.Size = new System.Drawing.Size(889, 36);
            this.txtPrdName.TabIndex = 1;
            // 
            // lblPrdName
            // 
            this.lblPrdName.AutoSize = true;
            this.lblPrdName.BackColor = System.Drawing.Color.Purple;
            this.lblPrdName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdName.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdName.Location = new System.Drawing.Point(12, 24);
            this.lblPrdName.Name = "lblPrdName";
            this.lblPrdName.Size = new System.Drawing.Size(343, 32);
            this.lblPrdName.TabIndex = 38;
            this.lblPrdName.Text = "Enter The Product Name   :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(850, 271);
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
            this.btnEdit.Location = new System.Drawing.Point(450, 271);
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
            this.btnDelete.Location = new System.Drawing.Point(650, 271);
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
            this.btnNew.Location = new System.Drawing.Point(250, 271);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(137, 40);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.SystemColors.Control;
            this.txtDesc.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Location = new System.Drawing.Point(420, 192);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(889, 73);
            this.txtDesc.TabIndex = 5;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Purple;
            this.lblDesc.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Yellow;
            this.lblDesc.Location = new System.Drawing.Point(12, 192);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(347, 32);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "Enter The Description         :";
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnit.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUnit.Location = new System.Drawing.Point(420, 108);
            this.txtUnit.MaxLength = 30;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(889, 36);
            this.txtUnit.TabIndex = 3;
            // 
            // txtPrise
            // 
            this.txtPrise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrise.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrise.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrise.Location = new System.Drawing.Point(420, 66);
            this.txtPrise.MaxLength = 20;
            this.txtPrise.Name = "txtPrise";
            this.txtPrise.Size = new System.Drawing.Size(889, 36);
            this.txtPrise.TabIndex = 2;
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
            // lblPrdId
            // 
            this.lblPrdId.AutoSize = true;
            this.lblPrdId.BackColor = System.Drawing.Color.Purple;
            this.lblPrdId.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdId.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdId.Location = new System.Drawing.Point(414, 44);
            this.lblPrdId.Name = "lblPrdId";
            this.lblPrdId.Size = new System.Drawing.Size(236, 32);
            this.lblPrdId.TabIndex = 14;
            this.lblPrdId.Text = "Enter Product ID :";
            // 
            // gbTaskStat
            // 
            this.gbTaskStat.BackColor = System.Drawing.Color.Purple;
            this.gbTaskStat.Controls.Add(this.rbType);
            this.gbTaskStat.Controls.Add(this.rbName);
            this.gbTaskStat.Controls.Add(this.rbPrdID);
            this.gbTaskStat.Controls.Add(this.rbAll);
            this.gbTaskStat.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaskStat.ForeColor = System.Drawing.Color.Yellow;
            this.gbTaskStat.Location = new System.Drawing.Point(17, 38);
            this.gbTaskStat.Name = "gbTaskStat";
            this.gbTaskStat.Size = new System.Drawing.Size(383, 43);
            this.gbTaskStat.TabIndex = 0;
            this.gbTaskStat.TabStop = false;
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.BackColor = System.Drawing.Color.Purple;
            this.rbType.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbType.ForeColor = System.Drawing.Color.Yellow;
            this.rbType.Location = new System.Drawing.Point(159, 10);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(77, 29);
            this.rbType.TabIndex = 2;
            this.rbType.Text = "Type";
            this.rbType.UseVisualStyleBackColor = false;
            this.rbType.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.BackColor = System.Drawing.Color.Purple;
            this.rbName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.ForeColor = System.Drawing.Color.Yellow;
            this.rbName.Location = new System.Drawing.Point(68, 8);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(85, 29);
            this.rbName.TabIndex = 1;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = false;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbPrdID
            // 
            this.rbPrdID.AutoSize = true;
            this.rbPrdID.BackColor = System.Drawing.Color.Purple;
            this.rbPrdID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrdID.ForeColor = System.Drawing.Color.Yellow;
            this.rbPrdID.Location = new System.Drawing.Point(242, 9);
            this.rbPrdID.Name = "rbPrdID";
            this.rbPrdID.Size = new System.Drawing.Size(136, 29);
            this.rbPrdID.TabIndex = 3;
            this.rbPrdID.Text = "Product ID";
            this.rbPrdID.UseVisualStyleBackColor = false;
            this.rbPrdID.CheckedChanged += new System.EventHandler(this.rbPrdID_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Green;
            this.btnShow.Location = new System.Drawing.Point(911, 43);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 40);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtPrdID
            // 
            this.txtPrdID.BackColor = System.Drawing.Color.White;
            this.txtPrdID.Enabled = false;
            this.txtPrdID.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrdID.Location = new System.Drawing.Point(711, 43);
            this.txtPrdID.Name = "txtPrdID";
            this.txtPrdID.Size = new System.Drawing.Size(182, 36);
            this.txtPrdID.TabIndex = 1;
            this.txtPrdID.EnabledChanged += new System.EventHandler(this.txtPrdID_EnabledChanged);
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
            this.dGView.Size = new System.Drawing.Size(1314, 164);
            this.dGView.TabIndex = 0;
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchBy.BackColor = System.Drawing.Color.Purple;
            this.gbSearchBy.Controls.Add(this.btnShow);
            this.gbSearchBy.Controls.Add(this.txtPrdID);
            this.gbSearchBy.Controls.Add(this.lblPrdId);
            this.gbSearchBy.Controls.Add(this.gbTaskStat);
            this.gbSearchBy.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchBy.ForeColor = System.Drawing.Color.Yellow;
            this.gbSearchBy.Location = new System.Drawing.Point(12, 196);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(1320, 95);
            this.gbSearchBy.TabIndex = 1;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
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
            this.gbData.Size = new System.Drawing.Size(1320, 189);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            // 
            // ProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1344, 636);
            this.Controls.Add(this.gbPrdData);
            this.Controls.Add(this.gbSearchBy);
            this.Controls.Add(this.gbData);
            this.Name = "ProductFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductFrm_FormClosed);
            this.Load += new System.EventHandler(this.ProductFrm_Load);
            this.gbPrdData.ResumeLayout(false);
            this.gbPrdData.PerformLayout();
            this.gbTaskStat.ResumeLayout(false);
            this.gbTaskStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrise;
        private System.Windows.Forms.GroupBox gbPrdData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtPrise;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lblPrdId;
        private System.Windows.Forms.GroupBox gbTaskStat;
        private System.Windows.Forms.RadioButton rbPrdID;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtPrdID;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtPrdName;
        private System.Windows.Forms.Label lblPrdName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.RadioButton rbName;
    }
}