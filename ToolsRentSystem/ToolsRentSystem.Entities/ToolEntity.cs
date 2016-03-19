using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsRentSystem.Entities
{
    public class Tool
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Kind { get; set; }
        public string SerialNumber { get; set; }
        public decimal Cost { get; set; }
    }
}
                            