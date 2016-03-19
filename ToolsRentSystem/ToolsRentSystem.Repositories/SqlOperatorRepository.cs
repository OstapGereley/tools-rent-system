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
    public class SqlOperatorRepository : IOperatorRepository
    {
        private readonly string _connectionString;

        public SqlOperatorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool CheckLoginOperator(string login, string password)
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

                    command.ExecuteNonQuery();

                    return Convert.ToBoolean(command.Parameters["@exists"].Value);

                }
            }
        }

    }
}

