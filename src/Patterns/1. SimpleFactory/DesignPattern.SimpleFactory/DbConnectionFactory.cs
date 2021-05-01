using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    public static class DbConnectionFactory
    {

        private static readonly string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true;Initial Catalog=FactoryDb";

        private static readonly string _dbType = "Sqlserver";

        public static DbConnection CreateDbConnection()
        {
            if (_dbType == "Sqlserver")
            {
                return new SqlConnection(_connectionString);
            }
            else if (_dbType == "MySql")
            {
                return new MySqlConnection(_connectionString);
            }
            else
            {
                return null;
            }
        }
    }
}
