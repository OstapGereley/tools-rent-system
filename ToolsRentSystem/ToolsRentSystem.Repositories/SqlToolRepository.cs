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

        #region Sql requests
        
        /// <summary>
        /// Selects all from tblTool
        /// </summary>
        private const string SelectAllTool = @"SELECT t.Id, t.Model, t.Manufacturer, t.Kind, t.SerialNumber, t.Cost
                                               FROM tblTool t";
        /// <summary>
        /// Selects only avalible tools for renting
        /// </summary>
        // Review HP: vll spaces are missed in SELECT section.
        private const string SelectAvalibleTool =
                                             @"WITH CTE AS
                                                    (SELECT t.Id, 
                                                            t.Model, 
                                                            t.Manufacturer, 
                                                            t.Kind,
			                                                t.SerialNumber,
			                                                t.Cost, 
			                                                r.RentStatus,
                                                            RowNum = ROW_NUMBER() OVER(PARTITION BY t.Id ORDER BY r.Id DESC) 
                                                    FROM tblTool t
		                                            LEFT OUTER JOIN tblRentOrder r
		                                            ON t.Id = r.IdTool)
                                            SELECT  Id,Model,Manufacturer,Kind,SerialNumber,Cost
                                            FROM    CTE
                                            WHERE   RowNum = 1 AND (RentStatus = 2 or RentStatus is NULL);";

        #endregion

        public SqlToolRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Functions

        /// <summary>
        /// Selects records according to selection param
        /// </summary>
        /// <param name="selection">Avalible selections "All", "Avalible"</param>
        /// <returns>list of tool entity</returns>
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
		
		    // Review HP: New line is needless at the beginning of block.
		    // Review HP: Statements after if clouse must be in block.
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
        #endregion
    }
}
