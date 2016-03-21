using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsRentSystem.Entities;
using ToolsRentSystem.Repositories;

namespace ToolsRentSystem.DesktopUI
{
    public partial class AddNewCustomerWindow : Form
    {
        public AddNewCustomerWindow()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //checks inputs for length and isempty
            if (tbName.Text.Length <= 50 && !String.IsNullOrWhiteSpace(tbName.Text)
                && tbSurname.Text.Length <= 50 && !String.IsNullOrWhiteSpace(tbSurname.Text)
                && tbContactPhone.Text.Length <= 50 && !String.IsNullOrWhiteSpace(tbContactPhone.Text)
                && tbAdress.Text.Length <= 50 && !String.IsNullOrWhiteSpace(tbAdress.Text))
            {
                var customerRepository = new SqlCustomerRepository(Globals.connectionString);
                customerRepository.AddNewCustomer(new Customer()
                {
                    Adress = tbAdress.Text,
                    ContactPhone = tbContactPhone.Text,
                    Name = tbName.Text,
                    Surname = tbSurname.Text
                });
                this.Close();
            }
            else
            {
                MessageBox.Show("Plesae verify input data", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
