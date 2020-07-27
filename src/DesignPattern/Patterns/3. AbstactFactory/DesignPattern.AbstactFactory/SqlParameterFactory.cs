using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace DesignPattern.AbstactFactory
{
    public class SqlParameterFactory : DbParameterFactory
    {
        public override DbParameter CreateDbParameter(string parameterName, object value)
        {
            return new SqlParameter(parameterName, value);
        }
    }
}
