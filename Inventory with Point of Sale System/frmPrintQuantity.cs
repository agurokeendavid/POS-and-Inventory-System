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
    public partial class frmPrintQuantity : Form
    {
        public frmPrintQuantity()
        {
            InitializeComponent();
        }

        private void frmPrintQuantity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Quantity_Dataset.tblProducts' table. You can move, or remove it, as needed.
            this.tblProductsTableAdapter.Fill(this.Quantity_Dataset.tblProducts);

            this.reportViewer1.RefreshReport();
        }
    }
}
