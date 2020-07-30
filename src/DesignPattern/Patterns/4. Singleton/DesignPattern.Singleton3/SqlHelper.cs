using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DesignPattern.Singleton3
{
    public class SqlHelper : SqlHelperBase<SqlHelper>
    {
        private static readonly string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true;Initial Catalog=FactoryDb";

        private SqlHelper() { }

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
