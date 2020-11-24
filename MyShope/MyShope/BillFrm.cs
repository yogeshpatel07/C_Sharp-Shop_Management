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
    public partial class BillFrm : Form
    {
        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMDIFrm.DataPathF + "\\DataBase\\MyShope.accdb;Persist Security Info=False";

        int BilNo = 0;
        int CstID = 0;
        string ToDo = "New";
        string CstName = "";
        string PrdName = "";
        float MinPrs = 0;
        float AvlQnt = 0;
        float BillAmt = 0;

        public BillFrm()
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

        private void rbByName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByName.Checked == true)
            {
                txtSrchIn.Enabled = true;
                lblEntNo.Text = "Enter Customer Name :";
            }
        }

        private void rbByBillNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByBillNo.Checked == true)
            {
                txtSrchIn.Enabled = true;
                lblEntNo.Text = "Enter Bill No. :";
                btnPrintBill.Enabled = true;
            }
            else
                btnPrintBill.Enabled = false;
        }

        private void txtSrchIn_EnabledChanged(object sender, EventArgs e)
        {
            if (txtSrchIn.Enabled == true)
                txtSrchIn.BackColor = Color.White;
            else
                txtSrchIn.BackColor = Color.Silver;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void rbExist_CheckedChanged(object sender, EventArgs e)
        {
            if(rbExist.Checked==true)
            {
                cmbCstID.Enabled = true;
                gbNewCst.Enabled = false;
            }
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked == true)
            {
                cmbCstID.Enabled = false;
                gbNewCst.Enabled = true;
            }
        }

        private void BillFrm_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cmbCstID_SelectedIndexChanged(object sender, EventArgs e)
        {
            findCstName();
            int.TryParse(cmbCstID.Text,out CstID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float Prise=0,PrePs=0;
            float Qntt=0,PreQnt=0;
            int ind;
            if(cmbPrdID.Text.Trim()=="")
                MessageBox.Show("Product id can not be empty.", "ERROR", MessageBoxButtons.OK);
            else if(txtPrdQnt.Text.Trim()=="")
                MessageBox.Show("Product quantity can not be empty.", "ERROR", MessageBoxButtons.OK);
            else if (float.TryParse(txtPrdQnt.Text,out Qntt)==false)
                MessageBox.Show("Product quantity value is invalid.\nEnter a numberic value.", "ERROR", MessageBoxButtons.OK);
            else if (txtPrdPrise.Text.Trim() == "")
                MessageBox.Show("Product price can not be empty.", "ERROR", MessageBoxButtons.OK);
            else if (float.TryParse(txtPrdPrise.Text, out Prise) == false)
                MessageBox.Show("Product price value is invalid.\nEnter a numberic value.", "ERROR", MessageBoxButtons.OK);
            else
            {
                if(lstPrdID.Items.Contains(cmbPrdID.Text)==true)
                {
                    if(MessageBox.Show("This product is already added in list.\nDo you want do merge it?", "Information", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        ind = lstPrdID.Items.IndexOf(cmbPrdID.Text);
                        if(float.TryParse(lstPrdQnt.Items[ind].ToString(), out PreQnt)==false)
                        {
                            MessageBox.Show("Can\'t merge because old quantity value is invalid type.", "ERROR", MessageBoxButtons.OK);
                        }
                        else if (float.TryParse(lstPrdPrise.Items[ind].ToString(), out PrePs) == false)
                        {
                            MessageBox.Show("Can\'t merge because old price value is invalid type.", "ERROR", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Qntt = PreQnt + Qntt;

                            if (Prise < MinPrs)
                            {
                                MessageBox.Show("Can\'t merge because new price is less than minimum price RS." + MinPrs, "ERROR", MessageBoxButtons.OK);
                            }
                            else if(Qntt > AvlQnt)
                            {
                                MessageBox.Show("Can\'t merge because total quantity is bigger than avalible quantity " + AvlQnt, "ERROR", MessageBoxButtons.OK);
                            }
                            else
                            {
                                lstPrdID.Items[ind] = cmbPrdID.Text;
                                lstPrdName.Items[ind] = PrdName;
                                lstPrdQnt.Items[ind] = Qntt;
                                lstPrdPrise.Items[ind] = Prise;
                            }
                        }
                        

                    }
                }
                else
                {
                    if (Prise < MinPrs)
                    {
                        MessageBox.Show("Can\'t add because price is less than minimum price RS." + MinPrs, "ERROR", MessageBoxButtons.OK);
                    }
                    else if (Qntt > AvlQnt)
                    {
                        MessageBox.Show("Can\'t add because quantity is bigger than avalible quantity " + AvlQnt, "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        lstPrdID.Items.Add(cmbPrdID.Text);
                        lstPrdName.Items.Add(PrdName);
                        lstPrdQnt.Items.Add(Qntt);
                        lstPrdPrise.Items.Add(Prise);
                    }
                }
                
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstPrdID.Items.Clear();
            lstPrdName.Items.Clear();
            lstPrdPrise.Items.Clear();
            lstPrdQnt.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int ind = 0;
            if (txtIndex.Text.Trim() == "")
                MessageBox.Show("Index no. can not be empty.", "ERROR", MessageBoxButtons.OK);
            else if (int.TryParse(txtIndex.Text, out ind) == false)
                MessageBox.Show("Index no. value is invalid.\nEnter a integer value.", "ERROR", MessageBoxButtons.OK);
            else if(ind<1)
                MessageBox.Show("Index no. value is invalid.\nEnter a integer value greater than 0.", "ERROR", MessageBoxButtons.OK);
            else
            {
                try
                {
                    lstPrdID.Items.RemoveAt(ind - 1);
                    lstPrdName.Items.RemoveAt(ind - 1);
                    lstPrdQnt.Items.RemoveAt(ind - 1);
                    lstPrdPrise.Items.RemoveAt(ind - 1);
                }
                catch(Exception)
                {
                    MessageBox.Show("Not a valid index no.", "ERROR", MessageBoxButtons.OK);
                }
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            refreshData();

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            ToDo = "New";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rbNew.Enabled = false;
            rbExist.Checked = true;

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            ToDo = "Edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rbNew.Enabled = false;

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
                int PrdCnt = 0,cntr=0;
                string Qry = "select * from Supplier_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                if (ToDo == "New")
                {
                    countAmount();
                    if (rbNew.Checked == true)
                    {
                        if (CreateNewCustomer() == true)
                        {
                            PrdCnt = lstPrdID.Items.Count;
                            if (PrdCnt == lstPrdName.Items.Count && PrdCnt == lstPrdPrise.Items.Count && PrdCnt == lstPrdQnt.Items.Count)
                            {
                                BilNo = getNewBillNo();
                                Qry = "insert into Bill_Tab(BillNo , CusID , CusName , BillTotAmt , BillBy , BillDate) values(";
                                Qry = Qry + BilNo + " , " + CstID + ",'" + CstName + "'," + BillAmt + ",'" + MainMDIFrm.UserName + "',#" + DateTime.Now + "#);";
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    cntr = 0;
                                    while (PrdCnt > 0)
                                    {
                                        Qry = "insert into BillProd_Tab(BillNo , PrID , PrName , PrSoldUnits , PrSoldPrise) values(";
                                        Qry = Qry + BilNo + " , " + lstPrdID.Items[cntr] + ",'" + lstPrdName.Items[cntr] + "'," + lstPrdQnt.Items[cntr] + "," + lstPrdPrise.Items[cntr] + ");";
                                        cmd.CommandText = Qry;
                                        if(cmd.ExecuteNonQuery()>0)
                                        {
                                            if(UpAvlProd(int.Parse(lstPrdID.Items[cntr].ToString()), int.Parse(lstPrdQnt.Items[cntr].ToString()), "Add")== false)
                                            {
                                                MessageBox.Show("Product data saving time error.", "Information", MessageBoxButtons.OK);
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Product data saving time error.", "Information", MessageBoxButtons.OK);
                                            break;
                                        }
                                        cntr++;
                                        PrdCnt--;
                                    }
                                    MessageBox.Show("New bill created successfully.", "Information", MessageBoxButtons.OK);
                                }
                                else
                                    MessageBox.Show("New bill not created successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Can\'t create new bill because some error in product details.", "Error", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Can\'t create new bill because new user not created.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {

                        PrdCnt = lstPrdID.Items.Count;
                        if(cmbCstID.Text.Trim()=="")
                            MessageBox.Show("Customer id can not be empty.", "Error", MessageBoxButtons.OK);

                        else if (PrdCnt == lstPrdName.Items.Count && PrdCnt == lstPrdPrise.Items.Count && PrdCnt == lstPrdQnt.Items.Count)
                        {
                            BilNo = getNewBillNo();
                            Qry = "insert into Bill_Tab(BillNo , CusID , CusName , BillTotAmt , BillBy , BillDate) values(";
                            Qry = Qry + BilNo + " , " + CstID + ",'" + CstName + "'," + BillAmt + ",'" + MainMDIFrm.UserName + "',#" + DateTime.Now + "#);";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                cntr = 0;
                                while (PrdCnt > 0)
                                {
                                    Qry = "insert into BillProd_Tab(BillNo , PrID , PrName , PrSoldUnits , PrSoldPrise) values(";
                                    Qry = Qry + BilNo + " , " + lstPrdID.Items[cntr] + ",'" + lstPrdName.Items[cntr] + "'," + lstPrdQnt.Items[cntr] + "," + lstPrdPrise.Items[cntr] + ");";
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0)
                                    {
                                        if (UpAvlProd(int.Parse(lstPrdID.Items[cntr].ToString()), int.Parse(lstPrdQnt.Items[cntr].ToString()), "Add") == false)
                                        {
                                            MessageBox.Show("Product data saving time error.", "Information", MessageBoxButtons.OK);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Product data saving time error.", "Information", MessageBoxButtons.OK);
                                        break;
                                    }
                                    cntr++;
                                    PrdCnt--;
                                }
                                MessageBox.Show("New bill created successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("New bill not created successfully.", "Information", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Can\'t create new bill because there are some errors in product details.", "Error", MessageBoxButtons.OK);
                    }
                }

                if (ToDo == "Edit")
                {
                    countAmount();
                    PrdCnt = lstPrdID.Items.Count;
                    if (cmbCstID.Text.Trim() == "")
                        MessageBox.Show("Customer id can not be empty.", "Error", MessageBoxButtons.OK);

                    else if (PrdCnt == lstPrdName.Items.Count && PrdCnt == lstPrdPrise.Items.Count && PrdCnt == lstPrdQnt.Items.Count)
                    {
                        Qry = "UPDATE Bill_Tab SET [CusID] = " + CstID + " , [CusName] = '" + CstName + "' , [BillTotAmt] = " + BillAmt + " , ";
                        Qry = Qry + " [BillEditBy] = '" + MainMDIFrm.UserName + "', [BillEditDate] = #" + DateTime.Now + "# where BillNo = " + BilNo + ";";

                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            if(DeleteData(BilNo)==false)
                            {
                                MessageBox.Show("Product Availble quantity update time error.", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                Qry = "Delete from BillProd_Tab where BillNo = " + BilNo + ";";
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    cntr = 0;
                                    while (PrdCnt > 0)
                                    {
                                        Qry = "insert into BillProd_Tab(BillNo , PrID , PrName , PrSoldUnits , PrSoldPrise) values(";
                                        Qry = Qry + BilNo + " , " + lstPrdID.Items[cntr] + ",'" + lstPrdName.Items[cntr] + "'," + lstPrdQnt.Items[cntr] + "," + lstPrdPrise.Items[cntr] + ");";
                                        cmd.CommandText = Qry;
                                        if (cmd.ExecuteNonQuery() > 0)
                                        {
                                            if (UpAvlProd(int.Parse(lstPrdID.Items[cntr].ToString()), int.Parse(lstPrdQnt.Items[cntr].ToString()), "Add") == false)
                                            {
                                                MessageBox.Show("Product data saving time error.", "Information", MessageBoxButtons.OK);
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Product data saving time error.", "Information", MessageBoxButtons.OK);
                                            break;
                                        }
                                        cntr++;
                                        PrdCnt--;
                                    }
                                }
                                MessageBox.Show("Bill edited successfully.", "Information", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bill not edited successfully.", "Information", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can\'t edit bill because there are some errors in product details.", "Error", MessageBoxButtons.OK);
                    }
                }
                if (ToDo == "Delete")
                {
                    if(DeleteData(BilNo)==false)
                    {
                        MessageBox.Show("Can\'t delete because all product available quantity not updated.", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Qry = "Delete from BillProd_Tab where BillNo = " + BilNo + ";";
                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            Qry = "Delete from Bill_Tab where BillNo = " + BilNo + ";";
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Bill deleted successfully.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Bill products data deleted successfully.\nBill customer data not deleted successfully.", "Information", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bill not deleted successfully.", "Information", MessageBoxButtons.OK);
                        }
                    }
                    
                }

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

            refreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            long Blno;
            if (txtSrchIn.Text.Trim() == "")
            {
                MessageBox.Show("Bill no. can not be empty.", "ERROR", MessageBoxButtons.OK);
            }
            else if (long.TryParse(txtSrchIn.Text, out Blno) == false)
            {
                MessageBox.Show("Bill no. can not be string type.\nEnter the nuberic value.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                if (MainMDIFrm.BillRepLoad == false)
                {
                    BillRepFrm billrepfrm = new BillRepFrm();
                    billrepfrm.MdiParent = this.MdiParent;
                    billrepfrm.billNo = Blno;
                    billrepfrm.Show();
                    MainMDIFrm.BillRepLoad = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Please use form list menu to show print bill form.", "Information", MessageBoxButtons.OK);

            }
        }
               
        private void cmbPrdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            findProdName();
        }

        private void refreshData()
        {
            rbAll.Checked = true;
            rbCstDet.Checked = true;
            txtSrchIn.Text = "";
            rbExist.Checked = true;
            rbNew.Enabled = true;
            cmbCstID.Text = "";
            txtCstName.Text = "";
            txtCstMobNo.Text = "";
            txtCstEmail.Text = "";
            txtCstAddress.Text = "";
            cmbPrdID.Text = "";
            txtPrdQnt.Text = "";
            txtPrdPrise.Text = "";
            lstPrdID.Items.Clear();
            lstPrdName.Items.Clear();
            lstPrdPrise.Items.Clear();
            lstPrdQnt.Items.Clear();
            txtIndex.Text = "";
            gbNewCst.Enabled = false;
            loadCustomers();
            loadProducts();

            btnNew.Enabled = true;
            btnRefresh.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            ToDo = "New";

            if (MainMDIFrm.isAdmin == false)
            {
                gbPrdData.Enabled = false;
            }
        }

        private void loadCustomers()
        {
            try
            {
                cmbCstID.Items.Clear();
                string Qry = "select CusID from Customer_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbCstID.Items.Add(dr.GetInt32(0));
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

        private void loadProducts()
        {
            try
            {
                cmbPrdID.Items.Clear();
                string Qry = "select PrID from Product_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbPrdID.Items.Add(dr.GetInt32(0));
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

        private void showData()
        {

            rbExist.Checked = true;
            rbNew.Enabled = true;
            cmbCstID.Text = "";
            txtCstName.Text = "";
            txtCstMobNo.Text = "";
            txtCstEmail.Text = "";
            txtCstAddress.Text = "";
            cmbPrdID.Text = "";
            txtPrdQnt.Text = "";
            txtPrdPrise.Text = "";
            lstPrdID.Items.Clear();
            lstPrdName.Items.Clear();
            lstPrdPrise.Items.Clear();
            lstPrdQnt.Items.Clear();
            txtIndex.Text = "";
            gbNewCst.Enabled = false;
            loadCustomers();
            loadProducts();

            btnNew.Enabled = true;
            btnRefresh.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;

            if (MainMDIFrm.isAdmin == false)
            {
                gbPrdData.Enabled = false;
            }

            string ClmName;
            string Qry = "";
            long SrcInp = 0;

            if (rbByBillNo.Checked == true)
            {
                if (txtSrchIn.Text.Trim() == "")
                {
                    MessageBox.Show("Bill no. can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else if (long.TryParse(txtSrchIn.Text, out SrcInp) == false)
                {
                    MessageBox.Show("Bill no. can not be string type.\nEnter the nuberic value.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    if (rbPrdDet.Checked == true)
                    {
                        ClmName = " BillNo as [Bill_No] , PrID as [Product_ID] ,  PrName as [Product_Name] , PrSoldUnits as [Sold_Quantity] , ";
                        ClmName = ClmName + " PrSoldPrise as [Selling_Price] ";
                        Qry = "select " + ClmName + " from BillProd_Tab where BillNo = " + SrcInp;
                    }
                    else
                    {
                        ClmName = " BillNo as [Bill_No] , CusID as [Customer_ID] , CusName as [Customer_Name] ,  BillTotAmt as [Total_Bill_Amount] , BillBy as [Added_By] , ";
                        ClmName = ClmName + " BillDate as [Added_Date] , BillEditBy as [Last_Edit_By] , BillEditDate as [Last_Edit_Date] ";
                        Qry = "select " + ClmName + " from Bill_Tab where BillNo = " + SrcInp;
                    }
                }
            }
            else if (rbByName.Checked == true)
            {
                if (txtSrchIn.Text.Trim() == "")
                {
                    MessageBox.Show("Customer name can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    ClmName = " BillNo as [Bill_No] , CusID as [Customer_ID] , CusName as [Customer_Name] ,  BillTotAmt as [Total_Bill_Amount] , BillBy as [Added_By] , ";
                    ClmName = ClmName + " BillDate as [Added_Date] , BillEditBy as [Last_Edit_By] , BillEditDate as [Last_Edit_Date] ";
                    Qry = "select " + ClmName + " from Bill_Tab where CusName like '%" + txtSrchIn.Text + "%'";
                }
            }
            else
            {
                ClmName = " BillNo as [Bill_No] , CusID as [Customer_ID] , CusName as [Customer_Name] ,  BillTotAmt as [Total_Bill_Amount] , BillBy as [Added_By] , ";
                ClmName = ClmName + " BillDate as [Added_Date] , BillEditBy as [Last_Edit_By] , BillEditDate as [Last_Edit_Date] ";
                Qry = "select " + ClmName + " from Bill_Tab;";
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

                if (rbByBillNo.Checked == true && txtSrchIn.Text.Trim() != "")
                {
                    Qry = "select * from Bill_Tab where BillNo = " + SrcInp;
                    cmd.CommandText = Qry;
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        cmbCstID.Text = dr.GetInt32(1).ToString();
                        
                    }

                    if (dr != null)
                        dr.Close();

                    Qry = "select * from BillProd_Tab where BillNo = " + SrcInp;
                    cmd.CommandText = Qry;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lstPrdID.Items.Add(dr.GetInt32(1));
                            lstPrdName.Items.Add(dr.GetString(2));
                            lstPrdQnt.Items.Add(dr.GetFloat(3));
                            lstPrdPrise.Items.Add(dr.GetFloat(4));

                        }
                    }
                    int.TryParse(txtSrchIn.Text, out BilNo);
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

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

        private void findCstName()
        {
            try
            {
                string Qry = "select CusName ,CusMobNo , CusEMail , CusAddrs from Customer_Tab where CusID = " + cmbCstID.Text + ";";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    CstName = dr.GetString(0);
                    txtCstName.Text = CstName;
                    txtCstMobNo.Text = dr.GetString(1);
                    txtCstEmail.Text = dr.GetString(2);
                    txtCstAddress.Text = dr.GetString(3);
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

        private void findProdName()
        {
            try
            {
                MinPrs = 0;
                AvlQnt = 0;
                string Qry = "select PrName , PrMinPrise , PrQunatity from Product_Tab where PrID = " + cmbPrdID.Text + ";";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = null;

                if (ToDo == "Edit")
                {
                    Qry = "select PrSoldUnits from BillProd_Tab where BillNo = " + BilNo + " and PrID = " + cmbPrdID.Text + ";";
                    cmd.CommandText = Qry;
                    dr = cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        dr.Read();
                        AvlQnt = AvlQnt + dr.GetFloat(0);
                    }
                    if (dr != null)
                        dr.Close();
                }

                Qry = "select PrName , PrMinPrise , PrQunatity from Product_Tab where PrID = " + cmbPrdID.Text + ";";
                cmd.CommandText = Qry;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    PrdName = dr.GetString(0);
                    MinPrs = dr.GetFloat(1);
                    AvlQnt = AvlQnt + dr.GetFloat(2);
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

        private bool CreateNewCustomer()
        {
            long MNo=0;
            try
            {
                if (txtCstName.Text.Trim() == "")
                    MessageBox.Show("Customer name can not be empty.", "Information", MessageBoxButtons.OK);
                else if (txtCstMobNo.Text.Trim() == "")
                    MessageBox.Show("Customer mobile no. can not be empty.", "Information", MessageBoxButtons.OK);
                else if (long.TryParse(txtCstMobNo.Text, out MNo) == false)
                    MessageBox.Show("Customer mobile no. is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                else if (txtCstEmail.Text.Trim() == "")
                    MessageBox.Show("Customer E-Mail can not be empty.", "Information", MessageBoxButtons.OK);
                else if (txtCstAddress.Text.Trim() == "")
                    MessageBox.Show("Customer address can not be empty.", "Information", MessageBoxButtons.OK);
                else
                {
                    CstID = getNewCstID();
                    string Qry = "insert into Customer_Tab(CusID,CusName,CusMobNo,CusEMail,CusAddrs) values(";
                    Qry = Qry + CstID + ",'" + txtCstName.Text + "','" + MNo + "','" + txtCstEmail.Text + "','" + txtCstAddress.Text + "');";
                    OleDbConnection con = new OleDbConnection(ConStr);
                    OleDbCommand cmd = new OleDbCommand(Qry, con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        CstName = txtCstName.Text;
                        if (con != null)
                            con.Close();
                        return true;
                    }
                    else
                    {
                        if (con != null)
                            con.Close();
                        return false;
                    }

                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("New customer creating time error.\n"+ex.Message, "Error", MessageBoxButtons.OK);
            }

            return false;
            
        }

        private int getNewCstID()
        {
            int id = 1;
            try
            {
                string Qry = "select max(CusID) from Customer_Tab;";
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

        private int getNewBillNo()
        {
            int id = 1;
            try
            {
                string Qry = "select max(BillNo) from Bill_Tab;";
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

        private void countAmount()
        {
            BillAmt = 0;
            int cntr=0,PrdCnt=0;
            float Qntn=0, Prss=0;
            PrdCnt = lstPrdID.Items.Count;
            if (PrdCnt == lstPrdName.Items.Count && PrdCnt == lstPrdPrise.Items.Count && PrdCnt == lstPrdQnt.Items.Count)
            {
                while(PrdCnt>0)
                {
                    if (float.TryParse(lstPrdQnt.Items[cntr].ToString(), out Qntn) == false)
                    {
                        MessageBox.Show("Total amount count time error.\nProduct quantity have some error.", "ERROR", MessageBoxButtons.OK);
                        return;
                    }
                    else if (float.TryParse(lstPrdPrise.Items[cntr].ToString(), out Prss) == false)
                    {
                        MessageBox.Show("Total amount count time error.\nProduct price have some error.", "ERROR", MessageBoxButtons.OK);
                        return;
                    }
                    else
                        BillAmt = BillAmt + (Qntn * Prss);

                    PrdCnt--;
                    cntr++;
                }
            }

        }

        private bool UpAvlProd(int Pid,float Pqnt,string stt)
        {
            try
            {
                float AvlQnt = 0;
                string Qry= "select PrID , PrQunatity from Product_Tab where PrID = "+Pid;

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    Dr.Read();
                    AvlQnt = Dr.GetFloat(1);
                }

                if (Dr != null)
                    Dr.Close();

                if (stt == "Add")
                {
                    if (UpRemPrd(Pid, Pqnt, stt) == true)
                        Qry = "UPDATE Product_Tab SET [PrQunatity] = " + (AvlQnt - Pqnt) + " where PrID = " + Pid;
                    else
                        return false;
                }
                    
                if (stt == "Remove")
                {
                    if (UpRemPrd(Pid, Pqnt, stt) == true)
                        Qry = "UPDATE Product_Tab SET [PrQunatity] = " + (AvlQnt + Pqnt) + " where PrID = " + Pid;
                    else
                        return false;
                }
                    

                cmd.CommandText = Qry;
                if(cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            return false;
        }

        private bool DeleteData(int bln)
        {
            try
            {
                float sldQnt = 0;
                int pid = 0;
                string Qry = "select PrID , PrSoldUnits from BillProd_Tab where BillNo = " + bln;

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    while(Dr.Read())
                    {
                        pid = Dr.GetInt32(0);
                        sldQnt = Dr.GetFloat(1);
                        UpAvlProd(pid, sldQnt, "Remove");
                    }
                }

                if (Dr != null)
                    Dr.Close();
                
                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private bool UpRemPrdA(int Pid, float Pqnt, string stt)
        {
            try
            {
                int i = 0;
                float remQt=0,entQt=0;
                long entNom = 0, prEntno = 0; 

                string Qry = "select EntryNo , EntryQnt , RemQnt from StoreRoom_Tab where PrID = " + Pid + " and Stat = true;";
                string Qry2 = "select EntryNo , EntryQnt , RemQnt from StoreRoom_Tab where PrID = " + Pid + " and Stat = false order by RemQnt Desc;";

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                OleDbCommand cmd2 = new OleDbCommand(Qry2, con);
                OleDbDataReader Dr2 = cmd2.ExecuteReader();

                
                while (Pqnt>0)
                {
                    if(i==0)
                    {
                        if (Dr.HasRows)
                        {
                            prEntno = entNom;
                            Dr.Read();
                            entNom = Dr.GetInt32(0);
                            entQt = Dr.GetFloat(1);
                            remQt = Dr.GetFloat(2);
                        }

                        if (Dr != null)
                            Dr.Close();
                    }
                    else
                    {
                        if (Dr2.HasRows)
                        {
                            prEntno = entNom;
                            Dr2.Read();
                            entNom = Dr2.GetInt32(0);
                            entQt = Dr2.GetFloat(1);
                            remQt = Dr2.GetFloat(2);
                        }
                    }
                                      
                    if (stt == "Add")
                    {
                        if(remQt==0)
                        {
                            i++;
                            continue;
                        }
                        else if(Pqnt<=remQt)
                        {
                            // set remqt - pqnt & pqnt=0
                            Qry = "Update StoreRoom_Tab Set [RemQnt] = " + (remQt - Pqnt) + " where EntryNo = " + entNom;
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0) { }

                                if (i > 0)
                                {
                                    Qry = "Update StoreRoom_Tab Set [Stat] = false where EntryNo = " + prEntno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0) { }
                                }
                                Pqnt = 0;
                            }
                            else
                                return false;

                            i++;
                        }
                        else
                        {
                            // set pqnt=pqnt-remqt & remqt =0
                            Qry = "Update StoreRoom_Tab Set [RemQnt] = 0 where EntryNo = " + entNom;
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0) { }

                                if (i > 0)
                                {
                                    Qry = "Update StoreRoom_Tab Set [Stat] = false where EntryNo = " + prEntno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0) { }
                                }

                                Pqnt = Pqnt - remQt;
                            }
                            else
                                return false;

                            i++;
                        }
                    }
                    if (stt == "Remove")
                    {
                        if (remQt == entQt)
                        {
                            i++;
                            continue;
                        }
                        else if (Pqnt <= (entQt-remQt))
                        {
                            // set remqt=remqnt+pqnt & pqnt=0
                            Qry = "Update StoreRoom_Tab Set [RemQnt] = " + (remQt + Pqnt) + " where EntryNo = " + entNom;
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0) { }

                                if (i > 0)
                                {
                                    Qry = "Update StoreRoom_Tab Set [Stat] = false where EntryNo = " + prEntno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0) { }
                                }
                                Pqnt = 0;
                            }
                            else
                                return false;

                            i++;
                        }
                        else
                        {
                            // set pqnt=pqnt-(entqt-remqt) & remqt =enqnt
                            Qry = "Update StoreRoom_Tab Set [RemQnt] = " + entQt + " where EntryNo = " + entNom;
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0) { }

                                if (i > 0)
                                {
                                    Qry = "Update StoreRoom_Tab Set [Stat] = false where EntryNo = " + prEntno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0) { }
                                }
                                Pqnt = Pqnt - (entQt - remQt);
                            }
                            else
                                return false;

                            i++;
                        }
                    }
                }

                
                if (Dr != null)
                    Dr.Close();

                if (Dr2 != null)
                    Dr2.Close();

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void BillFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.BillLoad = false;
        }

        private bool UpRemPrd(int Pid, float Pqnt, string stt)
        {
            try
            {
                float remQt = 0, entQt = 0;
                long entNom = 0, prEntno = 0;

                string Qry = "select EntryNo , EntryQnt , RemQnt from StoreRoom_Tab where PrID = " + Pid + " and Stat = true;";
                
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = cmd.ExecuteReader();

                if(Dr.HasRows)
                {
                    prEntno = entNom;
                    Dr.Read();
                    entNom = Dr.GetInt32(0);
                    entQt = Dr.GetFloat(1);
                    remQt = Dr.GetFloat(2);

                    if (Dr != null)
                        Dr.Close();

                    while (Pqnt > 0)
                    {
                        if (stt == "Add")
                        {
                            if (remQt == 0)
                            {
                                Qry = "select EntryNo , EntryQnt , RemQnt from StoreRoom_Tab where PrID = " + Pid + " and EntryNo > " + entNom + " Order By EntryNo;";
                                cmd.CommandText = Qry;
                                Dr = cmd.ExecuteReader();
                                if (Dr.HasRows)
                                {
                                    prEntno = entNom;
                                    Dr.Read();
                                    entNom = Dr.GetInt32(0);
                                    entQt = Dr.GetFloat(1);
                                    remQt = Dr.GetFloat(2);
                                    
                                    if (Dr != null)
                                        Dr.Close();

                                    Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + entNom;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() <= 0)
                                        return false;

                                    Qry = "Update StoreRoom_Tab Set [Stat] = false where EntryNo = " + prEntno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() <= 0)
                                        return false;
                                }
                                else
                                    return false;
                            }  
                            else if (Pqnt <= remQt)
                            {
                                Qry = "Update StoreRoom_Tab Set [RemQnt] = " + (remQt - Pqnt) + " where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    remQt = remQt - Pqnt;
                                    Pqnt = 0;
                                }
                                else
                                    return false;
                            }
                            else
                            {
                                Qry = "Update StoreRoom_Tab Set [RemQnt] = 0 where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    Pqnt = Pqnt - remQt;
                                    remQt = 0;
                                }
                                else
                                    return false;
                            }

                        }
                        if (stt == "Remove")
                        {
                            if (remQt == entQt)
                            {
                                Qry = "select EntryNo ,EntryQnt , RemQnt from StoreRoom_Tab where PrID = " + Pid + " and EntryNo < " + entNom + " Order By EntryNo Desc;";
                                cmd.CommandText = Qry;
                                Dr = cmd.ExecuteReader();
                                if (Dr.HasRows)
                                {
                                    prEntno = entNom;
                                    Dr.Read();
                                    entNom = Dr.GetInt32(0);
                                    entQt = Dr.GetFloat(1);
                                    remQt = Dr.GetFloat(2);

                                    if (Dr != null)
                                        Dr.Close();

                                    Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + entNom;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() <= 0)
                                        return false;

                                    Qry = "Update StoreRoom_Tab Set [Stat] = false where EntryNo = " + prEntno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() <= 0)
                                        return false;
                                }
                                else
                                    return false;
                            }
                            else if (Pqnt <= (entQt - remQt))
                            {
                                Qry = "Update StoreRoom_Tab Set [RemQnt] = " + (remQt + Pqnt) + " where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    remQt = remQt + Pqnt;
                                    Pqnt = 0;
                                }
                                else
                                    return false;
                            }
                            else
                            {
                                Qry = "Update StoreRoom_Tab Set [RemQnt] = " + entQt + " where EntryNo = " + entNom;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    Pqnt = Pqnt - (entQt - remQt);
                                    remQt = entQt;
                                    
                                }  
                                else
                                    return false;

                            }
                        }
                    }
                }
                else
                {
                    if (Dr != null)
                        Dr.Close();
                    if (con != null)
                        con.Close();
                    return false;
                }
                if (Dr != null)
                    Dr.Close();

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }



    }
}
