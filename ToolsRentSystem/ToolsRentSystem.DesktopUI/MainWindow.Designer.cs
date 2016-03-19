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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.btShowTools = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.gpTool = new System.Windows.Forms.GroupBox();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.btShowAvalibleTools = new System.Windows.Forms.Button();
            this.btShowAllCustomers = new System.Windows.Forms.Button();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gpTool.SuspendLayout();
            this.gbCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // btShowAllCustomers
            // 
            this.btShowAllCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowAllCustomers.Location = new System.Drawing.Point(606, 335);
            this.btShowAllCustomers.Name = "btShowAllCustomers";
            this.btShowAllCustomers.Size = new System.Drawing.Size(95, 23);
            this.btShowAllCustomers.TabIndex = 1;
            this.btShowAllCustomers.Text = "Show customers";
            this.btShowAllCustomers.UseVisualStyleBackColor = true;
            this.btShowAllCustomers.Click += new System.EventHandler(this.btShowAllCustomers_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gpTool.ResumeLayout(false);
            this.gbCustomers.ResumeLayout(false);
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
    }
}

