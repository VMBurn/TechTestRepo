using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.Database
{
    public  class DatabaseManager
    {
        private  readonly string _connectionString;
		private static SqlConnection DbConnection;
		public DatabaseManager(string connectionString)
		{
			_connectionString = connectionString;
			DbConnection = CreateMsSqlConnection(_connectionString);			
		}

		public static SqlConnection CreateMsSqlConnection(string connectionstring)
		{
			SqlConnection connection = new SqlConnection(connectionstring);

			connection.Open();
			
			return connection;
		}	
	}
}
