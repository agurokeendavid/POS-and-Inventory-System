namespace Inventory_with_Point_of_Sale_System
{
    partial class frmInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInOut));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExitForm = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.dtgProdFlow = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbOutflow = new System.Windows.Forms.RadioButton();
            this.rbInflow = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProdType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbProdType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbpHIdeEyes = new System.Windows.Forms.PictureBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pbHidePanel = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSumSales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdFlow)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpHIdeEyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHidePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblExitForm);
            this.panel1.Controls.Add(this.lblFormName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 52);
            this.panel1.TabIndex = 0;
            // 
            // lblExitForm
            // 
            this.lblExitForm.AutoSize = true;
            this.lblExitForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExitForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExitForm.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExitForm.Location = new System.Drawing.Point(752, 14);
            this.lblExitForm.Name = "lblExitForm";
            this.lblExitForm.Size = new System.Drawing.Size(25, 25);
            this.lblExitForm.TabIndex = 1;
            this.lblExitForm.Text = "X";
            this.lblExitForm.Click += new System.EventHandler(this.lblExitForm_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormName.Location = new System.Drawing.Point(12, 14);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(204, 24);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Product Flow Records";
            // 
            // dtgProdFlow
            // 
            this.dtgProdFlow.AllowUserToAddRows = false;
            this.dtgProdFlow.AllowUserToDeleteRows = false;
            this.dtgProdFlow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgProdFlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProdFlow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgProdFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdFlow.Location = new System.Drawing.Point(72, 52);
            this.dtgProdFlow.Name = "dtgProdFlow";
            this.dtgProdFlow.ReadOnly = true;
            this.dtgProdFlow.RowHeadersVisible = false;
            this.dtgProdFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdFlow.Size = new System.Drawing.Size(720, 413);
            this.dtgProdFlow.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblSumSales);
            this.panel2.Controls.Add(this.rbOutflow);
            this.panel2.Controls.Add(this.rbInflow);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblProdType);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.cmbProdType);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.pbpHIdeEyes);
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblTo);
            this.panel2.Controls.Add(this.lblFrom);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.pbHidePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 413);
            this.panel2.TabIndex = 2;
            // 
            // rbOutflow
            // 
            this.rbOutflow.AutoSize = true;
            this.rbOutflow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOutflow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbOutflow.Location = new System.Drawing.Point(45, 124);
            this.rbOutflow.Name = "rbOutflow";
            this.rbOutflow.Size = new System.Drawing.Size(68, 19);
            this.rbOutflow.TabIndex = 12;
            this.rbOutflow.TabStop = true;
            this.rbOutflow.Text = "Outflow";
            this.rbOutflow.UseVisualStyleBackColor = true;
            this.rbOutflow.Visible = false;
            this.rbOutflow.CheckedChanged += new System.EventHandler(this.rbOutflow_CheckedChanged);
            // 
            // rbInflow
            // 
            this.rbInflow.AutoSize = true;
            this.rbInflow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbInflow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbInflow.Location = new System.Drawing.Point(45, 99);
            this.rbInflow.Name = "rbInflow";
            this.rbInflow.Size = new System.Drawing.Size(58, 19);
            this.rbInflow.TabIndex = 11;
            this.rbInflow.TabStop = true;
            this.rbInflow.Text = "Inflow";
            this.rbInflow.UseVisualStyleBackColor = true;
            this.rbInflow.Visible = false;
            this.rbInflow.CheckedChanged += new System.EventHandler(this.rbInflow_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblProdType
            // 
            this.lblProdType.AutoSize = true;
            this.lblProdType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProdType.Location = new System.Drawing.Point(17, 168);
            this.lblProdType.Name = "lblProdType";
            this.lblProdType.Size = new System.Drawing.Size(79, 15);
            this.lblProdType.TabIndex = 10;
            this.lblProdType.Text = "Product Type:";
            this.lblProdType.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 82);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbProdType
            // 
            this.cmbProdType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProdType.FormattingEnabled = true;
            this.cmbProdType.Items.AddRange(new object[] {
            "All",
            "Seeds",
            "Equipments",
            "Others"});
            this.cmbProdType.Location = new System.Drawing.Point(102, 165);
            this.cmbProdType.Name = "cmbProdType";
            this.cmbProdType.Size = new System.Drawing.Size(95, 23);
            this.cmbProdType.TabIndex = 9;
            this.cmbProdType.Text = "All";
            this.cmbProdType.Visible = false;
            this.cmbProdType.SelectedIndexChanged += new System.EventHandler(this.cmbProdType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(83, 355);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbpHIdeEyes
            // 
            this.pbpHIdeEyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpHIdeEyes.Image = ((System.Drawing.Image)(resources.GetObject("pbpHIdeEyes.Image")));
            this.pbpHIdeEyes.Location = new System.Drawing.Point(168, 12);
            this.pbpHIdeEyes.Name = "pbpHIdeEyes";
            this.pbpHIdeEyes.Size = new System.Drawing.Size(42, 29);
            this.pbpHIdeEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpHIdeEyes.TabIndex = 7;
            this.pbpHIdeEyes.TabStop = false;
            this.pbpHIdeEyes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbpHIdeEyes_MouseClick);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(20, 319);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 6;
            this.dtpTo.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(20, 269);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 5;
            this.dtpFrom.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(102, 207);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(95, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTo.Location = new System.Drawing.Point(29, 301);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(50, 15);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Date To:";
            this.lblTo.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrom.Location = new System.Drawing.Point(29, 251);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(64, 15);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Date From:";
            this.lblFrom.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(55, 210);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Name:";
            this.lblSearch.Visible = false;
            // 
            // pbHidePanel
            // 
            this.pbHidePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHidePanel.Image = ((System.Drawing.Image)(resources.GetObject("pbHidePanel.Image")));
            this.pbHidePanel.Location = new System.Drawing.Point(16, 12);
            this.pbHidePanel.Name = "pbHidePanel";
            this.pbHidePanel.Size = new System.Drawing.Size(42, 29);
            this.pbHidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHidePanel.TabIndex = 0;
            this.pbHidePanel.TabStop = false;
            this.pbHidePanel.Click += new System.EventHandler(this.pbHidePanel_Click);
            this.pbHidePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbHidePanel_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 8);
            this.panel3.TabIndex = 3;
            // 
            // lblSumSales
            // 
            this.lblSumSales.AutoSize = true;
            this.lblSumSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSumSales.Location = new System.Drawing.Point(134, 63);
            this.lblSumSales.Name = "lblSumSales";
            this.lblSumSales.Size = new System.Drawing.Size(20, 15);
            this.lblSumSales.TabIndex = 2;
            this.lblSumSales.Text = "- -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Sales Amount:";
            // 
            // frmInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgProdFlow);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInOut";
            this.Load += new System.EventHandler(this.frmInOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdFlow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpHIdeEyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHidePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExitForm;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.DataGridView dtgProdFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbHidePanel;
        private System.Windows.Forms.PictureBox pbpHIdeEyes;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProdType;
        private System.Windows.Forms.ComboBox cmbProdType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbOutflow;
        private System.Windows.Forms.RadioButton rbInflow;
        private System.Windows.Forms.Label lblSumSales;
        private System.Windows.Forms.Label label1;
    }
}