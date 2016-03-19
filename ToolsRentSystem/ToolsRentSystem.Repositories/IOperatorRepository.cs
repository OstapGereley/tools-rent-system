using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    interface IOperatorRepository
    {
        bool CheckLoginOperator(string login, string password);
    }
}
