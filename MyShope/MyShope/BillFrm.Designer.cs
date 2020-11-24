namespace MyShope
{
    partial class BillFrm
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
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtSrchIn = new System.Windows.Forms.TextBox();
            this.lblEntNo = new System.Windows.Forms.Label();
            this.gbTaskStat = new System.Windows.Forms.GroupBox();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.rbByBillNo = new System.Windows.Forms.RadioButton();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.gbSrchDbtrType = new System.Windows.Forms.GroupBox();
            this.rbPrdDet = new System.Windows.Forms.RadioButton();
            this.rbCstDet = new System.Windows.Forms.RadioButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbPrdData = new System.Windows.Forms.GroupBox();
            this.gbPrdDet = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPrdPrise = new System.Windows.Forms.ListBox();
            this.lstPrdQnt = new System.Windows.Forms.ListBox();
            this.lstPrdName = new System.Windows.Forms.ListBox();
            this.lstPrdID = new System.Windows.Forms.ListBox();
            this.cmbPrdID = new System.Windows.Forms.ComboBox();
            this.txtPrdPrise = new System.Windows.Forms.TextBox();
            this.txtPrdQnt = new System.Windows.Forms.TextBox();
            this.lblPrdID = new System.Windows.Forms.Label();
            this.lblPrdPrise = new System.Windows.Forms.Label();
            this.lblPrdQnt = new System.Windows.Forms.Label();
            this.gbCstDet = new System.Windows.Forms.GroupBox();
            this.cmbCstID = new System.Windows.Forms.ComboBox();
            this.lblCstID = new System.Windows.Forms.Label();
            this.gbNewCst = new System.Windows.Forms.GroupBox();
            this.txtCstAddress = new System.Windows.Forms.TextBox();
            this.lblCstAddress = new System.Windows.Forms.Label();
            this.txtCstEmail = new System.Windows.Forms.TextBox();
            this.txtCstName = new System.Windows.Forms.TextBox();
            this.txtCstMobNo = new System.Windows.Forms.TextBox();
            this.lblCstName = new System.Windows.Forms.Label();
            this.lblCstEmail = new System.Windows.Forms.Label();
            this.lblCstMobNo = new System.Windows.Forms.Label();
            this.gbBtnCstType = new System.Windows.Forms.GroupBox();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbExist = new System.Windows.Forms.RadioButton();
            this.lblCstType = new System.Windows.Forms.Label();
            this.gbTaskStat.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            this.gbSrchDbtrType.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.gbPrdData.SuspendLayout();
            this.gbPrdDet.SuspendLayout();
            this.gbCstDet.SuspendLayout();
            this.gbNewCst.SuspendLayout();
            this.gbBtnCstType.SuspendLayout();
            this.SuspendLayout();
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
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(823, 228);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 40);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(623, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 40);
            this.btnSave.TabIndex = 5;
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
            this.btnEdit.Location = new System.Drawing.Point(223, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Green;
            this.btnShow.Location = new System.Drawing.Point(1034, 41);
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
            this.txtSrchIn.Location = new System.Drawing.Point(918, 44);
            this.txtSrchIn.MaxLength = 10;
            this.txtSrchIn.Name = "txtSrchIn";
            this.txtSrchIn.Size = new System.Drawing.Size(110, 36);
            this.txtSrchIn.TabIndex = 2;
            this.txtSrchIn.EnabledChanged += new System.EventHandler(this.txtSrchIn_EnabledChanged);
            // 
            // lblEntNo
            // 
            this.lblEntNo.AutoSize = true;
            this.lblEntNo.BackColor = System.Drawing.Color.Purple;
            this.lblEntNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblEntNo.Location = new System.Drawing.Point(620, 43);
            this.lblEntNo.Name = "lblEntNo";
            this.lblEntNo.Size = new System.Drawing.Size(285, 32);
            this.lblEntNo.TabIndex = 14;
            this.lblEntNo.Text = "Enter Cutomer Name :";
            // 
            // gbTaskStat
            // 
            this.gbTaskStat.BackColor = System.Drawing.Color.Purple;
            this.gbTaskStat.Controls.Add(this.rbByName);
            this.gbTaskStat.Controls.Add(this.rbByBillNo);
            this.gbTaskStat.Controls.Add(this.rbAll);
            this.gbTaskStat.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaskStat.ForeColor = System.Drawing.Color.Yellow;
            this.gbTaskStat.Location = new System.Drawing.Point(23, 38);
            this.gbTaskStat.Name = "gbTaskStat";
            this.gbTaskStat.Size = new System.Drawing.Size(322, 43);
            this.gbTaskStat.TabIndex = 0;
            this.gbTaskStat.TabStop = false;
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
            // rbByBillNo
            // 
            this.rbByBillNo.AutoSize = true;
            this.rbByBillNo.BackColor = System.Drawing.Color.Purple;
            this.rbByBillNo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByBillNo.ForeColor = System.Drawing.Color.Yellow;
            this.rbByBillNo.Location = new System.Drawing.Point(189, 9);
            this.rbByBillNo.Name = "rbByBillNo";
            this.rbByBillNo.Size = new System.Drawing.Size(129, 29);
            this.rbByBillNo.TabIndex = 2;
            this.rbByBillNo.Text = "By Bill No.";
            this.rbByBillNo.UseVisualStyleBackColor = false;
            this.rbByBillNo.CheckedChanged += new System.EventHandler(this.rbByBillNo_CheckedChanged);
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchBy.BackColor = System.Drawing.Color.Purple;
            this.gbSearchBy.Controls.Add(this.btnPrintBill);
            this.gbSearchBy.Controls.Add(this.gbSrchDbtrType);
            this.gbSearchBy.Controls.Add(this.btnShow);
            this.gbSearchBy.Controls.Add(this.txtSrchIn);
            this.gbSearchBy.Controls.Add(this.lblEntNo);
            this.gbSearchBy.Controls.Add(this.gbTaskStat);
            this.gbSearchBy.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchBy.ForeColor = System.Drawing.Color.Yellow;
            this.gbSearchBy.Location = new System.Drawing.Point(12, 233);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(1320, 95);
            this.gbSearchBy.TabIndex = 1;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Enabled = false;
            this.btnPrintBill.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.Green;
            this.btnPrintBill.Location = new System.Drawing.Point(1161, 41);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(146, 40);
            this.btnPrintBill.TabIndex = 4;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // gbSrchDbtrType
            // 
            this.gbSrchDbtrType.BackColor = System.Drawing.Color.Purple;
            this.gbSrchDbtrType.Controls.Add(this.rbPrdDet);
            this.gbSrchDbtrType.Controls.Add(this.rbCstDet);
            this.gbSrchDbtrType.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSrchDbtrType.ForeColor = System.Drawing.Color.Yellow;
            this.gbSrchDbtrType.Location = new System.Drawing.Point(351, 38);
            this.gbSrchDbtrType.Name = "gbSrchDbtrType";
            this.gbSrchDbtrType.Size = new System.Drawing.Size(263, 43);
            this.gbSrchDbtrType.TabIndex = 1;
            this.gbSrchDbtrType.TabStop = false;
            // 
            // rbPrdDet
            // 
            this.rbPrdDet.AutoSize = true;
            this.rbPrdDet.BackColor = System.Drawing.Color.Purple;
            this.rbPrdDet.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrdDet.ForeColor = System.Drawing.Color.Yellow;
            this.rbPrdDet.Location = new System.Drawing.Point(137, 10);
            this.rbPrdDet.Name = "rbPrdDet";
            this.rbPrdDet.Size = new System.Drawing.Size(119, 29);
            this.rbPrdDet.TabIndex = 1;
            this.rbPrdDet.Text = "Products";
            this.rbPrdDet.UseVisualStyleBackColor = false;
            // 
            // rbCstDet
            // 
            this.rbCstDet.AutoSize = true;
            this.rbCstDet.BackColor = System.Drawing.Color.Purple;
            this.rbCstDet.Checked = true;
            this.rbCstDet.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCstDet.ForeColor = System.Drawing.Color.Yellow;
            this.rbCstDet.Location = new System.Drawing.Point(6, 9);
            this.rbCstDet.Name = "rbCstDet";
            this.rbCstDet.Size = new System.Drawing.Size(125, 29);
            this.rbCstDet.TabIndex = 0;
            this.rbCstDet.TabStop = true;
            this.rbCstDet.Text = "Customer";
            this.rbCstDet.UseVisualStyleBackColor = false;
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
            this.gbData.Size = new System.Drawing.Size(1320, 218);
            this.gbData.TabIndex = 2;
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
            this.dGView.Size = new System.Drawing.Size(1314, 193);
            this.dGView.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(423, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNew.Location = new System.Drawing.Point(23, 228);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(137, 40);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbPrdData
            // 
            this.gbPrdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrdData.BackColor = System.Drawing.Color.Purple;
            this.gbPrdData.Controls.Add(this.gbPrdDet);
            this.gbPrdData.Controls.Add(this.gbCstDet);
            this.gbPrdData.Controls.Add(this.btnRefresh);
            this.gbPrdData.Controls.Add(this.btnSave);
            this.gbPrdData.Controls.Add(this.btnEdit);
            this.gbPrdData.Controls.Add(this.btnDelete);
            this.gbPrdData.Controls.Add(this.btnNew);
            this.gbPrdData.Location = new System.Drawing.Point(12, 334);
            this.gbPrdData.Name = "gbPrdData";
            this.gbPrdData.Size = new System.Drawing.Size(1320, 290);
            this.gbPrdData.TabIndex = 0;
            this.gbPrdData.TabStop = false;
            // 
            // gbPrdDet
            // 
            this.gbPrdDet.Controls.Add(this.txtIndex);
            this.gbPrdDet.Controls.Add(this.lblIndex);
            this.gbPrdDet.Controls.Add(this.btnRemove);
            this.gbPrdDet.Controls.Add(this.btnRemoveAll);
            this.gbPrdDet.Controls.Add(this.btnAdd);
            this.gbPrdDet.Controls.Add(this.lstPrdPrise);
            this.gbPrdDet.Controls.Add(this.lstPrdQnt);
            this.gbPrdDet.Controls.Add(this.lstPrdName);
            this.gbPrdDet.Controls.Add(this.lstPrdID);
            this.gbPrdDet.Controls.Add(this.cmbPrdID);
            this.gbPrdDet.Controls.Add(this.txtPrdPrise);
            this.gbPrdDet.Controls.Add(this.txtPrdQnt);
            this.gbPrdDet.Controls.Add(this.lblPrdID);
            this.gbPrdDet.Controls.Add(this.lblPrdPrise);
            this.gbPrdDet.Controls.Add(this.lblPrdQnt);
            this.gbPrdDet.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrdDet.ForeColor = System.Drawing.Color.Yellow;
            this.gbPrdDet.Location = new System.Drawing.Point(668, 19);
            this.gbPrdDet.Name = "gbPrdDet";
            this.gbPrdDet.Size = new System.Drawing.Size(639, 203);
            this.gbPrdDet.TabIndex = 1;
            this.gbPrdDet.TabStop = false;
            this.gbPrdDet.Text = "Product Details";
            // 
            // txtIndex
            // 
            this.txtIndex.BackColor = System.Drawing.SystemColors.Control;
            this.txtIndex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIndex.Location = new System.Drawing.Point(411, 156);
            this.txtIndex.MaxLength = 50;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(50, 30);
            this.txtIndex.TabIndex = 5;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.BackColor = System.Drawing.Color.Purple;
            this.lblIndex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.Color.Yellow;
            this.lblIndex.Location = new System.Drawing.Point(305, 159);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(100, 22);
            this.lblIndex.TabIndex = 69;
            this.lblIndex.Text = "Index No. :";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Green;
            this.btnRemove.Location = new System.Drawing.Point(467, 148);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.Green;
            this.btnRemoveAll.Location = new System.Drawing.Point(150, 148);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(149, 40);
            this.btnRemoveAll.TabIndex = 4;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(16, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPrdPrise
            // 
            this.lstPrdPrise.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrdPrise.FormattingEnabled = true;
            this.lstPrdPrise.ItemHeight = 19;
            this.lstPrdPrise.Location = new System.Drawing.Point(541, 29);
            this.lstPrdPrise.Name = "lstPrdPrise";
            this.lstPrdPrise.Size = new System.Drawing.Size(91, 99);
            this.lstPrdPrise.TabIndex = 10;
            // 
            // lstPrdQnt
            // 
            this.lstPrdQnt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrdQnt.FormattingEnabled = true;
            this.lstPrdQnt.ItemHeight = 19;
            this.lstPrdQnt.Location = new System.Drawing.Point(444, 29);
            this.lstPrdQnt.Name = "lstPrdQnt";
            this.lstPrdQnt.Size = new System.Drawing.Size(91, 99);
            this.lstPrdQnt.TabIndex = 9;
            // 
            // lstPrdName
            // 
            this.lstPrdName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrdName.FormattingEnabled = true;
            this.lstPrdName.ItemHeight = 19;
            this.lstPrdName.Location = new System.Drawing.Point(347, 30);
            this.lstPrdName.Name = "lstPrdName";
            this.lstPrdName.Size = new System.Drawing.Size(91, 99);
            this.lstPrdName.TabIndex = 8;
            // 
            // lstPrdID
            // 
            this.lstPrdID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrdID.FormattingEnabled = true;
            this.lstPrdID.ItemHeight = 19;
            this.lstPrdID.Location = new System.Drawing.Point(250, 29);
            this.lstPrdID.Name = "lstPrdID";
            this.lstPrdID.Size = new System.Drawing.Size(91, 99);
            this.lstPrdID.TabIndex = 7;
            // 
            // cmbPrdID
            // 
            this.cmbPrdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrdID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrdID.FormattingEnabled = true;
            this.cmbPrdID.Location = new System.Drawing.Point(113, 29);
            this.cmbPrdID.Name = "cmbPrdID";
            this.cmbPrdID.Size = new System.Drawing.Size(131, 30);
            this.cmbPrdID.TabIndex = 0;
            this.cmbPrdID.SelectedIndexChanged += new System.EventHandler(this.cmbPrdID_SelectedIndexChanged);
            // 
            // txtPrdPrise
            // 
            this.txtPrdPrise.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrdPrise.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdPrise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrdPrise.Location = new System.Drawing.Point(113, 101);
            this.txtPrdPrise.MaxLength = 50;
            this.txtPrdPrise.Name = "txtPrdPrise";
            this.txtPrdPrise.Size = new System.Drawing.Size(131, 30);
            this.txtPrdPrise.TabIndex = 2;
            // 
            // txtPrdQnt
            // 
            this.txtPrdQnt.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrdQnt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdQnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrdQnt.Location = new System.Drawing.Point(113, 65);
            this.txtPrdQnt.MaxLength = 15;
            this.txtPrdQnt.Name = "txtPrdQnt";
            this.txtPrdQnt.Size = new System.Drawing.Size(131, 30);
            this.txtPrdQnt.TabIndex = 1;
            // 
            // lblPrdID
            // 
            this.lblPrdID.AutoSize = true;
            this.lblPrdID.BackColor = System.Drawing.Color.Purple;
            this.lblPrdID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdID.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdID.Location = new System.Drawing.Point(12, 33);
            this.lblPrdID.Name = "lblPrdID";
            this.lblPrdID.Size = new System.Drawing.Size(95, 22);
            this.lblPrdID.TabIndex = 58;
            this.lblPrdID.Text = "ID               :";
            // 
            // lblPrdPrise
            // 
            this.lblPrdPrise.AutoSize = true;
            this.lblPrdPrise.BackColor = System.Drawing.Color.Purple;
            this.lblPrdPrise.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdPrise.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdPrise.Location = new System.Drawing.Point(12, 104);
            this.lblPrdPrise.Name = "lblPrdPrise";
            this.lblPrdPrise.Size = new System.Drawing.Size(93, 22);
            this.lblPrdPrise.TabIndex = 57;
            this.lblPrdPrise.Text = "Price        :";
            // 
            // lblPrdQnt
            // 
            this.lblPrdQnt.AutoSize = true;
            this.lblPrdQnt.BackColor = System.Drawing.Color.Purple;
            this.lblPrdQnt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdQnt.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrdQnt.Location = new System.Drawing.Point(12, 68);
            this.lblPrdQnt.Name = "lblPrdQnt";
            this.lblPrdQnt.Size = new System.Drawing.Size(94, 22);
            this.lblPrdQnt.TabIndex = 56;
            this.lblPrdQnt.Text = "Quantity :";
            // 
            // gbCstDet
            // 
            this.gbCstDet.Controls.Add(this.cmbCstID);
            this.gbCstDet.Controls.Add(this.lblCstID);
            this.gbCstDet.Controls.Add(this.gbNewCst);
            this.gbCstDet.Controls.Add(this.gbBtnCstType);
            this.gbCstDet.Controls.Add(this.lblCstType);
            this.gbCstDet.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCstDet.ForeColor = System.Drawing.Color.Yellow;
            this.gbCstDet.Location = new System.Drawing.Point(23, 19);
            this.gbCstDet.Name = "gbCstDet";
            this.gbCstDet.Size = new System.Drawing.Size(639, 203);
            this.gbCstDet.TabIndex = 0;
            this.gbCstDet.TabStop = false;
            this.gbCstDet.Text = "Customer Details";
            // 
            // cmbCstID
            // 
            this.cmbCstID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCstID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCstID.FormattingEnabled = true;
            this.cmbCstID.Location = new System.Drawing.Point(502, 29);
            this.cmbCstID.Name = "cmbCstID";
            this.cmbCstID.Size = new System.Drawing.Size(131, 30);
            this.cmbCstID.TabIndex = 1;
            this.cmbCstID.SelectedIndexChanged += new System.EventHandler(this.cmbCstID_SelectedIndexChanged);
            // 
            // lblCstID
            // 
            this.lblCstID.AutoSize = true;
            this.lblCstID.BackColor = System.Drawing.Color.Purple;
            this.lblCstID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCstID.ForeColor = System.Drawing.Color.Yellow;
            this.lblCstID.Location = new System.Drawing.Point(368, 32);
            this.lblCstID.Name = "lblCstID";
            this.lblCstID.Size = new System.Drawing.Size(128, 22);
            this.lblCstID.TabIndex = 52;
            this.lblCstID.Text = "Customer ID :";
            // 
            // gbNewCst
            // 
            this.gbNewCst.Controls.Add(this.txtCstAddress);
            this.gbNewCst.Controls.Add(this.lblCstAddress);
            this.gbNewCst.Controls.Add(this.txtCstEmail);
            this.gbNewCst.Controls.Add(this.txtCstName);
            this.gbNewCst.Controls.Add(this.txtCstMobNo);
            this.gbNewCst.Controls.Add(this.lblCstName);
            this.gbNewCst.Controls.Add(this.lblCstEmail);
            this.gbNewCst.Controls.Add(this.lblCstMobNo);
            this.gbNewCst.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewCst.ForeColor = System.Drawing.Color.Yellow;
            this.gbNewCst.Location = new System.Drawing.Point(0, 67);
            this.gbNewCst.Name = "gbNewCst";
            this.gbNewCst.Size = new System.Drawing.Size(639, 136);
            this.gbNewCst.TabIndex = 2;
            this.gbNewCst.TabStop = false;
            this.gbNewCst.Text = "New Customer Details";
            // 
            // txtCstAddress
            // 
            this.txtCstAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCstAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtCstAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCstAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCstAddress.Location = new System.Drawing.Point(373, 60);
            this.txtCstAddress.Multiline = true;
            this.txtCstAddress.Name = "txtCstAddress";
            this.txtCstAddress.Size = new System.Drawing.Size(260, 68);
            this.txtCstAddress.TabIndex = 3;
            // 
            // lblCstAddress
            // 
            this.lblCstAddress.AutoSize = true;
            this.lblCstAddress.BackColor = System.Drawing.Color.Purple;
            this.lblCstAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCstAddress.ForeColor = System.Drawing.Color.Yellow;
            this.lblCstAddress.Location = new System.Drawing.Point(369, 28);
            this.lblCstAddress.Name = "lblCstAddress";
            this.lblCstAddress.Size = new System.Drawing.Size(90, 22);
            this.lblCstAddress.TabIndex = 46;
            this.lblCstAddress.Text = "Address :";
            // 
            // txtCstEmail
            // 
            this.txtCstEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtCstEmail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCstEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCstEmail.Location = new System.Drawing.Point(163, 96);
            this.txtCstEmail.MaxLength = 50;
            this.txtCstEmail.Name = "txtCstEmail";
            this.txtCstEmail.Size = new System.Drawing.Size(185, 30);
            this.txtCstEmail.TabIndex = 2;
            // 
            // txtCstName
            // 
            this.txtCstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCstName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCstName.Location = new System.Drawing.Point(163, 25);
            this.txtCstName.MaxLength = 50;
            this.txtCstName.Name = "txtCstName";
            this.txtCstName.Size = new System.Drawing.Size(185, 30);
            this.txtCstName.TabIndex = 0;
            // 
            // txtCstMobNo
            // 
            this.txtCstMobNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCstMobNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCstMobNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCstMobNo.Location = new System.Drawing.Point(163, 60);
            this.txtCstMobNo.MaxLength = 15;
            this.txtCstMobNo.Name = "txtCstMobNo";
            this.txtCstMobNo.Size = new System.Drawing.Size(185, 30);
            this.txtCstMobNo.TabIndex = 1;
            // 
            // lblCstName
            // 
            this.lblCstName.AutoSize = true;
            this.lblCstName.BackColor = System.Drawing.Color.Purple;
            this.lblCstName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCstName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCstName.Location = new System.Drawing.Point(7, 28);
            this.lblCstName.Name = "lblCstName";
            this.lblCstName.Size = new System.Drawing.Size(93, 22);
            this.lblCstName.TabIndex = 41;
            this.lblCstName.Text = "Name       :";
            // 
            // lblCstEmail
            // 
            this.lblCstEmail.AutoSize = true;
            this.lblCstEmail.BackColor = System.Drawing.Color.Purple;
            this.lblCstEmail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCstEmail.ForeColor = System.Drawing.Color.Yellow;
            this.lblCstEmail.Location = new System.Drawing.Point(7, 99);
            this.lblCstEmail.Name = "lblCstEmail";
            this.lblCstEmail.Size = new System.Drawing.Size(93, 22);
            this.lblCstEmail.TabIndex = 40;
            this.lblCstEmail.Text = "Email       :";
            // 
            // lblCstMobNo
            // 
            this.lblCstMobNo.AutoSize = true;
            this.lblCstMobNo.BackColor = System.Drawing.Color.Purple;
            this.lblCstMobNo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCstMobNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblCstMobNo.Location = new System.Drawing.Point(7, 63);
            this.lblCstMobNo.Name = "lblCstMobNo";
            this.lblCstMobNo.Size = new System.Drawing.Size(93, 22);
            this.lblCstMobNo.TabIndex = 39;
            this.lblCstMobNo.Text = "Mob. No. :";
            // 
            // gbBtnCstType
            // 
            this.gbBtnCstType.BackColor = System.Drawing.Color.Purple;
            this.gbBtnCstType.Controls.Add(this.rbNew);
            this.gbBtnCstType.Controls.Add(this.rbExist);
            this.gbBtnCstType.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBtnCstType.ForeColor = System.Drawing.Color.Yellow;
            this.gbBtnCstType.Location = new System.Drawing.Point(163, 21);
            this.gbBtnCstType.Name = "gbBtnCstType";
            this.gbBtnCstType.Size = new System.Drawing.Size(199, 40);
            this.gbBtnCstType.TabIndex = 0;
            this.gbBtnCstType.TabStop = false;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.BackColor = System.Drawing.Color.Purple;
            this.rbNew.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNew.ForeColor = System.Drawing.Color.Yellow;
            this.rbNew.Location = new System.Drawing.Point(121, 9);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(66, 26);
            this.rbNew.TabIndex = 1;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = false;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbExist
            // 
            this.rbExist.AutoSize = true;
            this.rbExist.BackColor = System.Drawing.Color.Purple;
            this.rbExist.Checked = true;
            this.rbExist.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExist.ForeColor = System.Drawing.Color.Yellow;
            this.rbExist.Location = new System.Drawing.Point(6, 9);
            this.rbExist.Name = "rbExist";
            this.rbExist.Size = new System.Drawing.Size(98, 26);
            this.rbExist.TabIndex = 0;
            this.rbExist.TabStop = true;
            this.rbExist.Text = "Existing";
            this.rbExist.UseVisualStyleBackColor = false;
            this.rbExist.CheckedChanged += new System.EventHandler(this.rbExist_CheckedChanged);
            // 
            // lblCstType
            // 
            this.lblCstType.AutoSize = true;
            this.lblCstType.BackColor = System.Drawing.Color.Purple;
            this.lblCstType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCstType.ForeColor = System.Drawing.Color.Yellow;
            this.lblCstType.Location = new System.Drawing.Point(6, 32);
            this.lblCstType.Name = "lblCstType";
            this.lblCstType.Size = new System.Drawing.Size(151, 22);
            this.lblCstType.TabIndex = 48;
            this.lblCstType.Text = "Customer Type :";
            // 
            // BillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1344, 636);
            this.Controls.Add(this.gbSearchBy);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbPrdData);
            this.Name = "BillFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillFrm_FormClosed);
            this.Load += new System.EventHandler(this.BillFrm_Load);
            this.gbTaskStat.ResumeLayout(false);
            this.gbTaskStat.PerformLayout();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            this.gbSrchDbtrType.ResumeLayout(false);
            this.gbSrchDbtrType.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.gbPrdData.ResumeLayout(false);
            this.gbPrdDet.ResumeLayout(false);
            this.gbPrdDet.PerformLayout();
            this.gbCstDet.ResumeLayout(false);
            this.gbCstDet.PerformLayout();
            this.gbNewCst.ResumeLayout(false);
            this.gbNewCst.PerformLayout();
            this.gbBtnCstType.ResumeLayout(false);
            this.gbBtnCstType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtSrchIn;
        private System.Windows.Forms.Label lblEntNo;
        private System.Windows.Forms.GroupBox gbTaskStat;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.RadioButton rbByBillNo;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbPrdData;
        private System.Windows.Forms.GroupBox gbSrchDbtrType;
        private System.Windows.Forms.RadioButton rbPrdDet;
        private System.Windows.Forms.RadioButton rbCstDet;
        private System.Windows.Forms.GroupBox gbCstDet;
        private System.Windows.Forms.GroupBox gbBtnCstType;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbExist;
        private System.Windows.Forms.Label lblCstType;
        private System.Windows.Forms.GroupBox gbNewCst;
        private System.Windows.Forms.Label lblCstID;
        private System.Windows.Forms.ComboBox cmbCstID;
        private System.Windows.Forms.Label lblCstName;
        private System.Windows.Forms.Label lblCstEmail;
        private System.Windows.Forms.Label lblCstMobNo;
        private System.Windows.Forms.TextBox txtCstEmail;
        private System.Windows.Forms.TextBox txtCstName;
        private System.Windows.Forms.TextBox txtCstMobNo;
        private System.Windows.Forms.TextBox txtCstAddress;
        private System.Windows.Forms.Label lblCstAddress;
        private System.Windows.Forms.GroupBox gbPrdDet;
        private System.Windows.Forms.ListBox lstPrdQnt;
        private System.Windows.Forms.ListBox lstPrdName;
        private System.Windows.Forms.ListBox lstPrdID;
        private System.Windows.Forms.ComboBox cmbPrdID;
        private System.Windows.Forms.TextBox txtPrdPrise;
        private System.Windows.Forms.TextBox txtPrdQnt;
        private System.Windows.Forms.Label lblPrdID;
        private System.Windows.Forms.Label lblPrdPrise;
        private System.Windows.Forms.Label lblPrdQnt;
        private System.Windows.Forms.ListBox lstPrdPrise;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrintBill;
    }
}