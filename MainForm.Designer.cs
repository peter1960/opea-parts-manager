﻿namespace OPEAManager
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripFranchise = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabLocations = new System.Windows.Forms.TabPage();
            this.tabFranchise = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridFranchise = new System.Windows.Forms.DataGridView();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTabSupplierAdd = new System.Windows.Forms.Button();
            this.dataGridSuppliers = new System.Windows.Forms.DataGridView();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComanySave = new System.Windows.Forms.Button();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSystemReset = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.companyControl1 = new OPEAManager.Controls.CompanyControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.tabFranchise.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFranchise)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            this.tabCompany.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu1
            // 
            this.Menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(35, 20);
            this.Menu1.Text = "File";
            this.Menu1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MainTabControl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(879, 501);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainTabControl.Controls.Add(this.tabStock);
            this.MainTabControl.Controls.Add(this.tabCart);
            this.MainTabControl.Controls.Add(this.tabOrders);
            this.MainTabControl.Controls.Add(this.tabLocations);
            this.MainTabControl.Controls.Add(this.tabFranchise);
            this.MainTabControl.Controls.Add(this.tabSuppliers);
            this.MainTabControl.Controls.Add(this.tabCompany);
            this.MainTabControl.Controls.Add(this.tabSystem);
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(876, 442);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.MainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.toolStripTop);
            this.tabStock.Controls.Add(this.dataGridStock);
            this.tabStock.Controls.Add(this.checkBox1);
            this.tabStock.Controls.Add(this.button2);
            this.tabStock.Controls.Add(this.textBox1);
            this.tabStock.Location = new System.Drawing.Point(23, 4);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(849, 434);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // toolStripTop
            // 
            this.toolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripFranchise});
            this.toolStripTop.Location = new System.Drawing.Point(3, 3);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(843, 25);
            this.toolStripTop.Stretch = true;
            this.toolStripTop.TabIndex = 5;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Franchise";
            // 
            // toolStripFranchise
            // 
            this.toolStripFranchise.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripFranchise.Name = "toolStripFranchise";
            this.toolStripFranchise.Size = new System.Drawing.Size(121, 25);
            // 
            // dataGridStock
            // 
            this.dataGridStock.AllowUserToAddRows = false;
            this.dataGridStock.AllowUserToDeleteRows = false;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(3, 31);
            this.dataGridStock.MultiSelect = false;
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.ReadOnly = true;
            this.dataGridStock.RowHeadersVisible = false;
            this.dataGridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStock.Size = new System.Drawing.Size(843, 342);
            this.dataGridStock.TabIndex = 0;
            this.dataGridStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStock_CellContentClick);
            this.dataGridStock.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridStock_NewRowNeeded);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(334, 413);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Stocked";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(253, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(3, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabOrders
            // 
            this.tabOrders.Location = new System.Drawing.Point(23, 4);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(849, 434);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // tabLocations
            // 
            this.tabLocations.Location = new System.Drawing.Point(23, 4);
            this.tabLocations.Name = "tabLocations";
            this.tabLocations.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocations.Size = new System.Drawing.Size(849, 434);
            this.tabLocations.TabIndex = 6;
            this.tabLocations.Text = "Locations";
            this.tabLocations.UseVisualStyleBackColor = true;
            // 
            // tabFranchise
            // 
            this.tabFranchise.Controls.Add(this.groupBox3);
            this.tabFranchise.Location = new System.Drawing.Point(23, 4);
            this.tabFranchise.Name = "tabFranchise";
            this.tabFranchise.Padding = new System.Windows.Forms.Padding(3);
            this.tabFranchise.Size = new System.Drawing.Size(849, 434);
            this.tabFranchise.TabIndex = 2;
            this.tabFranchise.Text = "Franchise";
            this.tabFranchise.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridFranchise);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 428);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Franchise";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridFranchise
            // 
            this.dataGridFranchise.AllowUserToAddRows = false;
            this.dataGridFranchise.AllowUserToDeleteRows = false;
            this.dataGridFranchise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFranchise.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridFranchise.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridFranchise.Location = new System.Drawing.Point(3, 16);
            this.dataGridFranchise.Name = "dataGridFranchise";
            this.dataGridFranchise.RowHeadersVisible = false;
            this.dataGridFranchise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFranchise.Size = new System.Drawing.Size(581, 409);
            this.dataGridFranchise.TabIndex = 0;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.groupBox2);
            this.tabSuppliers.Location = new System.Drawing.Point(23, 4);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(849, 434);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTabSupplierAdd);
            this.groupBox2.Controls.Add(this.dataGridSuppliers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 428);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppliers";
            // 
            // buttonTabSupplierAdd
            // 
            this.buttonTabSupplierAdd.Location = new System.Drawing.Point(762, 16);
            this.buttonTabSupplierAdd.Name = "buttonTabSupplierAdd";
            this.buttonTabSupplierAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTabSupplierAdd.TabIndex = 1;
            this.buttonTabSupplierAdd.Text = "Add";
            this.buttonTabSupplierAdd.UseVisualStyleBackColor = true;
            this.buttonTabSupplierAdd.Click += new System.EventHandler(this.buttonTabSupplierAdd_Click);
            // 
            // dataGridSuppliers
            // 
            this.dataGridSuppliers.AllowUserToAddRows = false;
            this.dataGridSuppliers.AllowUserToDeleteRows = false;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridSuppliers.Location = new System.Drawing.Point(3, 16);
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.RowHeadersVisible = false;
            this.dataGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuppliers.Size = new System.Drawing.Size(581, 409);
            this.dataGridSuppliers.TabIndex = 0;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.label1);
            this.tabCompany.Controls.Add(this.buttonComanySave);
            this.tabCompany.Controls.Add(this.companyControl1);
            this.tabCompany.Location = new System.Drawing.Point(23, 4);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Size = new System.Drawing.Size(849, 434);
            this.tabCompany.TabIndex = 5;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Values below are used on printed documents";
            // 
            // buttonComanySave
            // 
            this.buttonComanySave.Location = new System.Drawing.Point(291, 71);
            this.buttonComanySave.Name = "buttonComanySave";
            this.buttonComanySave.Size = new System.Drawing.Size(75, 23);
            this.buttonComanySave.TabIndex = 3;
            this.buttonComanySave.Text = "Save";
            this.buttonComanySave.UseVisualStyleBackColor = true;
            this.buttonComanySave.Click += new System.EventHandler(this.buttonComanySave_Click);
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.groupBox1);
            this.tabSystem.Controls.Add(this.buttonLoad);
            this.tabSystem.Location = new System.Drawing.Point(23, 4);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(849, 434);
            this.tabSystem.TabIndex = 4;
            this.tabSystem.Text = "System";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSystemReset);
            this.groupBox1.Location = new System.Drawing.Point(520, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // buttonSystemReset
            // 
            this.buttonSystemReset.Location = new System.Drawing.Point(6, 71);
            this.buttonSystemReset.Name = "buttonSystemReset";
            this.buttonSystemReset.Size = new System.Drawing.Size(75, 23);
            this.buttonSystemReset.TabIndex = 1;
            this.buttonSystemReset.Text = "Reset";
            this.buttonSystemReset.UseVisualStyleBackColor = true;
            this.buttonSystemReset.Click += new System.EventHandler(this.buttonSystemReset_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(63, 120);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load OPEA";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.OPEA_Load_Click);
            // 
            // tabCart
            // 
            this.tabCart.Location = new System.Drawing.Point(23, 4);
            this.tabCart.Name = "tabCart";
            this.tabCart.Size = new System.Drawing.Size(849, 434);
            this.tabCart.TabIndex = 7;
            this.tabCart.Text = "Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // companyControl1
            // 
            this.companyControl1.Location = new System.Drawing.Point(3, 61);
            this.companyControl1.Name = "companyControl1";
            this.companyControl1.Size = new System.Drawing.Size(282, 289);
            this.companyControl1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 547);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "OPEA Manager";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.tabFranchise.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFranchise)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            this.tabCompany.ResumeLayout(false);
            this.tabCompany.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripFranchise;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabLocations;
        private System.Windows.Forms.TabPage tabFranchise;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridFranchise;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTabSupplierAdd;
        private System.Windows.Forms.DataGridView dataGridSuppliers;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComanySave;
        private Controls.CompanyControl companyControl1;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSystemReset;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TabPage tabCart;
       
    }
}

