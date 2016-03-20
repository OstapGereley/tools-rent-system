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
    public class SqlCustomerRepository: ICustomerRepository
    {
        private readonly string _connectionString;

        private const string SelectAll = @"SELECT c.Id, c.Name, c.Surname, c.ContactPhone, c.Adress
                                           FROM tblCustomer c";

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

        public SqlCustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Customer> SelectAllCustomers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

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

        public void AddNewCustomer(Customer customer)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

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
    }


}
