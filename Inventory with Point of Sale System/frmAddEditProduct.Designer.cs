namespace Inventory_with_Point_of_Sale_System
{
    partial class frmAddEditProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblCloseForm = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.l12 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l10 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.cmbBigItem = new System.Windows.Forms.ComboBox();
            this.cmbProdType = new System.Windows.Forms.ComboBox();
            this.cmbSupp = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblFormName);
            this.panel1.Controls.Add(this.lblCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 44);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(274, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFormName.Location = new System.Drawing.Point(11, 13);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(124, 18);
            this.lblFormName.TabIndex = 1;
            this.lblFormName.Text = "Add/Edit Product";
            // 
            // lblCloseForm
            // 
            this.lblCloseForm.AutoSize = true;
            this.lblCloseForm.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCloseForm.Location = new System.Drawing.Point(335, 13);
            this.lblCloseForm.Name = "lblCloseForm";
            this.lblCloseForm.Size = new System.Drawing.Size(25, 25);
            this.lblCloseForm.TabIndex = 0;
            this.lblCloseForm.Text = "X";
            this.lblCloseForm.Click += new System.EventHandler(this.lblCloseForm_Click);
            this.lblCloseForm.MouseLeave += new System.EventHandler(this.lblCloseForm_MouseLeave);
            this.lblCloseForm.MouseHover += new System.EventHandler(this.lblCloseForm_MouseHover);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(85, 83);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(41, 15);
            this.l1.TabIndex = 2;
            this.l1.Text = "Name:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(70, 110);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(56, 15);
            this.l2.TabIndex = 3;
            this.l2.Text = "Quantity:";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(64, 191);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(62, 15);
            this.l5.TabIndex = 4;
            this.l5.Text = "Base Price:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(53, 218);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(73, 15);
            this.l6.TabIndex = 5;
            this.l6.Text = "Selling Price:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(94, 137);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(32, 15);
            this.l3.TabIndex = 6;
            this.l3.Text = "Unit:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(73, 164);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(53, 15);
            this.l4.TabIndex = 7;
            this.l4.Text = "Supplier:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(151, 107);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 22);
            this.txtQty.TabIndex = 1;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(151, 134);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 22);
            this.txtUnit.TabIndex = 2;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(151, 188);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(100, 22);
            this.txtBP.TabIndex = 4;
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(151, 215);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(100, 22);
            this.txtSP.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(97, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(178, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 43);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Location = new System.Drawing.Point(82, 385);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(44, 15);
            this.l12.TabIndex = 16;
            this.l12.Text = "Model:";
            // 
            // l13
            // 
            this.l13.AutoSize = true;
            this.l13.Location = new System.Drawing.Point(49, 413);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(77, 15);
            this.l13.TabIndex = 17;
            this.l13.Text = "Part Number:";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(71, 245);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(55, 15);
            this.l7.TabIndex = 18;
            this.l7.Text = "Location:";
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.Location = new System.Drawing.Point(42, 329);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(84, 15);
            this.l10.TabIndex = 19;
            this.l10.Text = "Serial Number:";
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Location = new System.Drawing.Point(34, 357);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(92, 15);
            this.l11.TabIndex = 20;
            this.l11.Text = "Engine Number:";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Location = new System.Drawing.Point(73, 300);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(53, 15);
            this.l9.TabIndex = 21;
            this.l9.Text = "Big Item:";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(47, 271);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(79, 15);
            this.l8.TabIndex = 22;
            this.l8.Text = "Product Type:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(151, 382);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 11;
            // 
            // txtPartNum
            // 
            this.txtPartNum.Location = new System.Drawing.Point(151, 410);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(100, 22);
            this.txtPartNum.TabIndex = 12;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(151, 242);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 22);
            this.txtLoc.TabIndex = 6;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(151, 326);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 22);
            this.txtSN.TabIndex = 9;
            // 
            // txtEN
            // 
            this.txtEN.Location = new System.Drawing.Point(151, 354);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(100, 22);
            this.txtEN.TabIndex = 10;
            // 
            // cmbBigItem
            // 
            this.cmbBigItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbBigItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBigItem.FormattingEnabled = true;
            this.cmbBigItem.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbBigItem.Location = new System.Drawing.Point(151, 297);
            this.cmbBigItem.Name = "cmbBigItem";
            this.cmbBigItem.Size = new System.Drawing.Size(100, 23);
            this.cmbBigItem.TabIndex = 8;
            this.cmbBigItem.Text = "False";
            // 
            // cmbProdType
            // 
            this.cmbProdType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbProdType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProdType.FormattingEnabled = true;
            this.cmbProdType.Items.AddRange(new object[] {
            "Seeds",
            "Equipments",
            "Others"});
            this.cmbProdType.Location = new System.Drawing.Point(151, 268);
            this.cmbProdType.Name = "cmbProdType";
            this.cmbProdType.Size = new System.Drawing.Size(100, 23);
            this.cmbProdType.TabIndex = 7;
            this.cmbProdType.Text = "Seeds";
            // 
            // cmbSupp
            // 
            this.cmbSupp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupp.FormattingEnabled = true;
            this.cmbSupp.Items.AddRange(new object[] {
            "Condor Allied",
            "Eastwest",
            "Harbest",
            "Kubota",
            "Others"});
            this.cmbSupp.Location = new System.Drawing.Point(151, 160);
            this.cmbSupp.Name = "cmbSupp";
            this.cmbSupp.Size = new System.Drawing.Size(100, 23);
            this.cmbSupp.TabIndex = 3;
            this.cmbSupp.Text = "Condor Allied";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 10);
            this.panel2.TabIndex = 23;
            // 
            // frmAddEditProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(310, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbSupp);
            this.Controls.Add(this.cmbProdType);
            this.Controls.Add(this.cmbBigItem);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtPartNum);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.l11);
            this.Controls.Add(this.l10);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l13);
            this.Controls.Add(this.l12);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtBP);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblCloseForm;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.ComboBox cmbBigItem;
        private System.Windows.Forms.ComboBox cmbProdType;
        private System.Windows.Forms.ComboBox cmbSupp;
        private System.Windows.Forms.Panel panel2;
    }
}