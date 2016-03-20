using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    interface IRentOrderRepository
    {
        void CreateRent(RentOrder rentOrder);
        void CloseRent(int id);
        List<RentOrder> SelectAll();
    }
}
