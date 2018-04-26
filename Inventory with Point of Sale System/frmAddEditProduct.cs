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
    public partial class frmAddEditProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        int lastID;

        public frmAddEditProduct()
        {
            InitializeComponent();
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void lblCloseForm_MouseHover(object sender, EventArgs e)
        {
            lblCloseForm.ForeColor = System.Drawing.Color.Red;
        }

        private void lblCloseForm_MouseLeave(object sender, EventArgs e)
        {
            lblCloseForm.ForeColor = System.Drawing.Color.White;
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("adding "+Global.adding.ToString());
            //MessageBox.Show("editing " + Global.editing.ToString());
            //MessageBox.Show("seeds " + Global.buttonSeedSelected.ToString());
            //MessageBox.Show("eqpt " + Global.buttonEquipmentSelected.ToString());
            //MessageBox.Show("others " + Global.othersInventory.ToString());
            //MessageBox.Show("Name " + Global.name);
            //MessageBox.Show("ID " + Global.ID);

            if (Global.adding == true && Global.editing==false)
            {
                if (Global.buttonSeedSelected == true)
                {
                    txtModel.Enabled = false;
                    txtPartNum.Enabled = false;
                    txtSN.Enabled = false;
                    txtEN.Enabled = false;
                    cmbProdType.Text = "Seeds";
                }
                else if (Global.buttonEquipmentSelected == true)
                {
                    cmbProdType.Text = "Equipments";
                    
                }
                else if (Global.buttonOthersSelected == true)
                {

                    cmbProdType.Text = "Others";
                    txtModel.Enabled = false;
                    txtPartNum.Enabled = false;
                    txtSN.Enabled = false;
                    txtEN.Enabled = false;
                }
            }
            else if (Global.editing == true && Global.adding==false)
            {
                if (Global.buttonSeedSelected == true)
                {
                    txtName.Text = Global.name;
                    txtQty.Text = Global.Qty;
                    txtUnit.Text = Global.Unit;
                    cmbSupp.Text = Global.Supp;
                    txtBP.Text = Global.BaseP;
                    txtSP.Text = Global.SellP;
                    cmbProdType.Text = Global.prodType;
                }
                else if (Global.buttonEquipmentSelected == true)
                {
                    txtName.Text = Global.name;
                    txtQty.Text = Global.Qty;
                    txtUnit.Text = Global.Unit;
                    cmbSupp.Text = Global.Supp;
                    txtBP.Text = Global.BaseP;
                    txtSP.Text = Global.SellP;
                    txtModel.Text = Global.Model;
                    txtPartNum.Text = Global.PartNum;
                    txtLoc.Text = Global.Location;
                    txtSN.Text = Global.SerialN;
                    txtEN.Text = Global.EngineN;
                    cmbBigItem.Text = Global.BigItem;
                    cmbProdType.Text = Global.prodType;

                }
                else if (Global.buttonOthersSelected == true)
                {
                    txtName.Text = Global.name;
                    txtQty.Text = Global.Qty;
                    txtUnit.Text = Global.Unit;
                    cmbSupp.Text = Global.Supp;
                    txtBP.Text = Global.BaseP;
                    txtSP.Text = Global.SellP;
                    cmbProdType.Text = Global.prodType;
                }



                if (Global.buttonSeedSelected == true)
                {
                    txtModel.Enabled = false;
                    txtPartNum.Enabled = false;
                    txtSN.Enabled = false;
                    txtEN.Enabled = false;
                }
                else if (Global.buttonEquipmentSelected == true)
                {

                }
                else if (Global.buttonOthersSelected == true)
                {
                    txtModel.Enabled = false;
                    txtPartNum.Enabled = false;
                    txtSN.Enabled = false;
                    txtEN.Enabled = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Global.adding == true && Global.editing == false)
            {
                DialogResult ask = MessageBox.Show("Add another product?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    if (Global.buttonSeedSelected == true || Global.buttonOthersSelected == true)
                    {
                        con.Open();
                        string query = "INSERT INTO tblProducts(Descr, Qty , Unit , Supp , BaseP , SellP ,ProdType, BigItem, Location) VALUES('" + txtName.Text + "','" + txtQty.Text + "','" + txtUnit.Text + "','" + cmbSupp.Text + "','" + txtBP.Text + "','" + txtSP.Text + "','" + cmbProdType.Text + "','" + cmbBigItem.Text + "','" + txtLoc.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        //MessageBox.Show("Product record saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmInventory inventory = new frmInventory();
                        this.Hide();
                        inventory.Show();
                        
                        con.Close();

                        getID();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        con.Open();
                        string query = "INSERT INTO tblProducts(Descr, Qty , Unit , Supp , BaseP , SellP ,Model , PartNum , Location , SerialN , EngineN , BigItem, ProdType ) VALUES('" + txtName.Text + "','" + txtQty.Text + "','" + txtUnit.Text + "','" + cmbSupp.Text + "','" + txtBP.Text + "','" + txtSP.Text + "','" + txtModel.Text + "','" + txtPartNum.Text + "','" + txtLoc.Text + "','" + txtSN.Text + "','" + txtEN.Text + "','" + cmbBigItem.Text + "','" + cmbProdType.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        //MessageBox.Show("Product record saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmInventory inventory = new frmInventory();
                        this.Hide();
                        inventory.Show();

                        con.Close();
                    }
                }
            }


            else if (Global.editing == true && Global.adding == false)
            {
                DialogResult ask = MessageBox.Show("Edit product record?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    

                    if (Global.buttonSeedSelected == true || Global.buttonOthersSelected == true)
                    {

                        string query2 = "UPDATE tblProducts SET Descr='" + txtName.Text + "', Qty='" + txtQty.Text + "' , Unit='" + txtUnit.Text + "' , Supp='" + cmbSupp.Text + "' , BaseP='" + txtBP.Text + "' , SellP='" + txtSP.Text + "' , ProdType='" +cmbProdType.Text + "' WHERE ID = '" + Global.ID + "';";
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        SqlDataReader myreader2;
                        SqlDataAdapter sda = new SqlDataAdapter(query2, con);

                        try
                        {

                            myreader2 = cmd2.ExecuteReader();

                            while (myreader2.Read())
                            {


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        con.Close();
                        //MessageBox.Show("Record successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmInventory inventory = new frmInventory();
                        this.Hide();
                        inventory.Show();
                    }

                    else if (Global.buttonEquipmentSelected ==true)
                    {
                        string query = "UPDATE tblProducts SET Descr='" + txtName.Text + "', Qty='" +txtQty.Text + "' , Unit='" + txtUnit.Text+ "' , Supp='" + cmbSupp.Text + "' , BaseP='" + txtBP.Text + "' , SellP='" + txtSP.Text + "' , ProdType='" + cmbProdType.Text + "' , Model='" + txtModel.Text + "' , PartNum='" + txtPartNum.Text + "', Location='" +txtLoc.Text + "' , SerialN='" + txtSN.Text + "' , EngineN='" + txtEN.Text + "' , BigItem='" + cmbBigItem.Text + "' WHERE ID = '" + Global.ID + "';";
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
                        con.Close();
                        //MessageBox.Show("Record successfully updated.","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        frmInventory inventory = new frmInventory();
                        this.Hide();
                        inventory.Show();
                    }
                }
            }
        }


        public void getID()
        {
            con.Open();
            int a = 0;
            SqlCommand com = new SqlCommand("select max(id) from tblProducts", con);
            a = Convert.ToInt32( com.ExecuteScalar());
            lastID = a;
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            this.Hide();
            inventory.Show();
        }







    }
}
