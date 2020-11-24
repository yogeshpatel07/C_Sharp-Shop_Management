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
    public partial class ProductFrm : Form
    {
        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMDIFrm.DataPathF + "\\DataBase\\MyShope.accdb;Persist Security Info=False";

        int PidNo = 0;
        string ToDo;

        public ProductFrm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            rbAll.Checked = true;
            ToDo = "New";
            if(MainMDIFrm.isAdmin==false)
            {
                gbPrdData.Enabled = false;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                txtPrdID.Enabled = false;
            }
        }

        private void rbPrdID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrdID.Checked == true)
            {
                txtPrdID.Enabled = true;
                lblPrdId.Text = "Enter Product ID :";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPrdName.Text = "";
            txtPrise.Text = "";
            txtUnit.Text = "";
            txtType.Text = "";
            txtDesc.Text = "";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                float Prise = 0;
                string Qry = "select * from Product_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                if (ToDo == "New")
                {
                    if (txtPrdName.Text.Trim() == "")
                        MessageBox.Show("Product name can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtPrise.Text.Trim() == "") 
                        MessageBox.Show("Price can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (float.TryParse(txtPrise.Text, out Prise) == false)
                        MessageBox.Show("Price value is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                    else if (txtUnit.Text.Trim() == "")
                        MessageBox.Show("Unit can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtType.Text.Trim() == "")
                        MessageBox.Show("Product type can not be empty.", "Information", MessageBoxButtons.OK);
                    else
                    {
                        int PidNo = getPID();

                        Qry = "insert into Product_Tab(PrID,PrName,PrMinPrise,PrUnit,PrType,PrDsrcp,PrAddBy,PrAddDate) values(";
                        Qry = Qry + PidNo + ",'" + txtPrdName.Text + "','" + Prise + "','" + txtUnit.Text + "','" + txtType.Text + "','";
                        Qry = Qry + txtDesc.Text + "','" + MainMDIFrm.UserName + "',#" + DateTime.Now + "#);";

                        cmd.CommandText = Qry;
                        int rv = cmd.ExecuteNonQuery();
                        if (rv > 0)
                        {
                            MessageBox.Show("Product added.", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Product not added.", "ERROR", MessageBoxButtons.OK);
                        }
                    }
                }

                if (ToDo == "Edit")
                {
                    if (txtPrdName.Text.Trim() == "")
                        MessageBox.Show("Product name can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtPrise.Text.Trim() == "")
                        MessageBox.Show("Price can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (float.TryParse(txtPrise.Text, out Prise) == false)
                        MessageBox.Show("Price value is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                    else if (txtUnit.Text.Trim() == "")
                        MessageBox.Show("Unit can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtType.Text.Trim() == "")
                        MessageBox.Show("Product type can not be empty.", "Information", MessageBoxButtons.OK);
                    else
                    {

                        Qry = "UPDATE Product_Tab SET [PrName]='" + txtPrdName.Text + "', [PrMinPrise]='" + Prise + "', [PrUnit]='" + txtUnit.Text + "', [PrType]='" + txtType.Text;
                        Qry = Qry+ "', [PrDsrcp]='" + txtDesc.Text+ "', [PrEditBy]='" + MainMDIFrm.UserName + "', [PrEditDate]=#" + DateTime.Now + "# where [PrID]=" + PidNo;

                        cmd.CommandText = Qry;
                        int rv = cmd.ExecuteNonQuery();
                        if (rv > 0)
                        {
                            MessageBox.Show("Product edited.", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Product not edited.", "ERROR", MessageBoxButtons.OK);
                        }

                    }
                }

                if (ToDo == "Delete")
                {
                    Qry = "Delete from  Product_Tab where [PrID]=" + PidNo;
                    cmd.CommandText = Qry;
                    int rv = cmd.ExecuteNonQuery();
                    if (rv > 0)
                    {
                        MessageBox.Show("Product deleted.", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Product not deleted.", "ERROR", MessageBoxButtons.OK);
                    }
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


            btnSave.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPrdName.Text = "";
            txtPrise.Text = "";
            txtUnit.Text = "";
            txtType.Text = "";
            txtDesc.Text = "";
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }


        private void showData()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtPrdName.Text = "";
            txtPrise.Text = "";
            txtUnit.Text = "";
            txtType.Text = "";
            txtDesc.Text = "";


            string ClmName = "PrID as [Product_ID] , PrName as [Product_Name] , PrQunatity as [Avail_Quantity] , PrMinPrise as [Minimum_Price] , PrUnit as [Units] , PrType as [Product_Type] , ";
            ClmName = ClmName + " PrDsrcp as [Descriptions] , PrAddBy as [Add_By] , PrAddDate as [Adding_Date] , PrEditBy as [Last_Edit_By] , PrEditDate as [Last_Edit_Date] ";
            string Qry = "select " + ClmName + " from Product_Tab";
            if (rbPrdID.Checked == true)
            {
                if (txtPrdID.Text.Trim() == "")
                {
                    MessageBox.Show("Product id can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    Qry = "select " + ClmName + " from Product_Tab where PrID=" + txtPrdID.Text;
                }
            }
            else if (rbName.Checked == true)
            {
                if (txtPrdID.Text.Trim() == "")
                {
                    MessageBox.Show("Product name can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    Qry = "select " + ClmName + " from Product_Tab where PrName like '%" + txtPrdID.Text+"%';";
                }
            }
            else if (rbType.Checked == true)
            {
                if (txtPrdID.Text.Trim() == "")
                {
                    MessageBox.Show("Product type can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    Qry = "select " + ClmName + " from Product_Tab where PrType like '%" + txtPrdID.Text + "%';";
                }
            }
            else
            {
                Qry = "select " + ClmName + " from Product_Tab";
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
                dGView.Columns[7].DefaultCellStyle.Format = "dd-MM-yyyy  hh:mm:ss tt ";
                dGView.Columns[9].DefaultCellStyle.Format = "dd-MM-yyyy  hh:mm:ss tt ";



                if (rbPrdID.Checked == true && txtPrdID.Text.Trim() != "")
                {
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtPrdName.Text = dr.GetString(1);
                        txtPrise.Text = dr.GetFloat(3).ToString();
                        txtUnit.Text = dr.GetString(4);
                        txtType.Text = dr.GetString(5);
                        txtDesc.Text = dr.GetString(6);
                        PidNo = dr.GetInt32(0);
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        int.TryParse(txtPrdID.Text, out PidNo);
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

        private int getPID()
        {
            int id = 1;
            try
            {
                string Qry = "select max(PrID) from Product_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    Dr.Read();
                    id = Dr.GetInt32(0) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            return id;
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbName.Checked == true)
            {
                txtPrdID.Enabled = true;
                lblPrdId.Text = "Enter Product Name :";
            }
        }

        private void rbType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbType.Checked == true)
            {
                txtPrdID.Enabled = true;
                lblPrdId.Text = "Enter Product Type :";
            }
        }

        private void txtPrdID_EnabledChanged(object sender, EventArgs e)
        {
            if(txtPrdID.Enabled==true)
            {
                txtPrdID.BackColor = Color.White;
            }
            else
            {
                txtPrdID.BackColor = Color.Silver;
            }
        }

        private void ProductFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.ProductLoad = false;
        }
    }
}
