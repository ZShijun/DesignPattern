using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public abstract class DbConnectionFactory
    {
        public abstract DbConnection CreateDbConnection();
    }
}
