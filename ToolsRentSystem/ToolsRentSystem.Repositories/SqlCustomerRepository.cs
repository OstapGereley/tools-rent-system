using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsRentSystem.Entities;

namespace ToolsRentSystem.Repositories
{
    /// <summary>
    /// Provides functionality for tblCustomer
    /// </summary>
    public class SqlCustomerRepository: ICustomerRepository
    {
        private readonly string _connectionString;

        #region Sql requests

        /// <summary>
        /// Selects every record from tblCustomer
        /// </summary>
        private const string SelectAll = @"SELECT c.Id, c.Name, c.Surname, c.ContactPhone, c.Adress
                                           FROM tblCustomer c";
        /// <summary>
        /// Inserts record into tblCustomer
        /// </summary>
        private const string InsertCusomer = @"INSERT INTO [dbo].[tblCustomer]
                                                ([Name]
                                                ,[Surname]
                                                ,[ContactPhone]
                                                ,[Adress])
                                              VALUES
                                                (@name,
                                                 @surname,
                                                 @contactPhone,
                                                 @adress)";
        #endregion

        public SqlCustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Functions

        /// <summary>
        /// Selects every record from tblCustomer
        /// </summary>
        /// <returns>list of Customer</returns>
        public List<Customer> SelectAllCustomers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Review HP: It looks better if initialisation of command properties is inside the block of using,
                // not in constructor.
                using (var command = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = connection,
                    CommandText = SelectAll
                })
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var myList = new List<Customer>();

                        while (reader.Read())
                        {
                            // Rewiew HP: Maybe it is better to initialize customer outside the method Add.
                            myList.Add(new Customer()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = Convert.ToString(reader["Name"]),
                                Surname = Convert.ToString(reader["Surname"]),
                                ContactPhone = Convert.ToString(reader["ContactPhone"]),
                                Adress = Convert.ToString(reader["Adress"])
                            });
                        }

                        return myList;
                    }
                }
            }
        }

        /// <summary>
        /// Inserts new Customer into tblCustomer
        /// </summary>
        /// <param name="customer">new Customer entity</param>
        public void AddNewCustomer(Customer customer)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                // Rewiew HP: The same thing with initialization here. And everywhere.
                using (var command = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = connection,
                    CommandText = InsertCusomer
                })
                {
                    command.Parameters.Add(new SqlParameter("@name",SqlDbType.NVarChar) {Value = customer.Name});
                    command.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar) { Value = customer.Surname });
                    command.Parameters.Add(new SqlParameter("@contactPhone", SqlDbType.NVarChar) { Value = customer.ContactPhone });
                    command.Parameters.Add(new SqlParameter("@adress", SqlDbType.NVarChar) { Value = customer.Adress });

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }


}
