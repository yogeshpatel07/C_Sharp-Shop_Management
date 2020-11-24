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
    public partial class UserFrm : Form
    {
        string ToDo = "New";

        public UserFrm()
        {
            InitializeComponent();
        }

        private void RbNewUser_CheckedChanged(object sender, EventArgs e)
        {
            if (RbNewUser.Checked == true)
            {
                GbUpUser.Visible = false;
                ToDo = "New";
            }
        }

        private void RbDelUser_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDelUser.Checked == true)
            {
                GbUpUser.Visible = false;
                ToDo = "Del";
            }
        }

        private void RbUpUser_CheckedChanged(object sender, EventArgs e)
        {
            if (RbUpUser.Checked == true)
            {
                GbUpUser.Visible = true;
                ToDo = "Up";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string epass = Encrypt(TxtPass.Text);
                string Nepass = Encrypt(TxtNPass.Text);

                string Qry = "select * from LOGIN where [UNAME]='" + TxtUName.Text + "';";
                string QryNew = "insert into LOGIN values('" + TxtUName.Text + "','" + epass + "'," + RbAdmYes.Checked + ");";
                string QryDel = "Delete from LOGIN where [UNAME]='" + TxtUName.Text + "' and [PASSWORD]='" + epass + "';";
                string QryUpD = "UPDATE LOGIN SET [UNAME]='" + TxtNUName.Text + "', [PASSWORD]='" + Nepass + "', [IsAdmin]=" + RbAdmYes.Checked + " where [UNAME]='" + TxtUName.Text + "' and [PASSWORD]='" + epass + "';";

                OleDbConnection con = new OleDbConnection(LoginFrm.ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();

                if (ToDo == "New")
                {
                    if (TxtUName.Text == "" || TxtPass.Text == "")
                    {
                        MessageBox.Show("Username or password can\'t be empty.", "information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (Dr.HasRows)
                        {
                            MessageBox.Show("There is already a user with this name.", "information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (Dr != null)
                            {
                                Dr.Close();
                            }
                            cmd.CommandText = QryNew;
                            int rv = cmd.ExecuteNonQuery();
                            if (rv > 0)
                            {
                                MessageBox.Show("New user created.", "information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("New user not created.", "information", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                if (ToDo == "Del")
                {
                    if (TxtUName.Text == "" || TxtPass.Text == "")
                    {
                        MessageBox.Show("Username or password can\'t be empty.", "information", MessageBoxButtons.OK);
                    }
                    else
                    {

                        if (Dr.HasRows)
                        {
                            if (Dr != null)
                            {
                                Dr.Close();
                            }
                            cmd.CommandText = QryDel;
                            int rv = cmd.ExecuteNonQuery();
                            if (rv > 0)
                            {
                                MessageBox.Show("User deleted successfully.", "information", MessageBoxButtons.OK);
                                this.Close();


                            }
                            else
                            {
                                MessageBox.Show("User not deleted successfully.", "information", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no such user and password exist.", "information", MessageBoxButtons.OK);
                        }
                    }
                }

                if (ToDo == "Up")
                {
                    if (TxtUName.Text == "" || TxtPass.Text == "")
                    {
                        MessageBox.Show("Old username or password can't be empty.", "information", MessageBoxButtons.OK);
                    }
                    else if (TxtNUName.Text == "" || TxtNPass.Text == "")
                    {
                        MessageBox.Show("New username or password can't be empty.", "information", MessageBoxButtons.OK);
                    }
                    else
                    {

                        if (Dr.HasRows)
                        {
                            if (Dr != null)
                            {
                                Dr.Close();
                            }

                            cmd.CommandText = QryUpD;
                            int rv = cmd.ExecuteNonQuery();
                            if (rv > 0)
                            {
                                MessageBox.Show("User updated successfully.", "information", MessageBoxButtons.OK);
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("User not updated successfully.", "information", MessageBoxButtons.OK);
                            }

                        }
                        else
                        {
                            MessageBox.Show("There is no such user and password exist.", "information", MessageBoxButtons.OK);
                        }
                    }
                }
                if (Dr != null)
                {
                    Dr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
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

        private void UserFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.UserLoad = false;
        }
    }
}
