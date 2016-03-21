using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    /// <summary>
    /// Interface for working with tblCustomer
    /// </summary>
    interface ICustomerRepository
    {
        /// <summary>
        /// Selects all Customers from tblCustomer
        /// </summary>
        /// <returns>Returns list of Customers with all fields</returns>
        List<Customer> SelectAllCustomers();

        /// <summary>
        /// Inserts new customer int tblCustomer
        /// </summary>
        /// <param name="customer">Cstomer entity</param>
        void AddNewCustomer(Customer customer);
    }
}
