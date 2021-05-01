using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class MySqlConnectionFactory : DbConnectionFactory
    {
        private static readonly string _connectionString = @"...";

        public override DbConnection CreateDbConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
