using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DesignPattern.AbstactFactory
{
    public class SqlDbFactory : DbFactory
    {
        private static readonly string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true;Initial Catalog=FactoryDb";

        public override DbConnection CreateDbConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public override DbParameter CreateDbParameter(string parameterName, object value)
        {
            return new SqlParameter(parameterName, value);
        }
    }
}
