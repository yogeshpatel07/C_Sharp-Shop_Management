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
    public partial class StoreFrm : Form
    {
        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMDIFrm.DataPathF + "\\DataBase\\MyShope.accdb;Persist Security Info=False";

        int EntNo = 0;
        float EntQnt=0,RemQnt=0,TotQnt=0;
        string ToDo;

        public StoreFrm()
        {
            InitializeComponent();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                txtEntNo.Enabled = false;
            }
        }

        private void rbProdID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProdID.Checked == true)
            {
                txtEntNo.Enabled = true;
                lblEntNo.Text = "Enter Product ID :";
            }
        }

        private void rbSuppID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuppID.Checked == true)
            {
                txtEntNo.Enabled = true;
                lblEntNo.Text = "Enter Supplier ID :";
            }
        }

        private void rbEntNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEntNo.Checked == true)
            {
                txtEntNo.Enabled = true;
                lblEntNo.Text = "Enter Entry No :";
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
        
        private void StoreFrm_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadSuppliers();
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbPrdID.Text = "";
            txtPrdQnt.Text = "";
            lblUnit.Text = "";
            cmbSuppID.Text = "";


            cmbPrdID.Enabled = true;
            cmbSuppID.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPrdQnt.Text = "";

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
                float NQuant = 0;
                float OldQuant = 0;

                string Qry = "select * from StoreRoom_Tab;";

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                if (ToDo == "New")
                {
                    if (cmbPrdID.Text.Trim() == "")
                        MessageBox.Show("Product id can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtPrdQnt.Text.Trim() == "")
                        MessageBox.Show("Product quantity can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (float.TryParse(txtPrdQnt.Text, out NQuant) == false)
                        MessageBox.Show("Product quantity value is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                    else if (cmbSuppID.Text.Trim() == "")
                        MessageBox.Show("Supplier id can not be empty.", "Information", MessageBoxButtons.OK);
                    else
                    {
                        EntNo = getEntID();

                        Qry = "insert into StoreRoom_Tab(EntryNo,EntryBy,EntryDate,PrID,EntryQnt,RemQnt,SupID) values(";
                        Qry = Qry + EntNo + ",'" + MainMDIFrm.UserName + "',#" + DateTime.Now + "#," + cmbPrdID.Text+",";
                        Qry = Qry + NQuant + "," + NQuant +","+ cmbSuppID.Text+");";
                        cmd.CommandText = Qry;

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            Qry = "select PrQunatity from Product_Tab where PrID = "+cmbPrdID.Text+";";
                            cmd.CommandText = Qry;

                            OleDbDataReader Dr = cmd.ExecuteReader();
                            if(Dr.HasRows)
                            {
                                Dr.Read();
                                OldQuant = Dr.GetFloat(0);
                            }

                            if (Dr != null)
                                Dr.Close();

                            Qry = "UPDATE Product_Tab SET [PrQunatity] ="+(OldQuant+NQuant)+ " where PrID = " + cmbPrdID.Text + ";";
                            cmd.CommandText = Qry;
                            
                            if(cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Product added.", "Information", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Product added but product total quantity not updated successfully.", "Information", MessageBoxButtons.OK);
                            }
                            SetState(int.Parse(cmbPrdID.Text));
                             
                        }
                        else
                        {
                            MessageBox.Show("Product not added.", "ERROR", MessageBoxButtons.OK);
                        }
                    }
                }

                if (ToDo == "Edit")
                {
                    if (cmbPrdID.Text.Trim() == "")
                        MessageBox.Show("Product id can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (txtPrdQnt.Text.Trim() == "")
                        MessageBox.Show("Product quantity can not be empty.", "Information", MessageBoxButtons.OK);
                    else if (float.TryParse(txtPrdQnt.Text, out NQuant) == false)
                        MessageBox.Show("Product quantity value is invalid.\nEnter a numberic value.", "Information", MessageBoxButtons.OK);
                    else if (cmbSuppID.Text.Trim() == "")
                        MessageBox.Show("Supplier id can not be empty.", "Information", MessageBoxButtons.OK);
                    else
                    {
                        if(EntQnt>TotQnt)
                        {
                            if(MessageBox.Show("Previous entered quantity is bigger than total available quantity.\nIf you edit it can make some errors.\nDo you want to edit?","Information",MessageBoxButtons.YesNo)==DialogResult.Yes)
                            {
                                Qry = "UPDATE StoreRoom_Tab SET [EntryQnt] =" + (NQuant) + " , [RemQnt] = " + (NQuant + (EntQnt - RemQnt)) + " , [SupID] = " + cmbSuppID.Text;
                                Qry=Qry+ " , [EntryEditBy] = '" + MainMDIFrm.UserName + "' , [EntryEditDate] = #" + DateTime.Now +  "# where EntryNo = " + EntNo + ";";

                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    Qry = "UPDATE Product_Tab SET [PrQunatity] = " + (NQuant + (TotQnt - EntQnt)) + " where PrID = " + cmbPrdID.Text + ";";

                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("Product edited.", "Information", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Product edited but product total quantity not updated successfully.", "ERROR", MessageBoxButtons.OK);
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Product not edited.", "ERROR", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            Qry = "UPDATE StoreRoom_Tab SET [EntryQnt] =" + (NQuant) + " , [RemQnt] = " + (NQuant + (EntQnt - RemQnt)) + " , [SupID] = " + cmbSuppID.Text;
                            Qry = Qry + " , [EntryEditBy] = '" + MainMDIFrm.UserName + "' , [EntryEditDate] = #" + DateTime.Now + "# where EntryNo = " + EntNo + ";";


                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                
                                Qry = "UPDATE Product_Tab SET [PrQunatity] = " + (NQuant + (TotQnt - EntQnt)) + " where PrID = " + cmbPrdID.Text + ";";

                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Product edited.", "Information", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Product edited but product total quantity not updated successfully.", "ERROR", MessageBoxButtons.OK);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Product not edited.", "ERROR", MessageBoxButtons.OK);
                            }
                        }
                    }
                }

                if (ToDo == "Delete")
                {

                    if (EntQnt > TotQnt)
                    {
                        if (MessageBox.Show("Previous entered quantity is bigger than total available quantity.\nIf you delete it can make some errors.\nDo you want to delete?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Qry = "Delete from  Product_Tab where [PrID]=" + EntNo;
                            Qry = "UPDATE Product_Tab SET [PrQunatity] = " + (NQuant + (TotQnt - EntQnt)) + " where PrID = " + cmbPrdID.Text + ";";

                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Qry = "Delete from  StoreRoom_Tab where [EntryNo]=" + EntNo;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Entry deleted.", "Information", MessageBoxButtons.OK);
                                    SetState(int.Parse(cmbPrdID.Text));
                                }
                                else
                                {
                                    MessageBox.Show("Entery not deleted successfully.", "ERROR", MessageBoxButtons.OK);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Entery not deleted successfully.\nBecause product total quantity can\'t updated.", "ERROR", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        Qry = "UPDATE Product_Tab SET [PrQunatity] = " + (NQuant + (TotQnt - EntQnt)) + " where PrID = " + cmbPrdID.Text + ";";

                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            Qry = "Delete from  StoreRoom_Tab where [EntryNo]=" + EntNo;
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Entry deleted.", "Information", MessageBoxButtons.OK);
                                SetState(int.Parse(cmbPrdID.Text));
                            }
                            else
                            {
                                MessageBox.Show("Entery not deleted successfully.", "ERROR", MessageBoxButtons.OK);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Entery not deleted successfully.\nBecause product total quantity can\'t updated.", "ERROR", MessageBoxButtons.OK);
                        }
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
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            cmbPrdID.Enabled = true;
            cmbSuppID.Enabled = true;


                
        }

        private void cmbPrdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Qry = "select PrUnit from Product_Tab where PrID = " + cmbPrdID.Text + ";";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    lblUnit.Text = dr.GetString(0);
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


        private int getEntID()
        {
            int id = 1;
            try
            {
                string Qry = "select max(EntryNo) from StoreRoom_Tab;";
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
            cmbPrdID.Text = "";
            txtPrdQnt.Text = "";
            lblUnit.Text = "";
            cmbSuppID.Text = "";

            string ClmName = " St.EntryNo as [Entry_No] , St.PrID as [Product_ID] , Pd.PrName as [Product_Name] , St.EntryQnt as [Entry_Quantity] , ";
            ClmName = ClmName + " St.RemQnt as [Left_Quantity ] ,Pd.PrQunatity as [Total_Quantity] , Pd.PrMinPrise as [Minimum_Price] , Pd.PrUnit as [Units] , ";
            ClmName = ClmName + " St.EntryBy as [Added_By] , St.EntryDate as [Added_Date] , St.EntryEditBy as [Last_Edit_By] , St.EntryEditDate as [Last_Edit_Date] , ";
            ClmName = ClmName + " St.SupID as [Supplier_ID] ";

            string Qry = "select " + ClmName + " from StoreRoom_Tab St , Product_Tab Pd where St.PrID = Pd.PrID;";

            if (rbProdID.Checked == true)
            {
                if (txtEntNo.Text.Trim() == "")
                {
                    MessageBox.Show("Product id can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    Qry = "select " + ClmName + " from StoreRoom_Tab St , Product_Tab Pd where St.PrID = Pd.PrID and  St.PrID = " + txtEntNo.Text;
                }
            }
            else if (rbSuppID.Checked == true)
            {
                if (txtEntNo.Text.Trim() == "")
                {
                    MessageBox.Show("Product id can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    Qry = "select " + ClmName + " from StoreRoom_Tab St , Product_Tab Pd where St.PrID = Pd.PrID and  St.SupID = " + txtEntNo.Text;
                }
            }
            else if (rbEntNo.Checked == true)
            {
                if (txtEntNo.Text.Trim() == "")
                {
                    MessageBox.Show("Product id can not be empty.", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    Qry = "select " + ClmName + " from StoreRoom_Tab St , Product_Tab Pd where St.PrID = Pd.PrID and  St.EntryNo = " + txtEntNo.Text;
                }
            }
            else
            {
                Qry = "select " + ClmName + " from StoreRoom_Tab St , Product_Tab Pd where St.PrID = Pd.PrID;";
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
                dGView.Columns[9].DefaultCellStyle.Format = "dd-MM-yyyy  hh:mm:ss tt ";
                dGView.Columns[11].DefaultCellStyle.Format = "dd-MM-yyyy  hh:mm:ss tt ";



                if (rbEntNo.Checked == true && txtEntNo.Text.Trim() != "")
                {
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        cmbPrdID.Text = dr.GetInt32(1).ToString();
                        txtPrdQnt.Text = dr.GetFloat(3).ToString();
                        lblUnit.Text = dr.GetString(7);
                        cmbSuppID.Text = dr.GetInt32(12).ToString();
                        EntNo = dr.GetInt32(0);

                        EntQnt = dr.GetFloat(3);
                        RemQnt = dr.GetFloat(4);
                        TotQnt = dr.GetFloat(5);

                        cmbPrdID.Enabled = false;
                        //cmbSuppID.Enabled = false;
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

        private void StoreFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.StoreLoad = false;
        }

        private void loadSuppliers()
        {
            try
            {
                cmbSuppID.Items.Clear();

                string Qry = "select SupID from Supplier_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbSuppID.Items.Add(dr.GetInt32(0));
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

        private void SetStateA(int Pid)
        {
            try
            {
                string Qry = "select EntryNo from StoreRoom_Tab;";

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = null;

                Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and Stat = true;";
                cmd.CommandText = Qry;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    try
                    {
                        dr.Read();
                        int eno = dr.GetInt32(0);
                        return;
                    }
                    catch (Exception)
                    {
                        if (dr != null)
                            dr.Close();

                        Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo=" + EntNo;
                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                            return;
                    }                    
                }
                else
                {
                    if (dr != null)
                        dr.Close();
                    Qry = "select EntryNo , RemQnt from StoreRoom_Tab where PrID = " + Pid+ " order by RemQnt Desc;";
                    cmd.CommandText = Qry;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        int eno = dr.GetInt32(0);

                        if (dr != null)
                            dr.Close();

                        Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + eno;
                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                            return;
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

        private void SetState(int Pid)
        {
            try
            {
                string Qry = "select EntryNo from StoreRoom_Tab;";

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader dr = null;

                if (ToDo == "New")
                {
                    Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and Stat = true;";
                    cmd.CommandText = Qry;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        try
                        {
                            dr.Read();
                            int eno = dr.GetInt32(0);
                            return;
                        }
                        catch (Exception)
                        {
                            if (dr != null)
                                dr.Close();

                            Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo=" + EntNo;
                            cmd.CommandText = Qry;
                            if (cmd.ExecuteNonQuery() > 0)
                                return;
                        }
                    }
                    else
                    {
                        if (dr != null)
                            dr.Close();

                        Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo=" + EntNo;
                        cmd.CommandText = Qry;
                        if (cmd.ExecuteNonQuery() > 0)
                            return;
                    }
                }

                if (ToDo == "Delete")
                {
                    Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and Stat = true;";
                    cmd.CommandText = Qry;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        try
                        {
                            dr.Read();
                            int eno = dr.GetInt32(0);
                            return;
                        }
                        catch (Exception)
                        {
                            if (dr != null)
                                dr.Close();

                            Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and EntryNo <" + EntNo + " Order By EntryNo Desc;";
                            cmd.CommandText = Qry;
                            dr = cmd.ExecuteReader();
                            if (dr.HasRows)
                            {
                                try
                                {
                                    dr.Read();
                                    int eno = dr.GetInt32(0);

                                    if (dr != null)
                                        dr.Close();

                                    Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + eno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0)
                                        return;
                                }
                                catch (Exception) { }
                            }

                            if (dr != null)
                                dr.Close();

                            Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and EntryNo >" + EntNo + " Order By EntryNo;";
                            cmd.CommandText = Qry;
                            dr = cmd.ExecuteReader();
                            if (dr.HasRows)
                            {
                                try
                                {
                                    dr.Read();
                                    int eno = dr.GetInt32(0);

                                    if (dr != null)
                                        dr.Close();

                                    Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + eno;
                                    cmd.CommandText = Qry;
                                    if (cmd.ExecuteNonQuery() > 0)
                                        return;
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                    else
                    {
                        if (dr != null)
                            dr.Close();

                        Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and EntryNo <" + EntNo + " Order By EntryNo Desc;";
                        cmd.CommandText = Qry;
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            try
                            {
                                dr.Read();
                                int eno = dr.GetInt32(0);

                                if (dr != null)
                                    dr.Close();

                                Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + eno;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                    return;
                            }
                            catch (Exception) { }
                        }

                        if (dr != null)
                            dr.Close();

                        Qry = "select EntryNo from StoreRoom_Tab where PrID = " + Pid + " and EntryNo >" + EntNo + " Order By EntryNo;";
                        cmd.CommandText = Qry;
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            try
                            {
                                dr.Read();
                                int eno = dr.GetInt32(0);

                                if (dr != null)
                                    dr.Close();

                                Qry = "Update StoreRoom_Tab Set [Stat] = true where EntryNo = " + eno;
                                cmd.CommandText = Qry;
                                if (cmd.ExecuteNonQuery() > 0)
                                    return;
                            }
                            catch (Exception) { }
                        }
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


    }
}
