using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_with_Point_of_Sale_System
{
    public partial class frmReports : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da = new SqlDataAdapter();

        public frmReports()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            DateTime from = Convert.ToDateTime(dtpFrom.Text);
            Global.dateFrom = from.ToString("MMMM dd, yyyy");
            DateTime to = Convert.ToDateTime(dtpTo.Text);
            Global.dateTo = to.ToString("MMMM dd, yyyy");
            if (txtHEading.Text == "")
            {
                Global.reportHeading = "SALES REPORT";
            }
            else
            {
                Global.reportHeading = txtHEading.Text.ToUpper();
            }

            getSeedReportData();
            getEquipmentReportData();
            getOthersReportData();

            
            frmPrintSalesReport printreport = new frmPrintSalesReport();
            printreport.Show();
            this.Hide();
            
        }

        private void getSeedReportData()
        {
            string query = "SELECT SUM(Qty) AS 'Total Quantity', SUM(ProdSales) AS 'Total Sales' FROM tblIN_Out WHERE Date BETWEEN @FROM AND @TO AND TransType='Out' AND ProdType='Seeds'";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("FROM", dtpFrom.Text);
            com.Parameters.AddWithValue("TO", dtpTo.Text);
            DataTable dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            dtgReport.DataSource = dt;

            if (dtgReport.Rows[0].Cells[0].Value.ToString() == "")
            {
                Global.seedQuantity = "0";
                Global.seedAmount = "0";
            }
            else
            {
                Global.seedQuantity = dtgReport.Rows[0].Cells[0].Value.ToString();
                Global.seedAmount = dtgReport.Rows[0].Cells[1].Value.ToString();
            }
        }

        private void getEquipmentReportData()
        {
            string query = "SELECT SUM(Qty) AS 'Total Quantity', SUM(ProdSales) AS 'Total Sales' FROM tblIN_Out WHERE Date BETWEEN @FROM AND @TO AND TransType='Out' AND ProdType='Equipments'";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("FROM", dtpFrom.Text);
            com.Parameters.AddWithValue("TO", dtpTo.Text);
            DataTable dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            dtgReport.DataSource = dt;


            if (dtgReport.Rows[0].Cells[0].Value.ToString()=="")
            {
                Global.eqptQuantity = "0";
                Global.eqptAmount = "0";
            }
            else
            {
                Global.eqptQuantity = dtgReport.Rows[0].Cells[0].Value.ToString();
                Global.eqptAmount = dtgReport.Rows[0].Cells[1].Value.ToString();
            }

            
        }

        private void getOthersReportData()
        {
            string query = "SELECT SUM(Qty) AS 'Total Quantity', SUM(ProdSales) AS 'Total Sales' FROM tblIN_Out WHERE Date BETWEEN @FROM AND @TO AND TransType='Out' AND ProdType='Others'";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("FROM", dtpFrom.Text);
            com.Parameters.AddWithValue("TO", dtpTo.Text);
            DataTable dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            dtgReport.DataSource = dt;

            if (dtgReport.Rows[0].Cells[0].Value.ToString() == "")
            {
                Global.othersQuantity = "0";
                Global.othersAmount = "0";
            }
            else
            {
                Global.othersQuantity = dtgReport.Rows[0].Cells[0].Value.ToString();
                Global.othersAmount = dtgReport.Rows[0].Cells[1].Value.ToString();
            }
            
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dtgReport.Visible = false;
            btnQuantityReport.Visible = false;
        }

        private void btnQuantityReport_Click(object sender, EventArgs e)
        {
            frmPrintQuantity quantity = new frmPrintQuantity();
            quantity.Show();
        }
    }
}
