namespace ToolsRentSystem.DesktopUI
{
    partial class NewRentOrderItem
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
            this.gbRentOrder = new System.Windows.Forms.GroupBox();
            this.lCost = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lDateEnd = new System.Windows.Forms.Label();
            this.lDateStart = new System.Windows.Forms.Label();
            this.lCustomerId = new System.Windows.Forms.Label();
            this.lToolId = new System.Windows.Forms.Label();
            this.btAddNewOrder = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbRentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRentOrder
            // 
            this.gbRentOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRentOrder.Controls.Add(this.lCost);
            this.gbRentOrder.Controls.Add(this.dtpEndDate);
            this.gbRentOrder.Controls.Add(this.dtpStartDate);
            this.gbRentOrder.Controls.Add(this.lDateEnd);
            this.gbRentOrder.Controls.Add(this.lDateStart);
            this.gbRentOrder.Controls.Add(this.lCustomerId);
            this.gbRentOrder.Controls.Add(this.lToolId);
            this.gbRentOrder.Location = new System.Drawing.Point(12, 12);
            this.gbRentOrder.Name = "gbRentOrder";
            this.gbRentOrder.Size = new System.Drawing.Size(276, 121);
            this.gbRentOrder.TabIndex = 0;
            this.gbRentOrder.TabStop = false;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(10, 54);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(34, 13);
            this.lCost.TabIndex = 7;
            this.lCost.Text = "Cost: ";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(71, 94);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(71, 69);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // lDateEnd
            // 
            this.lDateEnd.AutoSize = true;
            this.lDateEnd.Location = new System.Drawing.Point(10, 97);
            this.lDateEnd.Name = "lDateEnd";
            this.lDateEnd.Size = new System.Drawing.Size(52, 13);
            this.lDateEnd.TabIndex = 4;
            this.lDateEnd.Text = "End Date";
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Location = new System.Drawing.Point(10, 75);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(55, 13);
            this.lDateStart.TabIndex = 3;
            this.lDateStart.Text = "Start Date";
            // 
            // lCustomerId
            // 
            this.lCustomerId.AutoSize = true;
            this.lCustomerId.Location = new System.Drawing.Point(9, 37);
            this.lCustomerId.Name = "lCustomerId";
            this.lCustomerId.Size = new System.Drawing.Size(66, 13);
            this.lCustomerId.TabIndex = 1;
            this.lCustomerId.Text = "CustomerId: ";
            // 
            // lToolId
            // 
            this.lToolId.AutoSize = true;
            this.lToolId.Location = new System.Drawing.Point(7, 20);
            this.lToolId.Name = "lToolId";
            this.lToolId.Size = new System.Drawing.Size(43, 13);
            this.lToolId.TabIndex = 0;
            this.lToolId.Text = "ToolId: ";
            // 
            // btAddNewOrder
            // 
            this.btAddNewOrder.Location = new System.Drawing.Point(49, 139);
            this.btAddNewOrder.Name = "btAddNewOrder";
            this.btAddNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btAddNewOrder.TabIndex = 1;
            this.btAddNewOrder.Text = "Add";
            this.btAddNewOrder.UseVisualStyleBackColor = true;
            this.btAddNewOrder.Click += new System.EventHandler(this.btAddNewOrder_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(162, 139);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // NewRentOrderItem
            // 
            this.AcceptButton = this.btAddNewOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(300, 178);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddNewOrder);
            this.Controls.Add(this.gbRentOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewRentOrderItem";
            this.Text = "NewRentOrderItem";
            this.gbRentOrder.ResumeLayout(false);
            this.gbRentOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRentOrder;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lDateEnd;
        private System.Windows.Forms.Label lDateStart;
        private System.Windows.Forms.Label lCustomerId;
        private System.Windows.Forms.Label lToolId;
        private System.Windows.Forms.Button btAddNewOrder;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lCost;
    }
}