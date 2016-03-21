using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsRentSystem.Entities
{
    /// <summary>
    /// Customer entity for tblCustomer
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactPhone { get; set; }
        public string Adress { get; set; }
    }
}
