namespace ToolsRentSystem.DesktopUI
{
    partial class MainWindow
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btPlaceNewOrder = new System.Windows.Forms.Button();
            this.btAddNewCustomer = new System.Windows.Forms.Button();
            this.btShowAllCustomers = new System.Windows.Forms.Button();
            this.btShowAvalibleTools = new System.Windows.Forms.Button();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btShowTools = new System.Windows.Forms.Button();
            this.gpTool = new System.Windows.Forms.GroupBox();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btCloseRentOrder = new System.Windows.Forms.Button();
            this.btShowAllRents = new System.Windows.Forms.Button();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.dgvRentOrders = new System.Windows.Forms.DataGridView();
            this.RentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gpTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.helpToolStripMenuItem1.Text = "Show Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 390);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btPlaceNewOrder);
            this.tabPage1.Controls.Add(this.btAddNewCustomer);
            this.tabPage1.Controls.Add(this.btShowAllCustomers);
            this.tabPage1.Controls.Add(this.btShowAvalibleTools);
            this.tabPage1.Controls.Add(this.gbCustomers);
            this.tabPage1.Controls.Add(this.btShowTools);
            this.tabPage1.Controls.Add(this.gpTool);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btPlaceNewOrder
            // 
            this.btPlaceNewOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btPlaceNewOrder.Location = new System.Drawing.Point(416, 335);
            this.btPlaceNewOrder.Name = "btPlaceNewOrder";
            this.btPlaceNewOrder.Size = new System.Drawing.Size(95, 23);
            this.btPlaceNewOrder.TabIndex = 8;
            this.btPlaceNewOrder.Text = "New Order";
            this.btPlaceNewOrder.UseVisualStyleBackColor = true;
            this.btPlaceNewOrder.Click += new System.EventHandler(this.btPlaceNewOrder_Click);
            // 
            // btAddNewCustomer
            // 
            this.btAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNewCustomer.Location = new System.Drawing.Point(696, 335);
            this.btAddNewCustomer.Name = "btAddNewCustomer";
            this.btAddNewCustomer.Size = new System.Drawing.Size(95, 23);
            this.btAddNewCustomer.TabIndex = 7;
            this.btAddNewCustomer.Text = "Add customer";
            this.btAddNewCustomer.UseVisualStyleBackColor = true;
            this.btAddNewCustomer.Click += new System.EventHandler(this.btAddNewCustomer_Click);
            // 
            // btShowAllCustomers
            // 
            this.btShowAllCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowAllCustomers.Location = new System.Drawing.Point(595, 335);
            this.btShowAllCustomers.Name = "btShowAllCustomers";
            this.btShowAllCustomers.Size = new System.Drawing.Size(95, 23);
            this.btShowAllCustomers.TabIndex = 1;
            this.btShowAllCustomers.Text = "Show customers";
            this.btShowAllCustomers.UseVisualStyleBackColor = true;
            this.btShowAllCustomers.Click += new System.EventHandler(this.btShowAllCustomers_Click);
            // 
            // btShowAvalibleTools
            // 
            this.btShowAvalibleTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowAvalibleTools.Location = new System.Drawing.Point(239, 335);
            this.btShowAvalibleTools.Name = "btShowAvalibleTools";
            this.btShowAvalibleTools.Size = new System.Drawing.Size(95, 23);
            this.btShowAvalibleTools.TabIndex = 6;
            this.btShowAvalibleTools.Text = "Avalible tools";
            this.btShowAvalibleTools.UseVisualStyleBackColor = true;
            this.btShowAvalibleTools.Click += new System.EventHandler(this.btShowAvalibleTools_Click);
            // 
            // gbCustomers
            // 
            this.gbCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomers.Controls.Add(this.dgvCustomers);
            this.gbCustomers.Location = new System.Drawing.Point(464, 6);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.Size = new System.Drawing.Size(452, 323);
            this.gbCustomers.TabIndex = 5;
            this.gbCustomers.TabStop = false;
            this.gbCustomers.Text = "Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.CustomerSurname,
            this.CustomerContactPhone,
            this.CustomerAdress});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(446, 304);
            this.dgvCustomers.TabIndex = 3;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "Id";
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Width = 21;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 21;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.DataPropertyName = "Surname";
            this.CustomerSurname.HeaderText = "Surname";
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.ReadOnly = true;
            this.CustomerSurname.Width = 21;
            // 
            // CustomerContactPhone
            // 
            this.CustomerContactPhone.DataPropertyName = "ContactPhone";
            this.CustomerContactPhone.HeaderText = "Contact Phone";
            this.CustomerContactPhone.Name = "CustomerContactPhone";
            this.CustomerContactPhone.ReadOnly = true;
            this.CustomerContactPhone.Width = 21;
            // 
            // CustomerAdress
            // 
            this.CustomerAdress.DataPropertyName = "Adress";
            this.CustomerAdress.HeaderText = "Adress";
            this.CustomerAdress.Name = "CustomerAdress";
            this.CustomerAdress.ReadOnly = true;
            this.CustomerAdress.Width = 21;
            // 
            // btShowTools
            // 
            this.btShowTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowTools.Location = new System.Drawing.Point(130, 335);
            this.btShowTools.Name = "btShowTools";
            this.btShowTools.Size = new System.Drawing.Size(95, 23);
            this.btShowTools.TabIndex = 2;
            this.btShowTools.Text = "Show all tools";
            this.btShowTools.UseVisualStyleBackColor = true;
            this.btShowTools.Click += new System.EventHandler(this.btShowTools_Click);
            // 
            // gpTool
            // 
            this.gpTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpTool.Controls.Add(this.dgvTools);
            this.gpTool.Location = new System.Drawing.Point(6, 6);
            this.gpTool.Name = "gpTool";
            this.gpTool.Size = new System.Drawing.Size(452, 323);
            this.gpTool.TabIndex = 4;
            this.gpTool.TabStop = false;
            this.gpTool.Text = "Tools";
            // 
            // dgvTools
            // 
            this.dgvTools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Model,
            this.Manufacturer,
            this.Kind,
            this.SerialNumber,
            this.Cost});
            this.dgvTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTools.Location = new System.Drawing.Point(3, 16);
            this.dgvTools.MultiSelect = false;
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.ReadOnly = true;
            this.dgvTools.Size = new System.Drawing.Size(446, 304);
            this.dgvTools.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 21;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 21;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Width = 21;
            // 
            // Kind
            // 
            this.Kind.DataPropertyName = "Kind";
            this.Kind.HeaderText = "Kind";
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            this.Kind.Width = 21;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 21;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btCloseRentOrder);
            this.tabPage2.Controls.Add(this.btShowAllRents);
            this.tabPage2.Controls.Add(this.gbOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btCloseRentOrder
            // 
            this.btCloseRentOrder.Location = new System.Drawing.Point(111, 331);
            this.btCloseRentOrder.Name = "btCloseRentOrder";
            this.btCloseRentOrder.Size = new System.Drawing.Size(95, 23);
            this.btCloseRentOrder.TabIndex = 2;
            this.btCloseRentOrder.Text = "Close rent";
            this.btCloseRentOrder.UseVisualStyleBackColor = true;
            this.btCloseRentOrder.Click += new System.EventHandler(this.btCloseRentOrder_Click);
            // 
            // btShowAllRents
            // 
            this.btShowAllRents.Location = new System.Drawing.Point(10, 331);
            this.btShowAllRents.Name = "btShowAllRents";
            this.btShowAllRents.Size = new System.Drawing.Size(95, 23);
            this.btShowAllRents.TabIndex = 1;
            this.btShowAllRents.Text = "Show orders";
            this.btShowAllRents.UseVisualStyleBackColor = true;
            this.btShowAllRents.Click += new System.EventHandler(this.btShowAllRents_Click);
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.dgvRentOrders);
            this.gbOrders.Location = new System.Drawing.Point(7, 7);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(912, 318);
            this.gbOrders.TabIndex = 0;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "AllOrders";
            // 
            // dgvRentOrders
            // 
            this.dgvRentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvRentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentId,
            this.ToolModel,
            this.ToolManufacturer,
            this.ToolKind,
            this.DateStart,
            this.DateEnd,
            this.RentStatus,
            this.RentPrice,
            this.CName,
            this.CSurname,
            this.CContactPhone,
            this.CAdress,
            this.OName,
            this.OSurname});
            this.dgvRentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentOrders.Location = new System.Drawing.Point(3, 16);
            this.dgvRentOrders.Name = "dgvRentOrders";
            this.dgvRentOrders.Size = new System.Drawing.Size(906, 299);
            this.dgvRentOrders.TabIndex = 0;
            this.dgvRentOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRentOrders_CellFormatting);
            this.dgvRentOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRentOrders_DataBindingComplete);
            // 
            // RentId
            // 
            this.RentId.DataPropertyName = "Id";
            this.RentId.HeaderText = "Id";
            this.RentId.Name = "RentId";
            this.RentId.Width = 21;
            // 
            // ToolModel
            // 
            this.ToolModel.DataPropertyName = "RTool.Model";
            this.ToolModel.HeaderText = "Model";
            this.ToolModel.Name = "ToolModel";
            this.ToolModel.Width = 21;
            // 
            // ToolManufacturer
            // 
            this.ToolManufacturer.DataPropertyName = "RTool.Manufacturer";
            this.ToolManufacturer.HeaderText = "Manufacturer";
            this.ToolManufacturer.Name = "ToolManufacturer";
            this.ToolManufacturer.Width = 21;
            // 
            // ToolKind
            // 
            this.ToolKind.DataPropertyName = "RTool.Kind";
            this.ToolKind.HeaderText = "Kind";
            this.ToolKind.Name = "ToolKind";
            this.ToolKind.Width = 21;
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "Start date";
            this.DateStart.Name = "DateStart";
            this.DateStart.Width = 21;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "End date";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Width = 21;
            // 
            // RentStatus
            // 
            this.RentStatus.DataPropertyName = "RentStatus";
            this.RentStatus.HeaderText = "Rent status";
            this.RentStatus.Name = "RentStatus";
            this.RentStatus.Width = 21;
            // 
            // RentPrice
            // 
            this.RentPrice.DataPropertyName = "RentPrice";
            this.RentPrice.HeaderText = "Rent price";
            this.RentPrice.Name = "RentPrice";
            this.RentPrice.Width = 21;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "RCustomer.Name";
            this.CName.HeaderText = "Customer name";
            this.CName.Name = "CName";
            this.CName.Width = 21;
            // 
            // CSurname
            // 
            this.CSurname.DataPropertyName = "RCustomer.Surname";
            this.CSurname.HeaderText = "Customer surname";
            this.CSurname.Name = "CSurname";
            this.CSurname.Width = 21;
            // 
            // CContactPhone
            // 
            this.CContactPhone.DataPropertyName = "RCustomer.ContactPhone";
            this.CContactPhone.HeaderText = "Contact phone";
            this.CContactPhone.Name = "CContactPhone";
            this.CContactPhone.Width = 21;
            // 
            // CAdress
            // 
            this.CAdress.DataPropertyName = "RCustomer.Adress";
            this.CAdress.HeaderText = "Adress";
            this.CAdress.Name = "CAdress";
            this.CAdress.Width = 21;
            // 
            // OName
            // 
            this.OName.DataPropertyName = "ROperator.Name";
            this.OName.HeaderText = "Operator name";
            this.OName.Name = "OName";
            this.OName.Width = 21;
            // 
            // OSurname
            // 
            this.OSurname.DataPropertyName = "ROperator.Surname";
            this.OSurname.HeaderText = "Operator surname";
            this.OSurname.Name = "OSurname";
            this.OSurname.Width = 21;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 458);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools Rent System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gpTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btShowTools;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.GroupBox gpTool;
        private System.Windows.Forms.Button btShowAvalibleTools;
        private System.Windows.Forms.Button btShowAllCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAdress;
        private System.Windows.Forms.Button btAddNewCustomer;
        private System.Windows.Forms.Button btPlaceNewOrder;
        private System.Windows.Forms.Button btShowAllRents;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.DataGridView dgvRentOrders;
        private System.Windows.Forms.Button btCloseRentOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSurname;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

