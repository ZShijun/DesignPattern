using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.Singleton3
{
    public class MySqlHelper : SqlHelperBase<MySqlHelper>
    {
        private static readonly string _connectionString = @"...";

        private MySqlHelper() { }

        public override DbConnection CreateDbConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public override DbParameter CreateDbParameter(string parameterName, object value)
        {
            return new MySqlParameter(parameterName, value);
        }
    }
}
