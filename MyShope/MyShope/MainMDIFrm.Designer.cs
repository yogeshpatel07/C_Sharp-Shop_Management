namespace MyShope
{
    partial class MainMDIFrm
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
            this.MStr1 = new System.Windows.Forms.MenuStrip();
            this.WinManu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SplrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CstmrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BillMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoginMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmsListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MStr1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MStr1
            // 
            this.MStr1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WinManu,
            this.FrmsListMenu});
            this.MStr1.Location = new System.Drawing.Point(0, 0);
            this.MStr1.MdiWindowListItem = this.FrmsListMenu;
            this.MStr1.Name = "MStr1";
            this.MStr1.Size = new System.Drawing.Size(1019, 24);
            this.MStr1.TabIndex = 1;
            this.MStr1.Text = "menuStrip1";
            // 
            // WinManu
            // 
            this.WinManu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdMenu,
            this.StoreMenu,
            this.SplrMenu,
            this.CstmrMenu,
            this.BillMenu,
            this.DebtMenu,
            this.UserMenu,
            this.toolStripSeparator1,
            this.LoginMenu,
            this.LogOutMenu});
            this.WinManu.Name = "WinManu";
            this.WinManu.Size = new System.Drawing.Size(79, 20);
            this.WinManu.Text = "New Forms";
            // 
            // ProdMenu
            // 
            this.ProdMenu.Name = "ProdMenu";
            this.ProdMenu.Size = new System.Drawing.Size(126, 22);
            this.ProdMenu.Text = "Products";
            this.ProdMenu.Click += new System.EventHandler(this.ProdMenu_Click);
            // 
            // StoreMenu
            // 
            this.StoreMenu.Name = "StoreMenu";
            this.StoreMenu.Size = new System.Drawing.Size(126, 22);
            this.StoreMenu.Text = "Store";
            this.StoreMenu.Click += new System.EventHandler(this.StoreMenu_Click);
            // 
            // SplrMenu
            // 
            this.SplrMenu.Name = "SplrMenu";
            this.SplrMenu.Size = new System.Drawing.Size(126, 22);
            this.SplrMenu.Text = "Supplier";
            this.SplrMenu.Click += new System.EventHandler(this.SplrMenu_Click);
            // 
            // CstmrMenu
            // 
            this.CstmrMenu.Name = "CstmrMenu";
            this.CstmrMenu.Size = new System.Drawing.Size(126, 22);
            this.CstmrMenu.Text = "Costumer";
            this.CstmrMenu.Click += new System.EventHandler(this.CstmrMenu_Click);
            // 
            // BillMenu
            // 
            this.BillMenu.Name = "BillMenu";
            this.BillMenu.Size = new System.Drawing.Size(126, 22);
            this.BillMenu.Text = "Bill";
            this.BillMenu.Click += new System.EventHandler(this.BillMenu_Click);
            // 
            // DebtMenu
            // 
            this.DebtMenu.Name = "DebtMenu";
            this.DebtMenu.Size = new System.Drawing.Size(126, 22);
            this.DebtMenu.Text = "Debt";
            this.DebtMenu.Click += new System.EventHandler(this.DebtMenu_Click);
            // 
            // UserMenu
            // 
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(126, 22);
            this.UserMenu.Text = "User";
            this.UserMenu.Click += new System.EventHandler(this.UserMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // LoginMenu
            // 
            this.LoginMenu.Name = "LoginMenu";
            this.LoginMenu.Size = new System.Drawing.Size(126, 22);
            this.LoginMenu.Text = "Login";
            this.LoginMenu.Click += new System.EventHandler(this.LoginMenu_Click);
            // 
            // LogOutMenu
            // 
            this.LogOutMenu.Name = "LogOutMenu";
            this.LogOutMenu.Size = new System.Drawing.Size(126, 22);
            this.LogOutMenu.Text = "Logout";
            this.LogOutMenu.Click += new System.EventHandler(this.LogOutMenu_Click);
            // 
            // FrmsListMenu
            // 
            this.FrmsListMenu.Name = "FrmsListMenu";
            this.FrmsListMenu.Size = new System.Drawing.Size(73, 20);
            this.FrmsListMenu.Text = "Forms List";
            // 
            // MainMDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 496);
            this.Controls.Add(this.MStr1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MStr1;
            this.Name = "MainMDIFrm";
            this.Text = "My Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMDIFrm_Load);
            this.MStr1.ResumeLayout(false);
            this.MStr1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem WinManu;
        private System.Windows.Forms.ToolStripMenuItem FrmsListMenu;
        private System.Windows.Forms.ToolStripMenuItem ProdMenu;
        private System.Windows.Forms.ToolStripMenuItem StoreMenu;
        private System.Windows.Forms.ToolStripMenuItem CstmrMenu;
        private System.Windows.Forms.ToolStripMenuItem BillMenu;
        private System.Windows.Forms.ToolStripMenuItem DebtMenu;
        private System.Windows.Forms.ToolStripMenuItem UserMenu;
        private System.Windows.Forms.ToolStripMenuItem LoginMenu;
        private System.Windows.Forms.ToolStripMenuItem SplrMenu;
        public System.Windows.Forms.MenuStrip MStr1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LogOutMenu;
    }
}

