namespace Inventory_with_Point_of_Sale_System
{
    partial class frmPrintQuantity
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
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Quantity_Dataset = new Inventory_with_Point_of_Sale_System.Quantity_Dataset();
            this.tblProductsTableAdapter = new Inventory_with_Point_of_Sale_System.Quantity_DatasetTableAdapters.tblProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_with_Point_of_Sale_System.Quantity Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // Quantity_Dataset
            // 
            this.Quantity_Dataset.DataSetName = "Quantity_Dataset";
            this.Quantity_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrintQuantity";
            this.Text = "frmPrintQuantity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrintQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_Dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        //private quantityDataset quantityDataset;
        //private quantityDatasetTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
       // private datasetQuantity datasetQuantity;
       // private datasetQuantityTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Quantity_Dataset Quantity_Dataset;
        private Quantity_DatasetTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        // private quantityDataset quantityDataset;
    }
}