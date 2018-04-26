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
    public partial class frmSales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Inventory with Point of Sale System\Inventory with Point of Sale System\bin\Debug\InventoryPosDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        Point lastPoint;
        DateTime dateNow = DateTime.Now;

        string[] totalAmountArr = new string[5];
        double amount;
        double payment;
        double change;

        double totalPayment = 0;
        double totalCharges;

        public frmSales()
        {
            InitializeComponent();
            
            dtgSale.ColumnCount = 5;
            dtgSale.Columns[0].Name = "Name";
            dtgSale.Columns[1].Name = "Quantity";
            dtgSale.Columns[2].Name = "Unit";
            dtgSale.Columns[3].Name = "Price";
            dtgSale.Columns[4].Name = "Total";
            dtgSale.Columns[0].Width = dtgSale.Width / 3;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            
            dataGridView1.Visible = false;
            this.AcceptButton = button1;
            /*
            for (int i = 0; i < dtgProducts.Rows.Count; i++)
			{
              int x =  int.Parse(dtgProducts.Rows[i].Cells[3].Value.ToString());
			}
             */

            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', SellP AS 'Price', Qty AS 'Quantity', Unit, ProdType AS 'Type' FROM tblProducts ORDER BY Descr", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            //BindingSource bsource = new BindingSource();
            dtgProducts.DataSource = dataTbl;

            autocomplete();
            dtgProducts.Visible = false;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCom = new SqlCommand("SELECT Descr AS 'Name', SellP AS 'Price', Qty AS 'Quantity', Unit, ProdType AS 'Type' FROM tblProducts WHERE Descr LIKE '" + "%" + txtSearch.Text + "%" + "'", con);
            SqlDataAdapter sqlSda = new SqlDataAdapter();
            sqlSda.SelectCommand = sqlCom;
            DataTable dataTbl = new DataTable();
            sqlSda.Fill(dataTbl);
            dtgProducts.DataSource = dataTbl;

            if (dtgProducts.Rows.Count >= 1)
            {
                Global.name = dtgProducts.SelectedRows[0].Cells[0].Value.ToString();
                Global.SellPrice = dtgProducts.SelectedRows[0].Cells[1].Value.ToString();
                Global.Qty = dtgProducts.SelectedRows[0].Cells[2].Value.ToString();
                Global.prodType = dtgProducts.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgSale.ClearSelection();
            if (Global.editQuantity == true)
            { 

            }
            else
            {

                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Please select a product!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                }
            }

            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dtgProducts.Rows.Count < 1)
            {
                MessageBox.Show("No rows selected. Try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            else
            {
                if (Global.editQuantity == true)
                {
                    dtgSale.SelectedRows[0].Cells[1].Value = txtQuantity.Text;

                    string[] priceString = dtgSale.SelectedRows[0].Cells[3].Value.ToString().Split('.');
                    double priceDbl = double.Parse(priceString[0]);
                    double quantityDbl = double.Parse(txtQuantity.Text);
                    double newTotal = priceDbl * quantityDbl;

                    dtgSale.SelectedRows[0].Cells[4].Value = newTotal.ToString("###.#0");

                    Global.editQuantity = false;
                    txtSearch.Enabled = true;
                    txtSearch.Focus();
                    btnEditQuantity.Text = "Edit Quantity" + Environment.NewLine + "(Alt+E)";
                    btnEditQuantity.BackColor = Color.FromArgb(40, 40, 40);
                    txtQuantity.Clear();

                    MessageBox.Show("Quantity Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sumTotalAmount();
                    getTotalItems();
                }
                else
                {
                    double quantity = double.Parse(txtQuantity.Text);
                    double price = double.Parse(Global.SellPrice);
                    double total = quantity * price;

                    Global.total = total.ToString();

                    double totalAmt = double.Parse(Global.total);
                    string ttlamt = totalAmt.ToString("###.#0");

                    string unit = dtgProducts.SelectedRows[0].Cells[3].Value.ToString();

                    double sellp = double.Parse(Global.SellPrice);
                    string baseprice = sellp.ToString("###.#0");

                    //this loop checks if there is an existing duplicated in the product input
                    /*
                    for (int i = 0; i < dtgSale.Rows.Count; i++)
                    {
                        string existingItemName = dtgSale.Rows[i].Cells[0].Value.ToString();

                        if (existingItemName == Global.name)
                        {
                            MessageBox.Show("This item is already added to sales items!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            Global.noDuplicate = false;
                            break;
                        }


                    }
                   */

                    if (Global.noDuplicate == true)
                    {
                        addData(Global.name, txtQuantity.Text, unit, baseprice, ttlamt);
                        Global.noDuplicate = true;
                    }
                    else { }



                    txtSearch.Text = "";
                    txtQuantity.Text = "";
                    txtSearch.Focus();

                    Global.noDuplicate = true;
                }

            }
        }

        private void addData(string name, string quantity,string unit, string price, string total)
        {
            string[] row = { name,quantity,unit,price,total };

            dtgSale.Rows.Add(row);
        }


        private void dtgSale_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sumTotalAmount(); 
            getTotalItems();
            
        }

        private void sumTotalAmount()
        {
            double totalAmount = 0;
            double total = 0;

            for (int i = 0; i < dtgSale.Rows.Count; i++)
            {
                totalAmount = double.Parse(dtgSale.Rows[i].Cells[4].Value.ToString());
                total += totalAmount;
            }
            //lblTotal.Text = total.ToString("###,###.#0");
            totalPayment = total;
            txtTotalAmount.Text = total.ToString("###,###.#0");
            totalCharges = total;
        }

        private void getTotalItems()
        {
            double qty = 0;
            double totalQty = 0;
            for (int i = 0; i < dtgSale.Rows.Count; i++)
            {
                string quantity = dtgSale.Rows[i].Cells[1].Value.ToString();
                qty = double.Parse(quantity);
                totalQty += qty;
            }
            txtNumberOfItems.Text = totalQty.ToString();
            //lblNumberOfItems.Text = totalQty.ToString();
        }

        private void dtgProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Global.name = dtgProducts.SelectedRows[0].Cells[0].Value.ToString();
            Global.SellPrice = dtgProducts.SelectedRows[0].Cells[1].Value.ToString();
            Global.Qty = dtgProducts.SelectedRows[0].Cells[2].Value.ToString();
            Global.prodType = dtgProducts.SelectedRows[0].Cells[3].Value.ToString();

            txtSearch.Text = dtgProducts.SelectedRows[0].Cells[0].Value.ToString();

            txtSearch.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to cancel transaction?", "Cancel transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ask == DialogResult.Yes)
            {
                dtgSale.Rows.Clear();

                txtTotalAmount.Text = "";
                txtNumberOfItems.Text = "";
                txtSearch.Focus();
            }
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void lblCloseForm_MouseHover(object sender, EventArgs e)
        {
            //lblCloseForm.ForeColor = System.Drawing.Color.Red;
        }

        private void lblCloseForm_MouseLeave(object sender, EventArgs e)
        {
            //lblCloseForm.ForeColor = System.Drawing.Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dtgSale.Rows.Count >= 1)
            {
               DialogResult ask =  MessageBox.Show("Cancel the current transaction?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
               if (ask ==DialogResult.Yes)
               {
                   this.Close();
                   frmMain main = new frmMain();
                   main.Show();
               }
            }
            else
            {
                this.Close();
                frmMain main = new frmMain();
                main.Show();
            }
        }

        private void frmSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //btnNewTransaction(sender, e);
                btnNewTransaction.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnRemoveItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnEditQuantity.PerformClick();
            }
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

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to have new transaction?", "New transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ask == DialogResult.Yes)
            {
                dtgSale.Rows.Clear();

                txtTotalAmount.Text = "";
                txtNumberOfItems.Text = "";
                txtSearch.Focus();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Delete selected row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                if (this.dtgSale.SelectedRows.Count > 0)
                {
                    dtgSale.Rows.RemoveAt(this.dtgSale.SelectedRows[0].Index);
                }
            }
            
        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if (dtgSale.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (dtgSale.SelectedRows.Count == 1)
            {
                if (btnEditQuantity.Text == "Cancel Edit")
                {
                    btnEditQuantity.Text = "Edit Quantity" + Environment.NewLine + "(F3)";
                    btnEditQuantity.BackColor = Color.FromArgb(40, 40, 40);
                    txtSearch.Enabled = true;
                    Global.editQuantity = false;
                }
                else
                {
                    Global.editQuantity = true;
                    txtSearch.Enabled = false;
                    txtQuantity.Focus();
                    btnEditQuantity.Text = "Cancel Edit";
                    btnEditQuantity.BackColor = Color.Orange;
                }
            }
        }

        private void dtgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtPayment.Text == "")
            {

            }
            else
            {

                amount = totalCharges;
                payment = double.Parse(txtPayment.Text);

                change = payment - amount;
            }

            if (dtgSale.Rows.Count == 0)
            {
                MessageBox.Show("Invalid transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtPayment.Text == "")
            {
                MessageBox.Show("Enter Amount of payment.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (totalPayment > payment)
            {
                MessageBox.Show("Enter a suffecient amount.", "Insuffecient amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult ask = MessageBox.Show("Proceed with payment?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    if (txtPayment.Text == "")
                    {
                     
                    }
                    else if (dtgSale.Rows.Count == 0)
                    {
                        
                    }
                    else
                    {
                        //this loop is to get the products that will be sold and the quantities to be deducted
                        for (int i = 0; i < dtgSale.Rows.Count; i++)
                        {
                            Global.prodName[i] = dtgSale.Rows[i].Cells[0].Value.ToString();
                            Global.prodOutQuantity[i] = dtgSale.Rows[i].Cells[1].Value.ToString();
                            Global.prodSales[i] = double.Parse(dtgSale.Rows[i].Cells[4].Value.ToString());
                        }

                        //this loop is to get the current quantity of the products
                        for (int n = 0; n < dtgSale.Rows.Count; n++)
                        {
                            SqlCommand sqlCom = new SqlCommand("SELECT Descr, Qty, Unit, ProdType FROM tblProducts WHERE Descr = '" + Global.prodName[n] + "' ", con);
                            SqlDataAdapter sqlSda = new SqlDataAdapter();
                            sqlSda.SelectCommand = sqlCom;
                            DataTable dataTbl = new DataTable();
                            sqlSda.Fill(dataTbl);
                            dataGridView1.DataSource = dataTbl;

                            Global.prodQuantity[n] = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                            Global.prodUnit[n] = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                            Global.prodTypeArr[n] = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        }

                        //this loop is to get the difference of the subtracted sold quantity from the current quntity of the product
                        for (int j = 0; j < dtgSale.Rows.Count; j++)
                        {
                            double q = double.Parse(Global.prodOutQuantity[j]);
                            double w = double.Parse(Global.prodQuantity[j]);
                            Global.newQuantity[j] = w - q;
                        }

                        //this loop is to update the new quantity of the products
                        for (int m = 0; m < dtgSale.Rows.Count; m++)
                        {
                            string query = "UPDATE tblProducts SET Qty='" + Global.newQuantity[m] + "' WHERE Descr = '" + Global.prodName[m] + "';";
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
                        }

                        for (int l = 0; l < dtgSale.Rows.Count; l++)
                        {
                            con.Open();
                            string query = "INSERT INTO tblIn_Out(Descr, Qty , Unit , Date , ProdType, TransType, ProdSales) VALUES('" + Global.prodName[l] + "','" + Global.prodOutQuantity[l] + "','" + Global.prodUnit[l] + "','" + dateNow.ToShortDateString() + "','" + Global.prodTypeArr[l] + "','Out' ,'" + Global.prodSales[l] + "')";
                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                            sda.SelectCommand.ExecuteNonQuery();
                            con.Close();
                        }

                    }
                    txtSearch.Focus();
                    MessageBox.Show("Payment Successful. Inventory Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtChange.Text = change.ToString("###,###.#0");
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
            txtSearch.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void autocomplete2()
        {
            SqlCommand cmd = new SqlCommand("SELECT Descr FROM tblProducts WHERE ProdType='"+cmbType.Text+"'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            cmbProdNames.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void dtgSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnNewTransaction.PerformClick();
                    return true;
                case Keys.F2:
                    btnRemoveItem.PerformClick();
                    return true;
                case Keys.F3:
                    btnEditQuantity.PerformClick();
                    return true;
                case Keys.F4:
                    btnCancelTransaction.PerformClick();
                    return true;
                case Keys.F5:
                    btnPayment.PerformClick();
                    return true;
                case Keys.F6:
                    txtPayment.Focus();
                    return true;
                case Keys.F10:
                    btnClose.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);
            }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPayment.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPayment.Text = txtPayment.Text.Remove(txtPayment.Text.Length - 1);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            autocomplete2();
        }
    }
}
