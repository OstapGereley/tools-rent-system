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
    public partial class NewRentOrderItem : Form
    {
        private int _toolId;
        private int _customerId;
        private decimal _cost;

        public NewRentOrderItem(int toolId, int customerId, decimal cost)
        {
            _cost = cost;
            _customerId = customerId;
            _toolId = toolId;
            InitializeComponent();
            lCustomerId.Text += _customerId.ToString();
            lToolId.Text += _toolId.ToString();
        }

        private void btAddNewOrder_Click(object sender, EventArgs e)
        {
            var endDate = dtpEndDate.Value.Date;
            var startDate = dtpStartDate.Value.Date;

            var daysRent = (endDate - startDate).Days;

            if (startDate.CompareTo(endDate) < 0)
            {
                var rentOrder = new SqlRentOrderRepository(Globals.connectionString);
                rentOrder.CreateRent(new RentOrder()
                {
                    IdCustomer = _customerId,
                    IdOperator = Globals.currentOperatorId,
                    IdTool = _toolId,
                    RentStatus = 1,
                    RentPrice = daysRent*_cost,
                    DateStart = startDate,
                    DateEnd = endDate
                });

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter correct date", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            var endDate = dtpEndDate.Value.Date;
            var startDate = dtpStartDate.Value.Date;

            var daysRent = (endDate - startDate).Days;

            if (startDate.CompareTo(endDate) < 0)
            {
                lCost.Text = "Cost:" + daysRent*_cost;
            }
            else
            {
                MessageBox.Show("Please enter correct date", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
