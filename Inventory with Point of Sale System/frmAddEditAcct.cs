using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_with_Point_of_Sale_System
{
    public partial class frmAddEditAcct : Form
    {
        public frmAddEditAcct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmAccounts account = new frmAccounts();
            this.Hide();
            account.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAccounts account = new frmAccounts();
            this.Hide();
            account.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
