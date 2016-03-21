using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    /// <summary>
    /// Interface for working with tblOperator
    /// </summary>
    interface IOperatorRepository
    {
        /// <summary>
        /// Verifies login and password, returns if operator exists and operatorId 
        /// </summary>
        /// <param name="login">Operators login</param>
        /// <param name="password">Hashed operators password</param>
        /// <param name="operatorId">Provides operator id</param>
        /// <returns>States if operator record exists</returns>
        bool CheckLoginOperator(string login, string password, out int operatorId );
    }
}
