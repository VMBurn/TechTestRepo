using AnyCompany.Database;
using AnyCompany.Repositories.Interfaces;
using System;
using System.Data.SqlClient;

namespace AnyCompany
{
    internal class OrderRepository : IOrderRepository
    {
        private static string ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = CustomerOrders; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        public void Save(Order order) 
        {
            try
            {
                var connection = DatabaseManager.CreateMsSqlConnection(ConnectionString);
                
                string strConn1 = "INSERT INTO [dbo].[Order] VALUES (@OrderId, @CustomerId, @Amount, @VAT)";
                
                string strConn2 = "IF NOT EXISTS (SELECT * FROM [dbo].[Order] WHERE  @OrderId = " + order.OrderId 
                                                                          + " AND @CustomerId = " + order.CustomerId 
                                                                          + " AND @Amount = " + order.Amount 
                                                                          + " AND @VAT = " + order.VAT + ") " 
                                                                          + "BEGIN INSERT INTO [dbo].[Order] "
                                                                          + "VALUES (@OrderId, @CustomerId, @Amount, @VAT) END";

                SqlCommand command = new SqlCommand(strConn2, connection);
                command.Parameters.AddWithValue("@OrderId", order.OrderId);
                command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                command.Parameters.AddWithValue("@Amount", order.Amount);
                command.Parameters.AddWithValue("@VAT", order.VAT);

                command.ExecuteNonQuery();

                connection.Close();

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
