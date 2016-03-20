using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsRentSystem.Entities;
using ToolsRentSystem.Repositories;

namespace ToolsRentSystem.DesktopUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btShowTools_Click(object sender, EventArgs e)
        {

            var toolRepository = new SqlToolRepository(Globals.connectionString);
            var toolList = toolRepository.SelectTools("All");
            dgvTools.DataSource = toolList;

        }

        private void btShowAvalibleTools_Click(object sender, EventArgs e)
        {
            var toolRepository = new SqlToolRepository(Globals.connectionString);
            var toolList = toolRepository.SelectTools("Avalible");
            dgvTools.DataSource = toolList;
        }

        private void btShowAllCustomers_Click(object sender, EventArgs e)
        {
            var customerRepository = new SqlCustomerRepository(Globals.connectionString);
            var customerList = customerRepository.SelectAllCustomers();
            dgvCustomers.DataSource = customerList;
        }

        private void btAddNewCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerWindow = new AddNewCustomerWindow();
            addCustomerWindow.ShowDialog();

            btShowAllCustomers_Click(sender, e);
        }

        private void btPlaceNewOrder_Click(object sender, EventArgs e)
        {
            NewRentOrderItem addRent;
            try
            {
                    addRent = new NewRentOrderItem(Convert.ToInt32(dgvTools.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value),
                    Convert.ToDecimal(dgvTools.SelectedRows[0].Cells[5].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select avalible tool row and customer row", "Select error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            

            addRent.ShowDialog();
        }

        private void btShowAllRents_Click(object sender, EventArgs e)
        {
            dgvRentOrders.AutoGenerateColumns = false;
            var showRent = new SqlRentOrderRepository(Globals.connectionString);
            var resList = showRent.SelectAll();
            dgvRentOrders.DataSource = resList;

        }

        private void dgvRentOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }


            foreach (DataGridViewRow myRow in dgvRentOrders.Rows)
            {
                if (Convert.ToInt32(myRow.Cells[6].Value) == 1)
                {
                    myRow.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btCloseRentOrder_Click(object sender, EventArgs e)
        {
            var closeRent = new SqlRentOrderRepository(Globals.connectionString);
            closeRent.CloseRent(Convert.ToInt32(dgvRentOrders.SelectedRows[0].Cells[0].Value));

            btShowAllRents_Click(sender, e);
        }
    }
}
