namespace Inventory_with_Point_of_Sale_System
{
    partial class frmPrintSalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.salesDataseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatase = new Inventory_with_Point_of_Sale_System.SalesDatase();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblInOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblIn_OutTableAdapter = new Inventory_with_Point_of_Sale_System.SalesDataseTableAdapters.tblIn_OutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInOutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDataseBindingSource
            // 
            this.salesDataseBindingSource.DataSource = this.salesDatase;
            this.salesDataseBindingSource.Position = 0;
            // 
            // salesDatase
            // 
            this.salesDatase.DataSetName = "SalesDatase";
            this.salesDatase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesDataset";
            reportDataSource1.Value = this.salesDataseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_with_Point_of_Sale_System.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(467, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblInOutBindingSource
            // 
            this.tblInOutBindingSource.DataMember = "tblIn_Out";
            this.tblInOutBindingSource.DataSource = this.salesDataseBindingSource;
            // 
            // tblIn_OutTableAdapter
            // 
            this.tblIn_OutTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrintSalesReport";
            this.Text = "Sales Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrintReport_FormClosed);
            this.Load += new System.EventHandler(this.frmPrintReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInOutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salesDataseBindingSource;
        private SalesDatase salesDatase;
        private System.Windows.Forms.BindingSource tblInOutBindingSource;
        private SalesDataseTableAdapters.tblIn_OutTableAdapter tblIn_OutTableAdapter;
    }
}