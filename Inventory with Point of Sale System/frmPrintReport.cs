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
    public partial class frmPrintSalesReport : Form
    {

        public frmPrintSalesReport()
        {
            InitializeComponent();
        }

        private void frmPrintReport_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] rparam = new Microsoft.Reporting.WinForms.ReportParameter[]
              
            {
            new Microsoft.Reporting.WinForms.ReportParameter("seedQuantity", Global.seedQuantity),
            new Microsoft.Reporting.WinForms.ReportParameter("seedAmount", Global.seedAmount),
            new Microsoft.Reporting.WinForms.ReportParameter("reportHeading", Global.reportHeading),
            new Microsoft.Reporting.WinForms.ReportParameter("dateFrom", Global.dateFrom),
            new Microsoft.Reporting.WinForms.ReportParameter("dateTo", Global.dateTo),
            new Microsoft.Reporting.WinForms.ReportParameter("eqptQuantity", Global.eqptQuantity),
            new Microsoft.Reporting.WinForms.ReportParameter("eqptAmount", Global.eqptAmount),
            new Microsoft.Reporting.WinForms.ReportParameter("othersQuantity", Global.othersQuantity),
            new Microsoft.Reporting.WinForms.ReportParameter("othersAmount", Global.othersAmount)
            };

            reportViewer1.LocalReport.SetParameters(rparam);
            this.reportViewer1.RefreshReport();
        }

        private void frmPrintReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReports report = new frmReports();
            report.Show();
        }
    }
}
