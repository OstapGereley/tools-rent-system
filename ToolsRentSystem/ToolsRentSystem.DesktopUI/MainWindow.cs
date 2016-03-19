using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
