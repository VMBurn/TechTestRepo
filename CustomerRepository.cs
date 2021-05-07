using AnyCompany.Database;
using AnyCompany.Database.Entities;
using AnyCompany.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AnyCompany
{
    public static class CustomerRepository
    {
        private static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerOrders;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public static Customer Load(int customerId)
        {

            Customer customer = new Customer();
            try
            {
                var connection = DatabaseManager.CreateMsSqlConnection(ConnectionString);

                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerId = " + customerId, connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customer.Name = reader["Name"].ToString();
                    customer.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                    customer.Country = reader["Country"].ToString();
                }

                connection.Close();
            }catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return customer;
        }

    }
}
