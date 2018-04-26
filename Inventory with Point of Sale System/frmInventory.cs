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
    public partial class frmInventory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        int i;
        string columnName;

        Point lastPoint;
        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmSeedsInventory_Load(object sender, EventArgs e)
        {

            getCurrentMonth();

            Global.seedsInventory = true;
            Global.equipmentsInventory = false;
            Global.othersInventory = false;

            Global.buttonSeedSelected = true;
            Global.buttonEquipmentSelected = false;
            Global.buttonOthersSelected = false;

            btnSeedsInventory.BackColor = Color.FromArgb(192, 64, 0);

            txtSearchName.Focus();
            Global.seedsInventory = true;
            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', ID, ProdType FROM tblProducts Where ProdType = 'Seeds' ORDER BY Descr", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            //BindingSource bsource = new BindingSource();
            dtgSeeds.DataSource = dataTbl;

            searchLowQuantity();
            searchLowQuantityBigItem();
        }

        private void getCurrentMonth()
        {
            int month = DateTime.Now.Month;

        }

        //private void 

        private void searchLowQuantity()
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM tblProducts Where Qty < 6 AND BigItem!='True'", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            sqlSda.Fill(dt2);

            if (dt2.Rows.Count >= 1)
            {
                MessageBox.Show("Some products are low in quantity!! Please monitor inventory!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void searchLowQuantityBigItem()
        {
            DataTable dt3 = new DataTable();
            dt3.Clear();
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM tblProducts Where BigItem='True' AND Qty < 2", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            sqlSda.Fill(dt3);

            if (dt3.Rows.Count >= 1)
            {
                MessageBox.Show("Some of our Big Item products are low in quantity!! Please monitor inventory!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void autocomplete()
        {
            SqlCommand cmd = new SqlCommand("SELECT Descr FROM tblProducts", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtSearchName.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (Global.seedsInventory == true)
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', ID , ProdType FROM tblProducts Where ProdType = 'Seeds' AND Descr Like '" + "%" + txtSearchName.Text + "%" + "'", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgSeeds.DataSource = dataTbl;


                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();

                    lblModel.Text = "";
                    lblPartNum.Text = "";
                    lblLocation.Text = "";
                    lblSerialN.Text = "";
                    lblEngineN.Text = "";
                    lblBigItem.Text = "";

                    if (Global.buttonSeedSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                    }
                    else if (Global.buttonOthersSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    }
                }
                
            }
            else if (Global.equipmentsInventory == true)
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', Model, PartNum AS 'Part Number', Location, SerialN AS 'Serial Number', EngineN AS 'Engine Number', BigItem AS 'Big Item' , ID FROM tblProducts Where ProdType = 'Equipments' AND Descr Like '" + "%" + txtSearchName.Text + "%" + "'", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgSeeds.DataSource = dataTbl;

                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                    lblModel.Text = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    lblPartNum.Text = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
                    lblLocation.Text = dtgSeeds.SelectedRows[0].Cells[8].Value.ToString();
                    lblSerialN.Text = dtgSeeds.SelectedRows[0].Cells[9].Value.ToString();
                    lblEngineN.Text = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    lblBigItem.Text = dtgSeeds.SelectedRows[0].Cells[11].Value.ToString();


                    if (Global.buttonSeedSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                    }
                    else if (Global.buttonOthersSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    }

                }
            }
            else if (Global.othersInventory == true)
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', Model, PartNum AS 'Part Number', Location, SerialN AS 'Serial Number', ID FROM tblProducts Where ProdType = 'Others' AND Descr Like '" + "%" + txtSearchName.Text + "%" + "'", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgSeeds.DataSource = dataTbl;

                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                    lblModel.Text = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    lblPartNum.Text = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
                    lblLocation.Text = dtgSeeds.SelectedRows[0].Cells[8].Value.ToString();
                    lblSerialN.Text = dtgSeeds.SelectedRows[0].Cells[9].Value.ToString();

                    lblEngineN.Text = "";
                    lblBigItem.Text = "";


                    if (Global.buttonSeedSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                    }
                    else if (Global.buttonOthersSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    }

                }
            }
            else
            {
                SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', ID FROM tblProducts Where ProdType = 'Seeds' AND Descr Like '" + "%" + txtSearchName.Text + "%" + "'", con);
                SqlDataAdapter sqlSda = new SqlDataAdapter();
                sqlSda.SelectCommand = sqlCom;
                DataTable dataTbl = new DataTable();
                sqlSda.Fill(dataTbl);
                //BindingSource bsource = new BindingSource();
                dtgSeeds.DataSource = dataTbl;

                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();

                    lblModel.Text = "";
                    lblPartNum.Text = "";
                    lblLocation.Text = "";
                    lblSerialN.Text = "";
                    lblEngineN.Text = "";
                    lblBigItem.Text = "";


                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Global.adding = true;
            Global.editing = false;
            Global.editQuantity = false;

            

            frmAddEditProduct addedit = new frmAddEditProduct();
            addedit.Show();
            this.Hide();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Global.adding = false;
            Global.editing = true;
            Global.editQuantity = true;
            

            if (Global.buttonSeedSelected ==true)
            {
                Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                Global.Qty = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                Global.Unit = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                Global.name = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                Global.Supp = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                Global.SellP = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                Global.BaseP = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                Global.prodType = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
            }
            else if (Global.buttonEquipmentSelected == true)
            {
                Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                Global.Qty = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                Global.Unit = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                Global.name = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                Global.Supp = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                Global.SellP = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                Global.BaseP = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                Global.Model = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                Global.PartNum = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
                Global.Location = dtgSeeds.SelectedRows[0].Cells[8].Value.ToString();
                Global.SerialN = dtgSeeds.SelectedRows[0].Cells[9].Value.ToString();
                Global.EngineN = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                Global.BigItem = dtgSeeds.SelectedRows[0].Cells[11].Value.ToString();
                Global.prodType = dtgSeeds.SelectedRows[0].Cells[13].Value.ToString();
            }
            else if (Global.buttonOthersSelected == true)
            {
                Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                Global.Qty = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                Global.Unit = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                Global.name = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                Global.Supp = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                Global.SellP = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                Global.BaseP = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                Global.Model = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                Global.PartNum = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
                Global.Location = dtgSeeds.SelectedRows[0].Cells[8].Value.ToString();
                Global.SerialN = dtgSeeds.SelectedRows[0].Cells[9].Value.ToString();
                Global.prodType = dtgSeeds.SelectedRows[0].Cells[11].Value.ToString();
            }

            frmAddEditProduct addedit = new frmAddEditProduct();
            addedit.Show();
            this.Hide();
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure you want to delete the product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (del == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from tblProducts WHERE (ID='" +Global.ID + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product record successfully deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                if (Global.buttonEquipmentSelected == true)
                {
                    btnEquipmentsInventory.BackColor = Color.FromArgb(40, 40, 40);
                }
                else if (Global.buttonOthersSelected == true)
                {
                    btnOthersInventory.BackColor = Color.FromArgb(40, 40, 40);
                }

                frmSeedsInventory_Load(this, null);

                txtSearchName.Text = "";
                txtSearchName.Focus();
            }
        }

        private void btnSeedsInventory_Click(object sender, EventArgs e)
        {
            btnInflow.Text = "Seeds In";

            Global.seedsInventory = true;
            Global.equipmentsInventory = false;
            Global.othersInventory = false;

            Global.buttonSeedSelected = true;
            Global.buttonEquipmentSelected = false;
            Global.buttonOthersSelected = false;

            btnSeedsInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);

            btnSeedsInventory.BackColor = Color.FromArgb(192, 64, 0);
            btnEquipmentsInventory.BackColor = Color.FromArgb(40, 40, 40);
            btnOthersInventory.BackColor = Color.FromArgb(40, 40, 40);

            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', ID , ProdType FROM tblProducts Where ProdType = 'Seeds' ORDER BY Descr", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            //BindingSource bsource = new BindingSource();
            dtgSeeds.DataSource = dataTbl;

            dtgSeeds.Columns[6].Visible = false;
        }

        private void btnEquipmentsInventory_Click(object sender, EventArgs e)
        {
            btnInflow.Text = "Equipments In";

            Global.seedsInventory = false;
            Global.equipmentsInventory = true;
            Global.othersInventory = false;

            Global.buttonSeedSelected = false;
            Global.buttonEquipmentSelected = true;
            Global.buttonOthersSelected = false;

            btnEquipmentsInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);

            btnSeedsInventory.BackColor = Color.FromArgb(40, 40, 40);
            btnEquipmentsInventory.BackColor = Color.FromArgb(192, 64, 0);
            btnOthersInventory.BackColor = Color.FromArgb(40, 40, 40);

            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', Model, PartNum AS 'Part Number', Location, SerialN AS 'Serial Number', EngineN AS 'Engine Number', BigItem AS 'Big Item' , ID , ProdType FROM tblProducts Where ProdType = 'Equipments'  ORDER BY Descr", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            //BindingSource bsource = new BindingSource();
            dtgSeeds.DataSource = dataTbl;

            dtgSeeds.Columns[12].Visible = false;
        }

        private void btnOthersInventory_Click(object sender, EventArgs e)
        {
            btnInflow.Text = "In (Other Products)";
            
            Global.seedsInventory = false;
            Global.equipmentsInventory = false;
            Global.othersInventory = true;

            Global.buttonSeedSelected = false;
            Global.buttonEquipmentSelected = false;
            Global.buttonOthersSelected = true;

            btnOthersInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);

            btnSeedsInventory.BackColor = Color.FromArgb(40, 40, 40);
            btnEquipmentsInventory.BackColor = Color.FromArgb(40, 40, 40);
            btnOthersInventory.BackColor = Color.FromArgb(192, 64, 0);

            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', Qty AS 'Quantity', Unit, Supp AS 'Supplier', BaseP AS 'Base Price', SellP AS 'Selling Price', Model, PartNum AS 'Part Number', Location, SerialN AS 'Serial Number', ID, ProdType FROM tblProducts Where ProdType = 'Others'  ORDER BY Descr", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            //BindingSource bsource = new BindingSource();
            dtgSeeds.DataSource = dataTbl;

            dtgSeeds.Columns[10].Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgSeeds_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Global.seedsInventory == true)
            {

                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();

                    lblModel.Text = "";
                    lblPartNum.Text = "";
                    lblLocation.Text = "";
                    lblSerialN.Text = "";
                    lblEngineN.Text = "";
                    lblBigItem.Text = "";

                    if (Global.buttonSeedSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                    }
                    else if (Global.buttonOthersSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    }

                }
                

            }
            else if (Global.equipmentsInventory == true)
            {
                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                    lblModel.Text = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    lblPartNum.Text = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
                    lblLocation.Text = dtgSeeds.SelectedRows[0].Cells[8].Value.ToString();
                    lblSerialN.Text = dtgSeeds.SelectedRows[0].Cells[9].Value.ToString();
                    lblEngineN.Text = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    lblBigItem.Text = dtgSeeds.SelectedRows[0].Cells[11].Value.ToString();


                    if (Global.buttonSeedSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                    }
                    else if (Global.buttonOthersSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    }

                }
            }
            else if (Global.othersInventory == true)
            {

                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();
                    lblModel.Text = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    lblPartNum.Text = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
                    lblLocation.Text = dtgSeeds.SelectedRows[0].Cells[8].Value.ToString();
                    lblSerialN.Text = dtgSeeds.SelectedRows[0].Cells[9].Value.ToString();

                    lblEngineN.Text = "";
                    lblBigItem.Text = "";


                    if (Global.buttonSeedSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else if (Global.buttonEquipmentSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                    }
                    else if (Global.buttonOthersSelected == true)
                    {
                        Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                    }

                }
            }
            else
            {

                if (dtgSeeds.Rows.Count >= 1)
                {
                    lblDesc.Text = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                    lblQty.Text = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                    lblUnit.Text = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                    lblSupp.Text = dtgSeeds.SelectedRows[0].Cells[3].Value.ToString();
                    lblBasep.Text = dtgSeeds.SelectedRows[0].Cells[4].Value.ToString();
                    lblSellP.Text = dtgSeeds.SelectedRows[0].Cells[5].Value.ToString();

                    lblModel.Text = "";
                    lblPartNum.Text = "";
                    lblLocation.Text = "";
                    lblSerialN.Text = "";
                    lblEngineN.Text = "";
                    lblBigItem.Text = "";
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            //lblCloseForm.ForeColor = System.Drawing.Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            //lblCloseForm.ForeColor = System.Drawing.Color.White;
        }

        private void btnSeedsInventory_MouseHover(object sender, EventArgs e)
        {
            if (Global.buttonSeedSelected == true)
            {
                btnSeedsInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            }
            else if (Global.buttonSeedSelected == false)
            {
                btnSeedsInventory.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            }
        }

        private void btnEquipmentsInventory_MouseHover(object sender, EventArgs e)
        {
            if (Global.buttonEquipmentSelected == true)
            {
                btnEquipmentsInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            }
            else if (Global.buttonEquipmentSelected == false)
            {
                btnEquipmentsInventory.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            } 
        }

        private void btnOthersInventory_MouseHover(object sender, EventArgs e)
        {
            if (Global.buttonOthersSelected == true)
            {
                btnOthersInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            }
            else if (Global.buttonOthersSelected == false)
            {
                btnOthersInventory.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            }
        }

        private void btnInflow_Click(object sender, EventArgs e)
        {
            if (Global.buttonSeedSelected == true)
            {
                Global.ID = dtgSeeds.SelectedRows[0].Cells[6].Value.ToString();
                Global.name = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                Global.Qty = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                Global.Unit = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                Global.prodType = dtgSeeds.SelectedRows[0].Cells[7].Value.ToString();
            }
            else if (Global.buttonEquipmentSelected == true)
            {
                Global.ID = dtgSeeds.SelectedRows[0].Cells[12].Value.ToString();
                Global.name = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                Global.Qty = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                Global.Unit = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                Global.prodType = dtgSeeds.SelectedRows[0].Cells[13].Value.ToString();
            }
            else if (Global.buttonOthersSelected == true)
            {
                Global.ID = dtgSeeds.SelectedRows[0].Cells[10].Value.ToString();
                Global.name = dtgSeeds.SelectedRows[0].Cells[0].Value.ToString();
                Global.Qty = dtgSeeds.SelectedRows[0].Cells[1].Value.ToString();
                Global.Unit = dtgSeeds.SelectedRows[0].Cells[2].Value.ToString();
                Global.prodType = dtgSeeds.SelectedRows[0].Cells[11].Value.ToString();
            }

            frmProdIn prodin = new frmProdIn();
            this.Hide();
            prodin.Show();
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
        }

        private void btnCriticalQty_Click(object sender, EventArgs e)
        {
            frmMonitorInventory monitor = new frmMonitorInventory();
            this.Hide();
            monitor.Show();
        }

    }
}
