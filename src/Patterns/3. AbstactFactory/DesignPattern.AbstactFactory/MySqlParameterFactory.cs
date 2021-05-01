using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.AbstactFactory
{
    public class MySqlParameterFactory : DbParameterFactory
    {
        public override DbParameter CreateDbParameter(string parameterName, object value)
        {
            return new MySqlParameter(parameterName, value);
        }
    }
}
