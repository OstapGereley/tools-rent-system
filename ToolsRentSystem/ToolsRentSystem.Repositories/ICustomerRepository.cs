using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    interface ICustomerRepository
    {
        List<Customer> SelectAllCustomers();
        void AddNewCustomer(Customer customer);
    }
}
