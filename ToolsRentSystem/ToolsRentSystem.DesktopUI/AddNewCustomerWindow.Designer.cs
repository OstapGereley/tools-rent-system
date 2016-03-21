namespace ToolsRentSystem.DesktopUI
{
    partial class AddNewCustomerWindow
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
            this.gbCusomer = new System.Windows.Forms.GroupBox();
            this.lAdress = new System.Windows.Forms.Label();
            this.lContactPhone = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbContactPhone = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbCusomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCusomer
            // 
            this.gbCusomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCusomer.Controls.Add(this.lAdress);
            this.gbCusomer.Controls.Add(this.lContactPhone);
            this.gbCusomer.Controls.Add(this.lSurname);
            this.gbCusomer.Controls.Add(this.lName);
            this.gbCusomer.Controls.Add(this.tbAdress);
            this.gbCusomer.Controls.Add(this.tbContactPhone);
            this.gbCusomer.Controls.Add(this.tbSurname);
            this.gbCusomer.Controls.Add(this.tbName);
            this.gbCusomer.Location = new System.Drawing.Point(12, 12);
            this.gbCusomer.Name = "gbCusomer";
            this.gbCusomer.Size = new System.Drawing.Size(267, 135);
            this.gbCusomer.TabIndex = 0;
            this.gbCusomer.TabStop = false;
            // 
            // lAdress
            // 
            this.lAdress.AutoSize = true;
            this.lAdress.Location = new System.Drawing.Point(6, 107);
            this.lAdress.Name = "lAdress";
            this.lAdress.Size = new System.Drawing.Size(39, 13);
            this.lAdress.TabIndex = 7;
            this.lAdress.Text = "Adress";
            // 
            // lContactPhone
            // 
            this.lContactPhone.AutoSize = true;
            this.lContactPhone.Location = new System.Drawing.Point(6, 80);
            this.lContactPhone.Name = "lContactPhone";
            this.lContactPhone.Size = new System.Drawing.Size(38, 13);
            this.lContactPhone.TabIndex = 6;
            this.lContactPhone.Text = "Phone";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(6, 53);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(49, 13);
            this.lSurname.TabIndex = 5;
            this.lSurname.Text = "Surname";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(6, 26);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "Name";
            // 
            // tbAdress
            // 
            this.tbAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdress.Location = new System.Drawing.Point(63, 100);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(198, 20);
            this.tbAdress.TabIndex = 3;
            // 
            // tbContactPhone
            // 
            this.tbContactPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContactPhone.Location = new System.Drawing.Point(63, 73);
            this.tbContactPhone.Name = "tbContactPhone";
            this.tbContactPhone.Size = new System.Drawing.Size(198, 20);
            this.tbContactPhone.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSurname.Location = new System.Drawing.Point(63, 46);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(198, 20);
            this.tbSurname.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(63, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(198, 20);
            this.tbName.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(61, 153);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add ";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(153, 153);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // AddNewCustomerWindow
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(291, 186);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gbCusomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNewCustomerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.gbCusomer.ResumeLayout(false);
            this.gbCusomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCusomer;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lAdress;
        private System.Windows.Forms.Label lContactPhone;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbContactPhone;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
    }
}