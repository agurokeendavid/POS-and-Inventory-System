using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Inventory_with_Point_of_Sale_System
{
    public partial class frmMain : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da = new SqlDataAdapter();
        Point lastPoint;

        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (del == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            //lblCloseForm.ForeColor = System.Drawing.Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            lblCloseForm.ForeColor = System.Drawing.Color.White;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            this.Hide();
            sales.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            this.Hide();
            inventory.Show();
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            SqlCommand sqlCom = new SqlCommand("SELECT * FROM tblAds WHERE Name='"+Global.advertisementName+"'", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            dataGridView1.DataSource = dataTbl;

            dataGridView1.Visible = false;

            if (dataGridView1.Rows.Count >= 1)
            {
                byte[] imgg = (byte[])(dataGridView1.SelectedRows[0].Cells[1].Value);
                MemoryStream mstream = new MemoryStream(imgg);
                pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
            }
            //pictureBox2.Image = Image.FromFile(@"d:\Users\client\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\Resources\"+Global.advertisementName+"");
            lblLogoText.Text = "Capiz New Agri-Industrial Systems" + Environment.NewLine + "and General Services Inc." + Environment.NewLine + "POS with Inventory System";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (del == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports report = new frmReports();
            this.Hide();

            report.Show();
        }

        private void btnProdInOut_Click(object sender, EventArgs e)
        {
            frmInOut inout = new frmInOut();
            inout.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAds_Click(object sender, EventArgs e)
        {
            frmAdvertisement ads = new frmAdvertisement();
            this.Hide();
            ads.Show();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmAccounts accont = new frmAccounts();
            this.Hide();
            accont.Show();
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            frmGraphics graphics = new frmGraphics();
            this.Hide();
            graphics.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            this.Hide();
            settings.Show();
        }
    }
}
