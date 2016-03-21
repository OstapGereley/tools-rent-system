using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    /// <summary>
    /// Interface for working with tblTool
    /// </summary>
    interface IToolRepository
    {
        /// <summary>
        /// Selects records according to condition
        /// </summary>
        /// <param name="selection">Condition of selection</param>
        /// <returns>List of tools</returns>
        List<Tool> SelectTools(string selection);

    }
}
