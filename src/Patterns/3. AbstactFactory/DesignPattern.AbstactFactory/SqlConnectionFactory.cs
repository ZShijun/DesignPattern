using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DesignPattern.AbstactFactory
{
    public class SqlConnectionFactory : DbConnectionFactory
    {
        private static readonly string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true;Initial Catalog=FactoryDb";

        public override DbConnection CreateDbConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
