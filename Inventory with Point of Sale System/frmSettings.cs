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
    public partial class frmSettings : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
       

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                panelSalesHistory.Visible = true;
                panelUniformRanges.Visible = false;
            }
            else if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                panelSalesHistory.Visible = false;
                panelUniformRanges.Visible = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = true;
            panelSalesHistory.Visible = true;
            panelUniformRanges.Visible = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox1.Checked = false;
            panelSalesHistory.Visible = false;
            panelUniformRanges.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            updateRangesSeeds();
            updateRangesEquipments();
            updateRangesOthers();


            MessageBox.Show("OK!!!");
        }

        public void updateRangesSeeds()
        {
            if (checkBox1.Checked == true && checkBox2.Checked==false)
            {
                con.Open();

                string sql = "UPDATE tblRangesHistory SET Name=@Name, fastMoving=@fastMoving, normal=@normal, low=@low WHERE ID = '1' ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", "Seeds");
                cmd.Parameters.AddWithValue("@fastMoving", txtFM_S1.Text);
                cmd.Parameters.AddWithValue("@normal", txtN_S1.Text);
                cmd.Parameters.AddWithValue("@low", txtL_S1.Text);

                cmd.ExecuteReader();

              
                con.Close();
                
            }

            else if (checkBox2.Checked == true && checkBox1.Checked==false)
            {
                con.Open();

                string sql = "UPDATE tblRangesUniform SET Name=@Name, fastMoving=@fastMoving, normal=@normal, low=@low WHERE ID = '1' ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", "Seeds");
                cmd.Parameters.AddWithValue("@fastMoving", txtFM_S2.Text);
                cmd.Parameters.AddWithValue("@normal", txtN_S2.Text);
                cmd.Parameters.AddWithValue("@low", txtL_S2.Text);

                cmd.ExecuteReader();

               
                con.Close();
            }

        }

        public void updateRangesEquipments()
        {

            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                con.Open();


                string sql2 = "UPDATE tblRangesHistory SET Name=@Name, fastMoving=@fastMoving, normal=@normal, low=@low WHERE ID = '2' ";

                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@Name", "Equipments");
                cmd2.Parameters.AddWithValue("@fastMoving", txtFM_E1.Text);
                cmd2.Parameters.AddWithValue("@normal", txtN_E1.Text);
                cmd2.Parameters.AddWithValue("@low", txtL_E1.Text);

                cmd2.ExecuteReader();

                
                con.Close();



            }
            else if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                con.Open();

                string sql2 = "UPDATE tblRangesUniform SET Name=@Name, fastMoving=@fastMoving, normal=@normal, low=@low WHERE ID = '2' ";

                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@Name", "Equipments");
                cmd2.Parameters.AddWithValue("@fastMoving", txtFM_E2.Text);
                cmd2.Parameters.AddWithValue("@normal", txtN_E2.Text);
                cmd2.Parameters.AddWithValue("@low", txtL_E2.Text);

                cmd2.ExecuteReader();


                con.Close();
            }

        }

        public void updateRangesOthers()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                con.Open();

                string sql = "UPDATE tblRangesHistory SET Name=@Name, fastMoving=@fastMoving, normal=@normal, low=@low WHERE ID = '3' ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", "Others");
                cmd.Parameters.AddWithValue("@fastMoving", txtFM_O1.Text);
                cmd.Parameters.AddWithValue("@normal", txtN_O1.Text);
                cmd.Parameters.AddWithValue("@low", txtL_O1.Text);

                cmd.ExecuteReader();
                con.Close();

            }

            else if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                con.Open();


                string sql = "UPDATE tblRangesUniform SET Name=@Name, fastMoving=@fastMoving, normal=@normal, low=@low WHERE ID = '3' ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", "Others");
                cmd.Parameters.AddWithValue("@fastMoving", txtFM_O2.Text);
                cmd.Parameters.AddWithValue("@normal", txtN_O2.Text);
                cmd.Parameters.AddWithValue("@low", txtL_O2.Text);

                cmd.ExecuteReader();

                con.Close();
            }

        }
    }
}
