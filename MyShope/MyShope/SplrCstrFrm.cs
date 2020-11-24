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
    public partial class SplrCstrFrm : Form
    {
        public string MyType;

        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMDIFrm.DataPathF + "\\DataBase\\MyShope.accdb;Persist Security Info=False";
        int EntNo = 0;
        string ToDo="New";
        public SplrCstrFrm()
        {
            InitializeComponent();
        }

        private void SplrCstrFrm_Load(object sender, EventArgs e)
        {
            if(MyType=="Supplier")
            {
                rbAll.Checked = true;
                rbNo.Text = "Supplier No.";
                lblEntNo.Text = "Enter Supplier No. :";
                txtEntNo.Text = "";
                lblName.Text = "Enter The Supplier Name       :";
                lblMobNo.Text = "Enter The Supplier Mob. No. :";
                lblEmail.Text = "Enter The Supplier Email       :";
                lblAddress.Text = "Enter The Supplier full Address :";

                txtName.Text = "";
                txtMobNo.Text = "";
                txtEntNo.Text = "";
                txtAddress.Text = "";
            }
            if(MyType=="Customer")
            {
                rbAll.Checked = true;
                rbNo.Text = "Customer No.";
                lblEntNo.Text = "Enter Customer No. :";
                txtEntNo.Text = "";
                lblName.Text = "Enter The Customer Name       :";
                lblMobNo.Text = "Enter The Customer Mob. No. :";
                lblEmail.Text = "Enter The Customer Email       :";
                lblAddress.Text = "Enter The Customer full Address :";

                txtName.Text = "";
                txtMobNo.Text = "";
                txtEntNo.Text = "";
                txtAddress.Text = "";
            }

            if(MainMDIFrm.isAdmin==false)
            {
                gbPrdData.Enabled = false;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                txtEntNo.Enabled = false;
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked == true)
            {
                txtEntNo.Enabled = true;
                lblEntNo.Text = "Enter "+MyType+" No. :";
            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbName.Checked == true)
            {
                txtEntNo.Enabled = true;
                lblEntNo.Text = "Enter " + MyType + " Name :";
            }
        }

        private void txtEntNo_EnabledChanged(object sender, EventArgs e)
        {
            if (txtEntNo.Enabled == true)
            {
                txtEntNo.BackColor = Color.White;
            }
            else
            {
                txtEntNo.BackColor = Color.Silver;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMobNo.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            ToDo = "New";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            ToDo = "Edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            ToDo = "Delete";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtMobNo.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MyType=="Supplier")
            {
                try
                {
                    long MNo = 0;
                    string Qry = "select * from Supplier_Tab;";
                    OleDbConnection con = new OleDbConnection(ConStr);
                    OleDbCommand cmd = new OleDbCommand(Qry, con);
                    con.Open();
                    if (ToDo == "New")
                    {
                        if (txtName.Text.Trim() == "")
                            MessageBox.Show("Supplier name can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtMobNo.Text.Trim() == "")
                            MessageBox.Show("Supplier mobile no. can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (long.TryParse(txtMobNo.Text, out MNo) == false)
                            MessageBox.Show("Supplier mobile no. is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                        else if (txtEmail.Text.Trim() == "")
                            MessageBox.Show("Supplier E-Mail can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtAddress.Text.Trim() == "")
                            MessageBox.Show("Supplier address can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            EntNo = getNewID();
                            Qry = "insert into Supplier_Tab(SupID,SupName,SupMobNo,SupEMail,SupAddrs) values(";
                            Qry = Qry + EntNo + ",'" + txtName.Text + "','" + MNo + "','" + txtEmail.Text + "','" + txtAddress.Text + "');";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("New supplier created successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("New supplier not created successfully.", "Information", MessageBoxButtons.OK);
                            }

                        }
                    }
                    if (ToDo == "Edit")
                    {
                        if (txtName.Text.Trim() == "")
                            MessageBox.Show("Supplier name can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtMobNo.Text.Trim() == "")
                            MessageBox.Show("Supplier mobile no. can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (long.TryParse(txtMobNo.Text, out MNo) == false)
                            MessageBox.Show("Supplier mobile no. is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                        else if (txtEmail.Text.Trim() == "")
                            MessageBox.Show("Supplier E-Mail can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtAddress.Text.Trim() == "")
                            MessageBox.Show("Supplier address can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            Qry = "UPDATE Supplier_Tab SET [SupName] ='" + txtName.Text + "' , [SupMobNo] = '" + MNo;
                            Qry = Qry + "' , [SupEMail] = '" + txtEmail.Text + "' , [SupAddrs] = '" + txtAddress.Text + "' where SupID = " + EntNo + ";";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Supplier edited successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Supplier not edited successfully.", "Information", MessageBoxButtons.OK);
                            }
                        }
                    }
                    if (ToDo == "Delete")
                    {
                        if(SupStat()==true)
                        {
                            Qry = "Delete from Supplier_Tab where SupID = " + EntNo + ";";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Supplier deleted successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Supplier not deleted successfully.", "Information", MessageBoxButtons.OK);
                            }
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
            if(MyType=="Customer")
            {
                try
                {
                    long MNo = 0;
                    string Qry = "select * from Customer_Tab;";
                    OleDbConnection con = new OleDbConnection(ConStr);
                    OleDbCommand cmd = new OleDbCommand(Qry, con);
                    con.Open();
                    if (ToDo == "New")
                    {
                        if (txtName.Text.Trim() == "")
                            MessageBox.Show("Customer name can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtMobNo.Text.Trim() == "")
                            MessageBox.Show("Customer mobile no. can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (long.TryParse(txtMobNo.Text, out MNo) == false)
                            MessageBox.Show("Customer mobile no. is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                        else if (txtEmail.Text.Trim() == "")
                            MessageBox.Show("Customer E-Mail can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtAddress.Text.Trim() == "")
                            MessageBox.Show("Customer address can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            EntNo = getNewID();
                            Qry = "insert into Customer_Tab(CusID,CusName,CusMobNo,CusEMail,CusAddrs) values(";
                            Qry = Qry + EntNo + ",'" + txtName.Text + "','" + MNo + "','" + txtEmail.Text + "','" + txtAddress.Text + "');";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("New customer created successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("New customer not created successfully.", "Information", MessageBoxButtons.OK);
                            }

                        }
                    }
                    if (ToDo == "Edit")
                    {
                        if (txtName.Text.Trim() == "")
                            MessageBox.Show("Customer name can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtMobNo.Text.Trim() == "")
                            MessageBox.Show("Customer mobile no. can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (long.TryParse(txtMobNo.Text, out MNo) == false)
                            MessageBox.Show("Customer mobile no. is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                        else if (txtEmail.Text.Trim() == "")
                            MessageBox.Show("Customer E-Mail can not be empty.", "Information", MessageBoxButtons.OK);
                        else if (txtAddress.Text.Trim() == "")
                            MessageBox.Show("Customer address can not be empty.", "Information", MessageBoxButtons.OK);
                        else
                        {
                            Qry = "UPDATE Customer_Tab SET [CusName] ='" + txtName.Text + "' , [CusMobNo] = '" + MNo;
                            Qry = Qry + "' , [CusEMail] = '" + txtEmail.Text + "' , [CusAddrs] = '" + txtAddress.Text + "' where CusID = " + EntNo + ";";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Customer edited successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Customer not edited successfully.", "Information", MessageBoxButtons.OK);
                            }
                        }
                    }
                    if (ToDo == "Delete")
                    {
                        Qry = "Delete from Customer_Tab where CusID = " + EntNo + ";";
                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Customer deleted successfully.", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Customer not deleted successfully.", "Information", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
            
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            
        }


        private int getNewID()
        {
            int id = 1;
            try
            {
                string Qry = "select max(CusID) from Customer_Tab;";
                if (MyType == "Supplier")
                {
                    Qry = "select max(SupID) from Supplier_Tab;";
                }
                    
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    Dr.Read();
                    id = Dr.GetInt32(0) + 1;
                }

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }


            return id;
        }

        private void showData()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Text = "";
            txtMobNo.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            string ClmName=" * ";
            string Qry = "select " + ClmName + " from Supplier_Tab";
            if (MyType == "Supplier")
            {
                ClmName = " SupID as [Supplier_ID] , SupName as [Supplier_Name] , SupMobNo as [Mobile_No] , SupEMail as [E_mail] , ";
                ClmName = ClmName + " SupAddrs as [Address] ";
                Qry = "select " + ClmName + " from Supplier_Tab";
            }
            if(MyType=="Customer")
            {
                ClmName = " CusID as [Customer_ID] , CusName as [Customer_Name] , CusMobNo as [Mobile_No] , CusEMail as [E_mail] , ";
                ClmName = ClmName + " CusAddrs as [Address] ";
                Qry = "select " + ClmName + " from Customer_Tab";
            }
            
            if (rbName.Checked == true)
            {
                if (txtEntNo.Text.Trim() == "")
                {
                    MessageBox.Show("Name can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (MyType == "Supplier")
                    {
                        Qry = "select " + ClmName + " from Supplier_Tab where SupName like '%"+txtEntNo.Text+"%';";
                    }
                    if (MyType == "Customer")
                    {
                        Qry = "select " + ClmName + " from Customer_Tab where CusName like '%" + txtEntNo.Text + "%';";
                    }
                }
            }
            else if (rbNo.Checked == true)
            {
                if (txtEntNo.Text.Trim() == "")
                {
                    MessageBox.Show("No. can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (MyType == "Supplier")
                    {
                        Qry = "select " + ClmName + " from Supplier_Tab where SupID =" + txtEntNo.Text + ";";
                    }
                    if (MyType == "Customer")
                    {
                        Qry = "select " + ClmName + " from Customer_Tab where CusID =" + txtEntNo.Text + ";";
                    }
                }
            }
            

            try
            {
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable Enq = new DataTable();
                da.Fill(Enq);
                dGView.DataSource = Enq;
                
                if (rbNo.Checked == true && txtEntNo.Text.Trim() != "")
                {
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtName.Text = dr.GetString(1);
                        txtMobNo.Text = dr.GetString(2);
                        txtEmail.Text = dr.GetString(3);
                        txtAddress.Text = dr.GetString(4);
                        EntNo = dr.GetInt32(0);
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        int.TryParse(txtEntNo.Text, out EntNo);
                    }

                    if (dr != null)
                        dr.Close();

                }

                if (con != null)
                    con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private bool SupStat()
        {
            bool ret = true;

            try
            {
                string Qry = "select SupID from StoreRoom_Tab where SupID = "+EntNo+";";
                long id = 0;
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    Dr.Read();
                    id = Dr.GetInt32(0) + 1;
                    if(MessageBox.Show("This supplier is used in some products.\nIf you delete it will create some errors.\nDo you want to delete?", "Information", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            return ret;
        }

        private void SplrCstrFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyType == "Supplier")
                MainMDIFrm.SupplierLoad = false;
            if (MyType == "Customer")
                MainMDIFrm.CustomerLoad = false;
        }
    }
}
