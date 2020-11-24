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
    public partial class DebtFrm : Form
    {
        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMDIFrm.DataPathF + "\\DataBase\\MyShope.accdb;Persist Security Info=False";

        int EntNo = 0;
        string ToDo="New";
        string DbtrName = "";

        public DebtFrm()
        {
            InitializeComponent();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                txtSrchIn.Enabled = false;
            }
        }

        private void rbByIDNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByIDNo.Checked == true)
            {
                txtSrchIn.Enabled = true;
                lblEntNo.Text = "Enter Debter ID No. :";
            }
        }

        private void rbByName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByName.Checked == true)
            {
                txtSrchIn.Enabled = true;
                lblEntNo.Text = "Enter Debter Name :";
            }
        }

        private void txtSrchIn_EnabledChanged(object sender, EventArgs e)
        {
            if (txtSrchIn.Enabled == true)
            {
                txtSrchIn.BackColor = Color.White;
            }
            else
            {
                txtSrchIn.BackColor = Color.Silver;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rbCustomer.Checked = true;
            cmbDbtrID.Text = "";
            rbGive.Checked = true;
            txtAmt.Text = "";

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
            rbCustomer.Checked = true;
            cmbDbtrID.Text = "";
            rbGive.Checked = true;
            txtAmt.Text = "";

            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                loadCustomers();
                cmbDbtrID.Text = "";
            }
        }

        private void rbSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSupplier.Checked == true)
            {
                loadSuppliers();
                cmbDbtrID.Text = "";
            }
        }

        private void cmbDbtrID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbtrName = findName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                float amt = 0;
                string Qry = "select * from DebtRcd_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                if (ToDo == "New")
                {
                    if (cmbDbtrID.Text.Trim() == "")
                        MessageBox.Show("Debter id can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtAmt.Text.Trim() == "")
                        MessageBox.Show("Debt amount can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (float.TryParse(txtAmt.Text, out amt) == false)
                        MessageBox.Show("Debt amount is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                    else
                    {
                        EntNo = getEntID();

                        Qry = "insert into DebtRcd_Tab(DbtNo, DebterID, DebterName, DbtAddBy, DbtAddDate) values(";
                        Qry = Qry + EntNo + "," + cmbDbtrID.Text + ",'" + DbtrName + "','" + MainMDIFrm.UserName+ "',#" + DateTime.Now + "#);";

                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            Qry = "UPDATE DebtRcd_Tab SET [DbtNo] = "+EntNo;

                            if (rbCustomer.Checked==true)
                            {
                                if(rbGive.Checked==true)
                                {
                                    Qry = "UPDATE DebtRcd_Tab SET [DebterType] = 'Customer' , [GiveAmt] = " + true + " , [DebtAmt] = " + amt + " where DbtNo = " + EntNo;
                                }
                                if(rbTake.Checked==true)
                                {
                                    Qry = "UPDATE DebtRcd_Tab SET [DebterType] = 'Customer' , [TakeAmt] = " + true + " , [DebtAmt] =" + amt + " where DbtNo = " + EntNo;
                                }
                            }
                            if (rbSupplier.Checked == true)
                            {
                                if (rbGive.Checked == true)
                                {
                                    Qry = "UPDATE DebtRcd_Tab SET [DebterType] = 'Supplier' , [GiveAmt] = " + true + " , [DebtAmt] = " + amt + " where DbtNo = " + EntNo;
                                }
                                if (rbTake.Checked == true)
                                {
                                    Qry = "UPDATE DebtRcd_Tab SET [DebterType] = 'Supplier' , [TakeAmt] = " + true + " , [DebtAmt] = " + amt + " where DbtNo = " + EntNo;
                                }
                            }


                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("New debt entry created successfully.", "Information", MessageBoxButtons.OK);
                            }  
                        }
                        else
                        {
                            MessageBox.Show("New debt entry not created successfully.", "Information", MessageBoxButtons.OK);
                        }

                    }
                }
                if (ToDo == "Edit")
                {
                    if (cmbDbtrID.Text.Trim() == "")
                        MessageBox.Show("Debter id can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtAmt.Text.Trim() == "")
                        MessageBox.Show("Debt amount can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (float.TryParse(txtAmt.Text, out amt) == false)
                        MessageBox.Show("Debt amount is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                    else
                    {
                        if (rbCustomer.Checked == true)
                        {
                            if (rbGive.Checked == true)
                            {
                                Qry = "UPDATE DebtRcd_Tab SET [DebterID] = " + cmbDbtrID.Text + " , [DebterName] = '" + DbtrName + "' ,";
                                Qry = Qry + "[DebterType] = 'Customer' , [GiveAmt] = " + true + " , [TakeAmt] = " + false + " ,[DebtAmt] = ";
                                Qry = Qry + amt + " , [DbtEditBy] = '" + MainMDIFrm.UserName + "' ,"+ " [DbtEditDate] = #" + DateTime.Now + "# where DbtNo = " + EntNo;
                            }
                            if (rbTake.Checked == true)
                            {
                                Qry = "UPDATE DebtRcd_Tab SET [DebterID] = " + cmbDbtrID.Text + " , [DebterName] = '" + DbtrName + "' ,";
                                Qry = Qry + "[DebterType] = 'Customer' , [GiveAmt] = " + false + " , [TakeAmt] = " + true + " ,[DebtAmt] = ";
                                Qry = Qry + amt + " , [DbtEditBy] = '" + MainMDIFrm.UserName + "' ," + " [DbtEditDate] = #" + DateTime.Now + "# where DbtNo = " + EntNo;
                            }
                        }
                        if (rbSupplier.Checked == true)
                        {
                            if (rbGive.Checked == true)
                            {
                                Qry = "UPDATE DebtRcd_Tab SET [DebterID] = " + cmbDbtrID.Text + " , [DebterName] = '" + DbtrName + "' ,";
                                Qry = Qry + "[DebterType] = 'Supplier' , [GiveAmt] = " + true + " , [TakeAmt] = " + false + " ,[DebtAmt] = ";
                                Qry = Qry + amt + " , [DbtEditBy] = '" + MainMDIFrm.UserName + "' ," + " [DbtEditDate] = #" + DateTime.Now + "# where DbtNo = " + EntNo;
                            }
                            if (rbTake.Checked == true)
                            {
                                Qry = "UPDATE DebtRcd_Tab SET [DebterID] = " + cmbDbtrID.Text + " , [DebterName] = '" + DbtrName + "' ,";
                                Qry = Qry + "[DebterType] = 'Supplier' , [GiveAmt] = " + false + " , [TakeAmt] = " + true + " ,[DebtAmt] = ";
                                Qry = Qry + amt + " , [DbtEditBy] = '" + MainMDIFrm.UserName + "' ," + " [DbtEditDate] = #" + DateTime.Now + "# where DbtNo = " + EntNo;
                            }
                        }

                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Debt entry edited successfully.", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Debt entry not edited successfully.", "Information", MessageBoxButtons.OK);
                        }
                    }
                }

                if (ToDo == "Delete")
                {
                    Qry = "Delete from DebtRcd_Tab where DbtNo = " + EntNo + ";";
                    cmd.CommandText = Qry;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Debt entry deleted successfully.", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Debt entry not deleted successfully.", "Information", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void DebtFrm_Load(object sender, EventArgs e)
        {
            if(MainMDIFrm.isAdmin==false)
            {
                gbPrdData.Enabled = false;
            }
            else
            {
                rbCustomer.Checked = true;
                loadCustomers();
                rbGive.Checked = true;
            }
        }

        private int getEntID()
        {
            int id = 1;
            try
            {
                string Qry = "select max(DbtNo) from DebtRcd_Tab;";
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
            rbCustomer.Checked = true;
            cmbDbtrID.Text = "";
            rbTake.Checked = true;
            txtAmt.Text = "";

            string ClmName = " DbtNo as [Entry_No] , DebterID as [Debter_ID] , DebterName as [Debter_Name] , DebterType as [Debter_Type] , DebtAmt as [Debt_Amount] , ";
            ClmName = ClmName + " GiveAmt as [Given] , TakeAmt as [Taken] , DbtAddBy as [Added_By] , DbtAddDate as [Added_Date] , DbtEditBy as [Last_Edit_By] ,";
            ClmName = ClmName + " DbtEditDate as [Last_Edit_Date] ";

            string Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Customer';";

            if (rbByIDNo.Checked == true)
            {
                if (txtSrchIn.Text.Trim() == "")
                {
                    MessageBox.Show("Debter id can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (rbSrchCust.Checked == true)
                    {
                        Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Customer' and DbtNo = " + txtSrchIn.Text + ";";
                    }
                    if (rbSrchSup.Checked == true)
                    {
                        Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Supplier' and DbtNo = " + txtSrchIn.Text + ";";
                    }

                }
            }
            else if (rbByName.Checked == true)
            {
                if (txtSrchIn.Text.Trim() == "")
                {
                    MessageBox.Show("Debter name can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (rbSrchCust.Checked == true)
                    {
                        Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Customer' and DebterName like '%" + txtSrchIn.Text + "%';";
                    }
                    if (rbSrchSup.Checked == true)
                    {
                        Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Supplier' and DebterName like '%" + txtSrchIn.Text + "%';";
                    }
                }
            }
            else if (rbAll.Checked == true)
            {
                if (rbSrchCust.Checked == true)
                {
                    Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Customer';";
                }
                if (rbSrchSup.Checked == true)
                {
                    Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Supplier';";
                }
            }
            else
            {
                Qry = "select " + ClmName + " from DebtRcd_Tab where DebterType ='Customer';";
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

                if (rbByIDNo.Checked == true && rbByIDNo.Text.Trim() != "")
                {
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();

                        if (dr.GetString(3) == "Customer")
                            rbCustomer.Checked = true;
                        else
                            rbSupplier.Checked = true;

                        cmbDbtrID.Text = dr.GetInt32(1).ToString();

                        txtAmt.Text = dr.GetFloat(4).ToString();

                        if (dr.GetBoolean(5) == true)
                            rbGive.Checked = true;

                        if (dr.GetBoolean(6) == true)
                            rbTake.Checked = true;

                        EntNo = dr.GetInt32(0);
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        int.TryParse(txtSrchIn.Text, out EntNo);
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

        private void loadSuppliers()
        {
            try
            {
                cmbDbtrID.Items.Clear();
                string Qry = "select SupID from Supplier_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbDbtrID.Items.Add(dr.GetInt32(0));
                    }
                }

                if (dr != null)
                    dr.Close();

                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void loadCustomers()
        {
            try
            {
                cmbDbtrID.Items.Clear();
                string Qry = "select CusID from Customer_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbDbtrID.Items.Add(dr.GetInt32(0));
                    }
                }

                if (dr != null)
                    dr.Close();

                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private string findName()
        {
            string dbtrname = "";
            try
            {
                string Qry = "select CusName from Customer_Tab where CusID ="+cmbDbtrID.Text;

                if (rbSupplier.Checked == true)
                {
                    Qry = "select SupName from Supplier_Tab where SupID =" + cmbDbtrID.Text;
                }


                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    dbtrname = dr.GetString(0);
                }

                if (dr != null)
                    dr.Close();

                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            return dbtrname;
        }

        private void DebtFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.DebtLoad = false;
        }
    }
}
