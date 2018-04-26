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
    public partial class frmInOut : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        string prodTypeSelection = "Seeds";
        string transTypeSelection = "In";

        public frmInOut()
        {
            InitializeComponent();

            
        }

        private void frmInOut_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            lblSumSales.Visible = false;

            if (dtgProdFlow.Rows.Count >= 1)
            {
                dtgProdFlow.Columns[1].Width = 500;
            }
            pbpHIdeEyes.Visible = true;

            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out ORDER BY Date", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            //BindingSource bsource = new BindingSource();
            dtgProdFlow.DataSource = dataTbl;

            rbInflow.Checked = true;
            dtgProdFlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pbHidePanel_Click(object sender, EventArgs e)
        {
            


        }

        private void pbHidePanel_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
            lblSumSales.Visible = true;


            dtgProdFlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            Global.panelHide = false;
            panel2.Width = 230;
            pbHidePanel.Visible = false;
            pbpHIdeEyes.Visible = true;
            lblSearch.Visible = true;
            txtSearch.Visible = true;
            lblTo.Visible = true;
            lblFrom.Visible = true;
            dtpFrom.Visible = true;
            dtpTo.Visible = true;
            btnSearch.Visible = true;
            lblProdType.Visible = true;
            cmbProdType.Visible = true;
            rbInflow.Visible = true;
            rbOutflow.Visible = true;
            btnBack.Visible = false;
            btnExit.Visible = false;

            dtgProdFlow.Size = new Size(562, 413);
            dtgProdFlow.Location = new Point(230, 52);
            dtgProdFlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void pbpHIdeEyes_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
            lblSumSales.Visible = false;


            Global.panelHide = true;
            panel2.Width = 74;
            pbHidePanel.Location = new Point(14, 13);
            pbHidePanel.Visible = true;
            pbpHIdeEyes.Visible = false;
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            lblTo.Visible = false;
            lblFrom.Visible = false;
            dtpFrom.Visible = false;
            dtpTo.Visible = false;
            btnSearch.Visible = false;
            lblProdType.Visible = false;
            cmbProdType.Visible = false;
            rbInflow.Visible = false;
            rbOutflow.Visible = false;
            btnBack.Visible = true;
            btnExit.Visible = true;

            dtgProdFlow.Size = new Size(720, 413);
            dtgProdFlow.Location = new Point(72, 52);
            dtgProdFlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbProdType.Text == "All")
            {
                DateTime dt1 = Convert.ToDateTime(dtpFrom.Value.ToShortDateString());
                DateTime dt2 = Convert.ToDateTime(dtpTo.Value.ToShortDateString());

                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out WHERE Date >= '" + dt1.ToShortDateString() + "' AND Date <= '" + dt2.ToShortDateString() + "' AND TransType = '" + transTypeSelection + "' ORDER BY Date", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgProdFlow.DataSource = dataTbl;
            }

            else
            {
                DateTime dt1 = Convert.ToDateTime(dtpFrom.Value.ToShortDateString());
                DateTime dt2 = Convert.ToDateTime(dtpTo.Value.ToShortDateString());

                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out WHERE Date >= '" + dt1.ToShortDateString() + "' AND Date <= '" + dt2.ToShortDateString() + "' AND TransType = '" + transTypeSelection + "' AND ProdType = '" + prodTypeSelection + "' ORDER BY Date", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgProdFlow.DataSource = dataTbl;

            }

            getTotalSales();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {



            if(cmbProdType.Text=="All")
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out WHERE Descr LIKE '" + "%" + txtSearch.Text + "%" + "' AND TransType = '" + transTypeSelection + "'", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgProdFlow.DataSource = dataTbl;
            }
            else if (cmbProdType.Text == "Seeds" || cmbProdType.Text == "Equipments" || cmbProdType.Text == "Others")
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out WHERE Descr LIKE '" + "%" + txtSearch.Text + "%" + "' AND TransType = '" + transTypeSelection + "' AND ProdType ='" + prodTypeSelection + "'", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgProdFlow.DataSource = dataTbl;
            }
            else
            {

            }

            getTotalSales();
            
            
        }

        private void getTotalSales()
        {
            if (rbOutflow.Checked == true && dtgProdFlow.Rows.Count >= 1)
            {
                double finalSum = 0;
                double sum;
                for (int i = 0; i < dtgProdFlow.Rows.Count; i++)
                {
                    sum = double.Parse(dtgProdFlow.Rows[i].Cells[7].Value.ToString());

                    finalSum += sum;

                }
                //MessageBox.Show(finalSum.ToString());
                lblSumSales.Text = finalSum.ToString("₱ ###,###.#0");
            }
            else
            {
                lblSumSales.Text = "- -";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void rbInflow_CheckedChanged(object sender, EventArgs e)
        {
            transTypeSelection = "In";

            if (rbInflow.Checked == true)
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out WHERE TransType = 'In' ORDER  BY Date", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgProdFlow.DataSource = dataTbl;
            }
            else if (rbOutflow.Checked == true)
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, DRNumber AS 'DR Number', Date , ProdType AS 'Product Type' , TransType AS 'Transaction Type' , ProdSales AS 'Product Sales' FROM tblIn_Out WHERE TransType = 'Out' ORDER BY Date", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgProdFlow.DataSource = dataTbl;
            }
        }

        private void cmbProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodTypeSelection = cmbProdType.Text;
        }

        private void rbOutflow_CheckedChanged(object sender, EventArgs e)
        {
            transTypeSelection = "Out";
        }

        private void lblExitForm_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }
    }
}
