﻿using System;
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
    /// Provides functionality for tblRentOrder
    /// </summary>
    public class SqlRentOrderRepository:IRentOrderRepository
    {

        private readonly string _connectionString;

        #region Sql requests

        /// <summary>
        /// Creates new rent record
        /// </summary>
        private const string CreateRentText = @"INSERT INTO [dbo].[tblRentOrder]
                                                   ([IdTool]
                                                   ,[IdCustomer]
                                                   ,[IdOperator]
                                                   ,[DateStart]
                                                   ,[DateEnd]
                                                   ,[RentStatus]
                                                   ,[RentPrice])
                                             VALUES
                                                   (@idTool,
                                                    @IdCustomer,
                                                    @IdOperator,
                                                    @DateStart,
                                                    @DateEnd,
                                                    @RentStatus, 
                                                    @RentPrice)";

        /// <summary>
        /// Selects all required information about orders  
        /// </summary>
        private const string SelectAllOrders = @"SELECT r.Id,t.Model,t.Manufacturer, t.Kind, r.DateStart, r.DateEnd, 
                                                        r.RentStatus, r.RentPrice, c.Name, c.Surname, c.ContactPhone, 
                                                        c.Adress, o.Name,o.Surname
                                                FROM tblTool t
                                                INNER JOIN tblRentOrder r	
                                                on t.Id = r.IdTool
                                                INNER JOIN tblCustomer c
                                                on c.Id = r.IdCustomer
                                                INNER JOIN tblOperator o
                                                on o.Id = r.IdOperator	";

        /// <summary>
        /// Closes rent order, by setting status = 2
        /// </summary>
        private const string CloseRentOrder = @"UPDATE [dbo].[tblRentOrder]
                                                SET [RentStatus] = 2      
                                                WHERE Id = @id";

        #endregion

        public SqlRentOrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Functions

        /// <summary>
        /// Creates new rentOrder record
        /// </summary>
        /// <param name="rentOrder">new RentOrder entity</param>
        public void CreateRent(RentOrder rentOrder)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = connection,
                    CommandText = CreateRentText
                })
                {
                    command.Parameters.Add(new SqlParameter("@idTool", SqlDbType.Int) { Value = rentOrder.IdTool });
                    command.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int) { Value = rentOrder.IdCustomer });
                    command.Parameters.Add(new SqlParameter("@IdOperator", SqlDbType.Int) { Value = rentOrder.IdOperator });
                    command.Parameters.Add(new SqlParameter("@DateStart", SqlDbType.DateTime) { Value = rentOrder.DateStart });
                    command.Parameters.Add(new SqlParameter("@DateEnd", SqlDbType.DateTime) { Value = rentOrder.DateEnd });
                    command.Parameters.Add(new SqlParameter("@RentStatus", SqlDbType.Int) { Value = rentOrder.RentStatus });
                    command.Parameters.Add(new SqlParameter("@RentPrice", SqlDbType.Decimal) { Value = rentOrder.RentPrice });

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Closes rent 
        /// </summary>
        /// <param name="id">Id of RentOrder record to close</param>
        public void CloseRent(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = connection,
                    CommandText = CloseRentOrder
                })
                {
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) {Value = id});

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Selects all records from multiple tables
        /// </summary>
        /// <returns>List of rentOrders</returns>
        public List<RentOrder> SelectAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = SelectAllOrders
                })
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var myList = new List<RentOrder>();

                        while (reader.Read())
                        {
                            // Review HP: this initialisation inside the Add method 
                            // should be done separately for all components.
                            myList.Add(new RentOrder()
                            {
                                RTool = new Tool()
                                {
                                    Model = Convert.ToString(reader["Model"]),
                                    Manufacturer = Convert.ToString(reader["Manufacturer"]),
                                    Kind = Convert.ToString(reader["Kind"])
                                },
                                RCustomer = new Customer()
                                {
                                    Name = Convert.ToString(reader["Name"]),
                                    Surname = Convert.ToString(reader["Surname"]),
                                    Adress = Convert.ToString(reader["Adress"]),
                                    ContactPhone = Convert.ToString(reader["ContactPhone"])
                                },
                                ROperator = new Operator()
                                {
                                    Name = Convert.ToString(reader["Name"]),
                                    Surname = Convert.ToString(reader["Surname"])
                                },
                                Id = Convert.ToInt32(reader["Id"]),
                                DateStart = Convert.ToDateTime(reader["DateStart"]),
                                DateEnd = Convert.ToDateTime(reader["DateEnd"]),
                                RentStatus = Convert.ToInt32(reader["RentStatus"]),
                                RentPrice = Convert.ToDecimal(reader["RentPrice"])
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
