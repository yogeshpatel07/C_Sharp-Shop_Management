namespace MyShope
{
    partial class BillRepFrm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PrdTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new MyShope.DataSet1();
            this.repView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtBlNo = new System.Windows.Forms.TextBox();
            this.lblBlNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrdTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrdTableBindingSource
            // 
            this.PrdTableBindingSource.DataMember = "PrdTable";
            this.PrdTableBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repView
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrdTableBindingSource;
            this.repView.LocalReport.DataSources.Add(reportDataSource1);
            this.repView.LocalReport.ReportEmbeddedResource = "MyShope.BillRepPrint.rdlc";
            this.repView.Location = new System.Drawing.Point(12, 60);
            this.repView.Name = "repView";
            this.repView.Size = new System.Drawing.Size(644, 509);
            this.repView.TabIndex = 5;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(443, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(213, 42);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload Bill";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtBlNo
            // 
            this.txtBlNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlNo.Location = new System.Drawing.Point(253, 13);
            this.txtBlNo.Name = "txtBlNo";
            this.txtBlNo.Size = new System.Drawing.Size(184, 39);
            this.txtBlNo.TabIndex = 7;
            // 
            // lblBlNo
            // 
            this.lblBlNo.AutoSize = true;
            this.lblBlNo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlNo.Location = new System.Drawing.Point(12, 15);
            this.lblBlNo.Name = "lblBlNo";
            this.lblBlNo.Size = new System.Drawing.Size(236, 32);
            this.lblBlNo.TabIndex = 8;
            this.lblBlNo.Text = "Enter the Bill No : ";
            // 
            // BillRepFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 581);
            this.Controls.Add(this.lblBlNo);
            this.Controls.Add(this.txtBlNo);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.repView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(684, 620);
            this.MinimumSize = new System.Drawing.Size(684, 620);
            this.Name = "BillRepFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Bill";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillRepFrm_FormClosed);
            this.Load += new System.EventHandler(this.BillRepFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrdTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer repView;
        private System.Windows.Forms.BindingSource PrdTableBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtBlNo;
        private System.Windows.Forms.Label lblBlNo;
    }
}