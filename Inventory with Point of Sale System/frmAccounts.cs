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
    public partial class frmAccounts : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da = new SqlDataAdapter();
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditAcct addeditacct = new frmAddEditAcct();
            this.Hide();
            addeditacct.Show();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            string query = "SELECT UserName, PassWord FROM tblAccounts";
            SqlCommand com = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            dtgAccounts.DataSource = dt;
        }
    }
}
