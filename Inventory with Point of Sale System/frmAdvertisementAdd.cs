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
    public partial class frmAdvertisementAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da = new SqlDataAdapter();
        string name;
        public frmAdvertisementAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnSelectSave.Text == "Select GIF File")
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dlg.FileName.ToString();

                    pictureBox1.ImageLocation = imagePath;
                    txtPath.Text = imagePath;
                }

                name = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName) + System.IO.Path.GetExtension(dlg.FileName);
            }
            else if (btnSelectSave.Text == "Save")
            {
                if (txtPath.Text == "")
                {
                    MessageBox.Show("Select an Image.");
                }
                else
                {
                    byte[] imagebyte = null;
                    FileStream fstream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imagebyte = br.ReadBytes((int)fstream.Length);



                    string query = "INSERT INTO tblAds(Image, Name) VALUES(@IMG,@name)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@IMG", imagebyte);
                    cmd.Parameters.AddWithValue("@name", name);
                    con.Open();
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Image saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPath.Text = "";
                    btnSelectSave.Text = "Select GIF File";
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            btnSelectSave.Text = "Save";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdvertisement ads = new frmAdvertisement();
            ads.Show();
            this.Hide();
        }

        private void frmAdvertisementAdd_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmAdvertisement ads = new frmAdvertisement();
            ads.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtPath.Clear();
            btnSelectSave.Text = "Select GIF File";
           // pictureBox1.Image.Dispose();
            //pictureBox1.BackgroundImage.Dispose();
        }
    }
}
