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
    public partial class frmAdvertisement : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da = new SqlDataAdapter();

        public frmAdvertisement()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAdvertisementAdd addnew = new frmAdvertisementAdd();
            this.Hide();
            addnew.Show();
        }

        private void frmAdvertisement_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM tblAds", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            dataGridView1.DataSource = dataTbl;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            if (dataGridView1.Rows.Count >= 1)
            {
                Global.ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                byte[] imgg = (byte[])(dataGridView1.SelectedRows[0].Cells[1].Value);
                MemoryStream mstream = new MemoryStream(imgg);
                pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Global.advertisementName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //MessageBox.Show(Global.advertisementName);
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Global.ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            byte[] imgg = (byte[])(dataGridView1.SelectedRows[0].Cells[1].Value);
            MemoryStream mstream = new MemoryStream(imgg);
            pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
            //MessageBox.Show(Global.ID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (del == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from tblAds WHERE (ID='" + Global.ID + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frmAdvertisement_Load(this, null);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM tblAds WHERE Name Like '"+"%"+txtSearch.Text+"%"+"'", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            dataGridView1.DataSource = dataTbl;

            if (dataGridView1.Rows.Count >= 1)
            {
                Global.ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                byte[] imgg = (byte[])(dataGridView1.SelectedRows[0].Cells[1].Value);
                MemoryStream mstream = new MemoryStream(imgg);
                pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                //MessageBox.Show(Global.ID);
            }
        }

        
    }
}
