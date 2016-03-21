using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    /// <summary>
    /// Interface for working with tblRentOrder
    /// </summary>
    interface IRentOrderRepository
    {
        /// <summary>
        /// Inserts new record into tblRentOrder
        /// </summary>
        /// <param name="rentOrder">RentOrder entity</param>
        void CreateRent(RentOrder rentOrder);

        /// <summary>
        /// Sets rent status = 2, for given id
        /// </summary>
        /// <param name="id">RentOrder id</param>
        void CloseRent(int id);

        /// <summary>
        /// Returns list of all records in RentOrder
        /// </summary>
        /// <returns>List of RentOrder</returns>
        List<RentOrder> SelectAll();
    }
}
