namespace Inventory_with_Point_of_Sale_System
{
    partial class frmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgSeeds = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBigItem = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblEngineN = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblSerialN = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPartNum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSellP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblSupp = new System.Windows.Forms.Label();
            this.lblBasep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSeedsInventory = new System.Windows.Forms.Button();
            this.btnEquipmentsInventory = new System.Windows.Forms.Button();
            this.btnOthersInventory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCloseForm = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCriticalQty = new System.Windows.Forms.Button();
            this.btnInflow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSeeds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgSeeds
            // 
            this.dtgSeeds.AllowUserToAddRows = false;
            this.dtgSeeds.AllowUserToDeleteRows = false;
            this.dtgSeeds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSeeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSeeds.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgSeeds.Location = new System.Drawing.Point(185, 50);
            this.dtgSeeds.Name = "dtgSeeds";
            this.dtgSeeds.ReadOnly = true;
            this.dtgSeeds.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgSeeds.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSeeds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgSeeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSeeds.Size = new System.Drawing.Size(288, 318);
            this.dtgSeeds.TabIndex = 0;
            this.dtgSeeds.TabStop = false;
            this.dtgSeeds.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgSeeds_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBigItem);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblEngineN);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblSerialN);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblPartNum);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblSellP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.lblSupp);
            this.groupBox1.Controls.Add(this.lblBasep);
            this.groupBox1.Location = new System.Drawing.Point(479, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBigItem
            // 
            this.lblBigItem.AutoSize = true;
            this.lblBigItem.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigItem.Location = new System.Drawing.Point(124, 325);
            this.lblBigItem.Name = "lblBigItem";
            this.lblBigItem.Size = new System.Drawing.Size(20, 15);
            this.lblBigItem.TabIndex = 29;
            this.lblBigItem.Text = "- -";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 325);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 15);
            this.label20.TabIndex = 28;
            this.label20.Text = "Big Item:";
            // 
            // lblEngineN
            // 
            this.lblEngineN.AutoSize = true;
            this.lblEngineN.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineN.Location = new System.Drawing.Point(124, 298);
            this.lblEngineN.Name = "lblEngineN";
            this.lblEngineN.Size = new System.Drawing.Size(20, 15);
            this.lblEngineN.TabIndex = 27;
            this.lblEngineN.Text = "- -";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 298);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 15);
            this.label18.TabIndex = 26;
            this.label18.Text = "Engine Number:";
            // 
            // lblSerialN
            // 
            this.lblSerialN.AutoSize = true;
            this.lblSerialN.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialN.Location = new System.Drawing.Point(124, 271);
            this.lblSerialN.Name = "lblSerialN";
            this.lblSerialN.Size = new System.Drawing.Size(20, 15);
            this.lblSerialN.TabIndex = 25;
            this.lblSerialN.Text = "- -";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "Serial Number:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(124, 245);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(20, 15);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "- -";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Location:";
            // 
            // lblPartNum
            // 
            this.lblPartNum.AutoSize = true;
            this.lblPartNum.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNum.Location = new System.Drawing.Point(124, 220);
            this.lblPartNum.Name = "lblPartNum";
            this.lblPartNum.Size = new System.Drawing.Size(20, 15);
            this.lblPartNum.TabIndex = 21;
            this.lblPartNum.Text = "- -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Part Number:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(124, 195);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(20, 15);
            this.lblModel.TabIndex = 19;
            this.lblModel.Text = "- -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Model:";
            // 
            // lblSellP
            // 
            this.lblSellP.AutoSize = true;
            this.lblSellP.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellP.Location = new System.Drawing.Point(124, 170);
            this.lblSellP.Name = "lblSellP";
            this.lblSellP.Size = new System.Drawing.Size(20, 15);
            this.lblSellP.TabIndex = 17;
            this.lblSellP.Text = "- -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Selling Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Supplier:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Base Price:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(124, 49);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(20, 15);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "- -";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(124, 74);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(20, 15);
            this.lblQty.TabIndex = 12;
            this.lblQty.Text = "- -";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(124, 98);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(20, 15);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "- -";
            // 
            // lblSupp
            // 
            this.lblSupp.AutoSize = true;
            this.lblSupp.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupp.Location = new System.Drawing.Point(124, 122);
            this.lblSupp.Name = "lblSupp";
            this.lblSupp.Size = new System.Drawing.Size(20, 15);
            this.lblSupp.TabIndex = 14;
            this.lblSupp.Text = "- -";
            // 
            // lblBasep
            // 
            this.lblBasep.AutoSize = true;
            this.lblBasep.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasep.Location = new System.Drawing.Point(124, 146);
            this.lblBasep.Name = "lblBasep";
            this.lblBasep.Size = new System.Drawing.Size(20, 15);
            this.lblBasep.TabIndex = 15;
            this.lblBasep.Text = "- -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.Location = new System.Drawing.Point(63, 41);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(102, 22);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnSeedsInventory
            // 
            this.btnSeedsInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSeedsInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeedsInventory.FlatAppearance.BorderSize = 0;
            this.btnSeedsInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSeedsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeedsInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeedsInventory.Location = new System.Drawing.Point(0, 96);
            this.btnSeedsInventory.Name = "btnSeedsInventory";
            this.btnSeedsInventory.Size = new System.Drawing.Size(184, 40);
            this.btnSeedsInventory.TabIndex = 4;
            this.btnSeedsInventory.Text = "Seeds Inventory";
            this.btnSeedsInventory.UseVisualStyleBackColor = false;
            this.btnSeedsInventory.Click += new System.EventHandler(this.btnSeedsInventory_Click);
            this.btnSeedsInventory.MouseHover += new System.EventHandler(this.btnSeedsInventory_MouseHover);
            // 
            // btnEquipmentsInventory
            // 
            this.btnEquipmentsInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEquipmentsInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipmentsInventory.FlatAppearance.BorderSize = 0;
            this.btnEquipmentsInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnEquipmentsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipmentsInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipmentsInventory.Location = new System.Drawing.Point(0, 137);
            this.btnEquipmentsInventory.Name = "btnEquipmentsInventory";
            this.btnEquipmentsInventory.Size = new System.Drawing.Size(184, 40);
            this.btnEquipmentsInventory.TabIndex = 5;
            this.btnEquipmentsInventory.Text = "Equipments Inventory";
            this.btnEquipmentsInventory.UseVisualStyleBackColor = false;
            this.btnEquipmentsInventory.Click += new System.EventHandler(this.btnEquipmentsInventory_Click);
            this.btnEquipmentsInventory.MouseHover += new System.EventHandler(this.btnEquipmentsInventory_MouseHover);
            // 
            // btnOthersInventory
            // 
            this.btnOthersInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOthersInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOthersInventory.FlatAppearance.BorderSize = 0;
            this.btnOthersInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnOthersInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthersInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOthersInventory.Location = new System.Drawing.Point(0, 178);
            this.btnOthersInventory.Name = "btnOthersInventory";
            this.btnOthersInventory.Size = new System.Drawing.Size(184, 40);
            this.btnOthersInventory.TabIndex = 6;
            this.btnOthersInventory.Text = "Inventory (Others)";
            this.btnOthersInventory.UseVisualStyleBackColor = false;
            this.btnOthersInventory.Click += new System.EventHandler(this.btnOthersInventory_Click);
            this.btnOthersInventory.MouseHover += new System.EventHandler(this.btnOthersInventory_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(0, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblCloseForm);
            this.panel1.Controls.Add(this.lblFormName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 48);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblCloseForm
            // 
            this.lblCloseForm.AutoSize = true;
            this.lblCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseForm.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCloseForm.Location = new System.Drawing.Point(746, 11);
            this.lblCloseForm.Name = "lblCloseForm";
            this.lblCloseForm.Size = new System.Drawing.Size(25, 25);
            this.lblCloseForm.TabIndex = 1;
            this.lblCloseForm.Text = "X";
            this.lblCloseForm.Click += new System.EventHandler(this.lblCloseForm_Click);
            this.lblCloseForm.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            this.lblCloseForm.MouseHover += new System.EventHandler(this.label8_MouseHover);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormName.Location = new System.Drawing.Point(11, 12);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(100, 25);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Inventory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnCriticalQty);
            this.panel2.Controls.Add(this.btnInflow);
            this.panel2.Controls.Add(this.btnSeedsInventory);
            this.panel2.Controls.Add(this.btnEquipmentsInventory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOthersInventory);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.txtSearchName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 403);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCriticalQty
            // 
            this.btnCriticalQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCriticalQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriticalQty.FlatAppearance.BorderSize = 0;
            this.btnCriticalQty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCriticalQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriticalQty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriticalQty.Location = new System.Drawing.Point(-3, 279);
            this.btnCriticalQty.Name = "btnCriticalQty";
            this.btnCriticalQty.Size = new System.Drawing.Size(184, 40);
            this.btnCriticalQty.TabIndex = 9;
            this.btnCriticalQty.Text = "Monitor Inventory";
            this.btnCriticalQty.UseVisualStyleBackColor = false;
            this.btnCriticalQty.Click += new System.EventHandler(this.btnCriticalQty_Click);
            // 
            // btnInflow
            // 
            this.btnInflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInflow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInflow.FlatAppearance.BorderSize = 0;
            this.btnInflow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnInflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInflow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInflow.Location = new System.Drawing.Point(0, 320);
            this.btnInflow.Name = "btnInflow";
            this.btnInflow.Size = new System.Drawing.Size(184, 40);
            this.btnInflow.TabIndex = 8;
            this.btnInflow.Text = "Seeds In";
            this.btnInflow.UseVisualStyleBackColor = false;
            this.btnInflow.Click += new System.EventHandler(this.btnInflow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(214, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(295, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(376, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 8);
            this.panel3.TabIndex = 10;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgSeeds);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seeds Inventory";
            this.Load += new System.EventHandler(this.frmSeedsInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSeeds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSeeds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSellP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblSupp;
        private System.Windows.Forms.Label lblBasep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSeedsInventory;
        private System.Windows.Forms.Button btnEquipmentsInventory;
        private System.Windows.Forms.Button btnOthersInventory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCloseForm;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblBigItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblEngineN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblSerialN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPartNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInflow;
        private System.Windows.Forms.Button btnCriticalQty;
    }
}