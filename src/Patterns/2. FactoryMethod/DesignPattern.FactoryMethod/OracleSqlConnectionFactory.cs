using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class OracleSqlConnectionFactory : DbConnectionFactory
    {
        private static readonly string _connectionString = @"...";

        public override DbConnection CreateDbConnection()
        {
            return null;
        }
    }
}
