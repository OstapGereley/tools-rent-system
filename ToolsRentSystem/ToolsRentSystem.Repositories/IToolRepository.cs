using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    interface IToolRepository
    {
        List<Tool> SelectTools(string selection);

    }
}
