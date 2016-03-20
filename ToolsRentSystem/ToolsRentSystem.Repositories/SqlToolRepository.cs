using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    public class SqlToolRepository : IToolRepository
    {
        private readonly string _connectionString;

        private const string SelectAllTool = @"SELECT t.Id, t.Model, t.Manufacturer, t.Kind, t.SerialNumber, t.Cost
                                               FROM tblTool t";

        private const string SelectAvalibleTool =
            @"SELECT DISTINCT  t.Id, t.Model, t.Manufacturer, t.Kind, t.SerialNumber, t.Cost
                                                    FROM tblTool t
                                                    LEFT OUTER JOIN tblRentOrder r
                                                    ON t.Id = r.IdTool 
                                                    WHERE r.RentStatus = 2 or r.RentStatus is NULL or (r.DateEnd < GETDATE())";



        public SqlToolRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Tool> SelectTools(string selection)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = connection
                })
                {

                    if (String.CompareOrdinal("All", selection) == 0)
                        command.CommandText = SelectAllTool;

                    if (String.CompareOrdinal("Avalible", selection) == 0)
                        command.CommandText = SelectAvalibleTool;

                    using (var reader = command.ExecuteReader())
                    {
                        var myList = new List<Tool>();

                        while (reader.Read())
                        {
                            myList.Add(new Tool()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Model = Convert.ToString(reader["Model"]),
                                Manufacturer = Convert.ToString(reader["Manufacturer"]),
                                Kind = Convert.ToString(reader["Kind"]),
                                SerialNumber = Convert.ToString(reader["SerialNumber"]),
                                Cost = Convert.ToDecimal(reader["Cost"])
                            });
                        }

                        return myList;
                    }
                }
            }
        }
    }
}
