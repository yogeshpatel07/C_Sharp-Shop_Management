using Microsoft.Reporting.WinForms;
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
    public partial class BillRepFrm : Form
    {
        public static string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMDIFrm.DataPathF + "\\DataBase\\MyShope.accdb;Persist Security Info=False";

        public long billNo = 0;
        public BillRepFrm()
        {
            InitializeComponent();
        }

        private void BillRepFrm_Load(object sender, EventArgs e)
        {
            loadBill();
        }

        private void BillRepFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMDIFrm.BillRepLoad = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (txtBlNo.Text.Trim() == "")
            {
                MessageBox.Show("Bill no. can not be empty.", "ERROR", MessageBoxButtons.OK);
            }
            else if (long.TryParse(txtBlNo.Text, out billNo) == false)
            {
                MessageBox.Show("Bill no. can not be string type.\nEnter the nuberic value.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                loadBill();
            }
        }

        private void loadBill()
        {
            try
            {
                DataSet1.PrdTable.Clear();
                long CstNo = 0;
                string Qry = "select PrName, PrSoldUnits, PrSoldPrise from BillProd_Tab where BillNo = " + billNo;
                ReportParameterCollection Rpc = new ReportParameterCollection();
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                        DataSet1.PrdTable.AddPrdTableRow(dr.GetString(0), dr.GetFloat(1).ToString(), dr.GetFloat(2).ToString());
                }
                if (dr != null)
                    dr.Close();

                ReportDataSource rds = new ReportDataSource("DataSet1", PrdTableBindingSource);
                Qry = "SELECT BillNo, CusID, CusName, BillTotAmt, BillDate FROM Bill_Tab where BillNo = " + billNo;
                cmd.CommandText = Qry;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Rpc.Add(new ReportParameter("BillNo", dr.GetInt32(0).ToString()));
                    CstNo = dr.GetInt32(1);
                    Rpc.Add(new ReportParameter("CstName", dr.GetString(2)));
                    Rpc.Add(new ReportParameter("TotalAmt", dr.GetFloat(3).ToString()));
                    Rpc.Add(new ReportParameter("BillDate", dr.GetDateTime(4).ToString("dd-MM-yyyy hh:mm:ss tt ")));
                }
                if (dr != null)
                    dr.Close();

                Qry = "SELECT CusID, CusName, CusMobNo, CusAddrs FROM Customer_Tab where CusID = " + CstNo;
                cmd.CommandText = Qry;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Rpc.Add(new ReportParameter("CstMob", dr.GetString(2)));
                    Rpc.Add(new ReportParameter("CstAddrs", dr.GetString(3)));
                }
                if (dr != null)
                    dr.Close();

                this.repView.LocalReport.SetParameters(Rpc);

                repView.LocalReport.DataSources.Clear();
                repView.LocalReport.DataSources.Add(rds);
                repView.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
