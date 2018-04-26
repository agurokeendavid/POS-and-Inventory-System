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
    public partial class frmMonitorInventory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
         
        public frmMonitorInventory()
        {
            InitializeComponent();
        }

        private void frmMonitorInventory_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1)
            {
                dataGridView1.Columns[0].Width = dataGridView1.Width / 2;
            }

            DataTable dt2 = new DataTable();
            dt2.Clear();
            SqlCommand sqlCom = new SqlCommand("SELECT Descr, Qty, Unit FROM tblProducts Where Qty < 6 AND BigItem!='True'", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            sqlSda.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void btnLowQty_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            SqlCommand sqlCom = new SqlCommand("SELECT  Descr, Qty, Unit FROM tblProducts Where Qty < 6 AND BigItem!='True'", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            sqlSda.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void btnLowQtyBI_Click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            dt3.Clear();
            SqlCommand sqlCom = new SqlCommand("SELECT  Descr, Qty, Unit FROM tblProducts Where BigItem='True' AND Qty < 2", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            sqlSda.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            this.Hide();
            inventory.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            this.Hide();
            inventory.Show();
        }
    }
}
