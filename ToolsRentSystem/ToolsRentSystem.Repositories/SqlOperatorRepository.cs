using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    /// <summary>
    /// Provides functionality for tblOperator
    /// </summary>
    public class SqlOperatorRepository : IOperatorRepository
    {
        private readonly string _connectionString;

        public SqlOperatorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Functions

        /// <summary>
        /// Verifies if login and password are correct
        /// </summary>
        /// <param name="login">Operator login</param>
        /// <param name="password">Operator password hash using md5</param>
        /// <param name="operatorId">sets operator id if operator exists</param>
        /// <returns>if operator exists</returns>
        public bool CheckLoginOperator(string login, string password, out int operatorId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand() { Connection = connection })
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spCheckLoginOperator";

                    command.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar) { Value = login });
                    command.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = password });

                    command.Parameters.Add(new SqlParameter("@exists", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    });

                    command.Parameters.Add(new SqlParameter("@operatorId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    });
                    

                    command.ExecuteNonQuery();

                    operatorId = Convert.ToInt32(command.Parameters["@operatorId"].Value);

                    return Convert.ToBoolean(command.Parameters["@exists"].Value);

                }
            }
        }

        #endregion

    }
}

