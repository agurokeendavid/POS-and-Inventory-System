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
    public partial class frmLogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        Point lastPoint;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("SELECT * FROM tblAccounts WHERE UserName LIKE @USN AND PassWord LIKE @PWD", con);

            com.Parameters.AddWithValue("@USN", txtUserName.Text);
            com.Parameters.AddWithValue("@PWD", txtPassWord.Text);

            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda.SelectCommand = com;
            sda.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                frmMain main = new frmMain();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Access Denied!");
                txtPassWord.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogIn;
            this.CancelButton = btnCancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            //label4.ForeColor = System.Drawing.Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            //label4.ForeColor = System.Drawing.Color.White;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

    }
}
