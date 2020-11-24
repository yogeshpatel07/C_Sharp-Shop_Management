using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShope
{
    public partial class LoginFrm : Form
    {
        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="+MainMDIFrm.DataPathF+"\\DataBase\\MyShope.accdb;Persist Security Info=False";
        
        public static OleDbConnection con = new OleDbConnection(ConStr);
        public static OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader Dr = null;
        
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.isLoginShow = false;
            MainMDIFrm.loginLoad = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtUName.Text = "";
            TxtPWord.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string epass = Encrypt(TxtPWord.Text);
                string Qry = "select * from Login where Uname='" + TxtUName.Text + "' and PassWord='" + epass + "'";

                cmd.CommandText = Qry;
                cmd.Connection = con;
                con.Open();
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    Dr.Read();
                    MainMDIFrm.UserName = Dr.GetString(0);
                    MainMDIFrm.isAdmin = Dr.GetBoolean(2);
                    MessageBox.Show("Login successfull...", "information", MessageBoxButtons.OK);
                    this.Close();
                    MainMDIFrm.LoginState = true;
                    
                }
                else
                {
                    MessageBox.Show("Wrong username and password.", "information", MessageBoxButtons.OK);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (Dr != null)
                Dr.Close();
            if (con != null)
                con.Close();
        }

        private void btnNewAc_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUName.Text.Trim() == "")
                {
                    MessageBox.Show("User name can not be empty.", "Information", MessageBoxButtons.OK);
                }
                else if (TxtPWord.Text.Trim() == "")
                {
                    MessageBox.Show("Password can not be empty.", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    string epass = Encrypt(TxtPWord.Text);
                    string Qry = "insert into Login values('" + TxtUName.Text + "','" + epass + "'," + true + ");";

                    cmd.CommandText = Qry;
                    cmd.Connection = con;
                    con.Open();
                    int rv = cmd.ExecuteNonQuery();
                    if (rv <= 0)
                    {
                        MessageBox.Show("Account not created...", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Admin account created...", "Information", MessageBoxButtons.OK);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("This username is already Exist.\nEnter other Username.\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (con != null)
                con.Close();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            isUserExist();
        }

        private void isUserExist()
        {
            try
            {

                string Qry = "select * from Login";

                cmd.CommandText = Qry;
                cmd.Connection = con;
                con.Open();
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows == false)
                {
                    btnNewAc.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            if (Dr != null)
                Dr.Close();
            if (con != null)
                con.Close();
        }
        private string Encrypt(string name)
        {

            string z = "", dbn;
            char ch;
            int i, nm;
            for (i = 0; i < name.Length; i++)
            {
                ch = name[i];
                nm = (int)ch;
                dbn = DecToBin(nm);
                z = z + dbn + ",";
            }

            return z;
        }
        private string DecToBin(int n)
        {
            int i;
            int[] a = new int[20];
            string rs = "";
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                rs = rs + a[i];
            }
            return rs;
        }
    }
}
