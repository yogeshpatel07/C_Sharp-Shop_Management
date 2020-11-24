using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShope
{
    public partial class MainMDIFrm : Form
    {
        public static bool LoginState = false;
        public static string UserName = "";
        public static bool isAdmin = false;
        public static string DataPathF = Environment.CurrentDirectory;
        public static bool isLoginShow = false;

        public static bool loginLoad = false;
        public static bool ProductLoad = false;
        public static bool StoreLoad = false;
        public static bool SupplierLoad = false;
        public static bool CustomerLoad = false;
        public static bool BillLoad = false;
        public static bool DebtLoad = false;
        public static bool UserLoad = false;
        public static bool BillRepLoad = false;




        public MainMDIFrm()
        {
            InitializeComponent();
        }

        private void MainMDIFrm_Load(object sender, EventArgs e)
        {
            UserName = "";
            isAdmin = false;
            LoginState = false;

            LoginFrm logFrm = new LoginFrm();
            logFrm.MdiParent = this;
            logFrm.Show();
            isLoginShow = true;
            loginLoad = true;

        }

        private void LoginMenu_Click(object sender, EventArgs e)
        {
            if (loginLoad == false)
            {
                if (isLoginShow == false)
                {
                    LoginFrm logFrm = new LoginFrm();
                    logFrm.MdiParent = this;
                    logFrm.Show();
                    isLoginShow = true;
                    loginLoad = true;
                }
                else
                   MessageBox.Show("Please use form list menu to show login form.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show login form.", "Information", MessageBoxButtons.OK);


        }

        private void LogOutMenu_Click(object sender, EventArgs e)
        {
            if (LoginState == true)
            {
                UserName = "";
                isAdmin = false;
                LoginState = false;
                MessageBox.Show("You have logout.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You already logout or not yet login.", "Information",MessageBoxButtons.OK);
            }
        }

        private void ProdMenu_Click(object sender, EventArgs e)
        {
            if(ProductLoad==false)
            {
                if (LoginState == true)
                {
                    ProductFrm prdfrm = new ProductFrm();
                    prdfrm.MdiParent = this;
                    prdfrm.Show();
                    ProductLoad = true;
                }
                else
                    MessageBox.Show("Please login to view this page.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show product form.", "Information", MessageBoxButtons.OK);
        }

        private void UserMenu_Click(object sender, EventArgs e)
        {
            if(UserLoad==false)
            {
                if (LoginState == true && isAdmin == true)
                {
                    UserFrm usrfrm = new UserFrm();
                    usrfrm.MdiParent = this;
                    usrfrm.Show();
                    UserLoad = true;
                }
                else
                    MessageBox.Show("Please login with admin account to view this page.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show user form.", "Information", MessageBoxButtons.OK);
            
        }

        private void StoreMenu_Click(object sender, EventArgs e)
        {
            if(StoreLoad==false)
            {
                if (LoginState == true && isAdmin == true)
                {
                    StoreFrm storefrm = new StoreFrm();
                    storefrm.MdiParent = this;
                    storefrm.Show();
                    StoreLoad = true;
                }
                else
                {
                    MessageBox.Show("Please login with admin account to view this page.", "Information", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Please use form list menu to show store form.", "Information", MessageBoxButtons.OK);


        }

        private void SplrMenu_Click(object sender, EventArgs e)
        {
            if(SupplierLoad==false)
            {
                if (LoginState == true)
                {
                    SplrCstrFrm SpCrfrm = new SplrCstrFrm();
                    SpCrfrm.MyType = "Supplier";
                    SpCrfrm.Text = "Supplier";
                    SpCrfrm.MdiParent = this;
                    SpCrfrm.Show();
                    SupplierLoad = true;

                }
                else
                    MessageBox.Show("Please login to view this page.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show supplier form.", "Information", MessageBoxButtons.OK);
            
        }

        private void CstmrMenu_Click(object sender, EventArgs e)
        {
            if(CustomerLoad==false)
            {
                if (LoginState == true)
                {
                    SplrCstrFrm SpCrfrm = new SplrCstrFrm();
                    SpCrfrm.MyType = "Customer";
                    SpCrfrm.Text = "Customer";
                    SpCrfrm.MdiParent = this;
                    SpCrfrm.Show();
                    CustomerLoad = true;

                }
                else
                MessageBox.Show("Please login to view this page.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show customer form.", "Information", MessageBoxButtons.OK);
        }

        private void DebtMenu_Click(object sender, EventArgs e)
        {
            if(DebtLoad==false)
            {
                if (LoginState == true)
                {
                    DebtFrm Dbtfrm = new DebtFrm();
                    Dbtfrm.MdiParent = this;
                    Dbtfrm.Show();
                    DebtLoad = true;

                }
                else
                    MessageBox.Show("Please login to view this page.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show debt form.", "Information", MessageBoxButtons.OK);
        }

        private void BillMenu_Click(object sender, EventArgs e)
        {
            if(BillLoad==false)
            {
                if (LoginState == true)
                {
                    BillFrm billfrm = new BillFrm();
                    billfrm.MdiParent = this;
                    billfrm.Show();
                    BillLoad = true;
                }
                else
                    MessageBox.Show("Please login to view this page.", "Information", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please use form list menu to show bill form.", "Information", MessageBoxButtons.OK);
        }



    }
}
