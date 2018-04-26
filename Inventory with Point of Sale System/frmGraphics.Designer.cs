namespace Inventory_with_Point_of_Sale_System
{
    partial class frmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgOutQty = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSetAsGuide = new System.Windows.Forms.Button();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.dtgProductStat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOutQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductStat)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 95);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(891, 333);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(149, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Product Name:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(276, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 48);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show in Graph";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbYear.Location = new System.Drawing.Point(149, 53);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(100, 21);
            this.cmbYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Year:";
            // 
            // dtgOutQty
            // 
            this.dtgOutQty.AllowUserToAddRows = false;
            this.dtgOutQty.AllowUserToDeleteRows = false;
            this.dtgOutQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOutQty.Location = new System.Drawing.Point(803, 136);
            this.dtgOutQty.Name = "dtgOutQty";
            this.dtgOutQty.ReadOnly = true;
            this.dtgOutQty.Size = new System.Drawing.Size(46, 66);
            this.dtgOutQty.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(758, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 48);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSetAsGuide
            // 
            this.btnSetAsGuide.Location = new System.Drawing.Point(394, 29);
            this.btnSetAsGuide.Name = "btnSetAsGuide";
            this.btnSetAsGuide.Size = new System.Drawing.Size(112, 48);
            this.btnSetAsGuide.TabIndex = 3;
            this.btnSetAsGuide.Text = "Set Year as Sales Inventory Guide";
            this.btnSetAsGuide.UseVisualStyleBackColor = true;
            this.btnSetAsGuide.Click += new System.EventHandler(this.btnSetAsGuide_Click);
            // 
            // dtgProduct
            // 
            this.dtgProduct.AllowUserToAddRows = false;
            this.dtgProduct.AllowUserToDeleteRows = false;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Location = new System.Drawing.Point(803, 226);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.ReadOnly = true;
            this.dtgProduct.Size = new System.Drawing.Size(37, 50);
            this.dtgProduct.TabIndex = 7;
            // 
            // dtgProductStat
            // 
            this.dtgProductStat.AllowUserToAddRows = false;
            this.dtgProductStat.AllowUserToDeleteRows = false;
            this.dtgProductStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductStat.Location = new System.Drawing.Point(798, 293);
            this.dtgProductStat.Name = "dtgProductStat";
            this.dtgProductStat.ReadOnly = true;
            this.dtgProductStat.Size = new System.Drawing.Size(51, 75);
            this.dtgProductStat.TabIndex = 8;
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 432);
            this.Controls.Add(this.dtgProductStat);
            this.Controls.Add(this.dtgProduct);
            this.Controls.Add(this.btnSetAsGuide);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dtgOutQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chart1);
            this.Name = "frmGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGraphics";
            this.Load += new System.EventHandler(this.frmGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOutQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgOutQty;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSetAsGuide;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.DataGridView dtgProductStat;
    }
}