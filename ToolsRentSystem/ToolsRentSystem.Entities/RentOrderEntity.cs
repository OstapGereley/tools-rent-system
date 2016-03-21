using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsRentSystem.Entities
{
    /// <summary>
    /// RentOrder entity for tblRentOrder and for showing detailed information about orders
    /// </summary>
    public class RentOrder
    {
        public int Id { get; set; }
        public int IdTool { get; set; }
        public int IdCustomer { get; set; }
        public int IdOperator { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int RentStatus { get; set; }
        public decimal RentPrice { get; set; }
        public Customer RCustomer { get; set; }
        public Operator ROperator { get; set; }
        public Tool RTool { get; set; }
    }
}
