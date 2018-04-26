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
    public partial class frmProdIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        DateTime dateNow = DateTime.Now;
        public frmProdIn()
        {
            InitializeComponent();
        }

        private void frmProdIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
            this.Hide();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "INSERT INTO tblIn_Out(Descr, Qty , Unit , DRNumber , Date , ProdType, TransType) VALUES('" + Global.name + "','" + txtQuantity.Text + "','" + Global.Unit + "','" + txtDRN.Text + "','" + dateNow.ToShortDateString() + "','" + Global.prodType + "','In' )";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Product record saved. Product quantity updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            updateProductQuantity();

            frmInventory inventory = new frmInventory();
            this.Hide();
            inventory.Show();
        }
        private void frmProdIn_Load(object sender, EventArgs e)
        {
            lblName.Text = Global.name;
        }


        private void updateProductQuantity()
        {
            int addQuantity = int.Parse(txtQuantity.Text);
            int currentQuantity = int.Parse(Global.Qty);
            int newQuantity = addQuantity + currentQuantity;

            string query = "UPDATE tblProducts SET Qty='" + newQuantity.ToString() + "' WHERE ID = '" + Global.ID + "';";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            try
            {

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           // MessageBox.Show("Done.");
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            this.Hide();
            inventory.Show();
        }
    }
}
