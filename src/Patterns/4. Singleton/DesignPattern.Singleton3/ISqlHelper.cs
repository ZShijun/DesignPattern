using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.Singleton3
{
    public interface ISqlHelper
    {
        int ExecuteNonQuery(string sql);
        object ExecuteScalar(string sql);
        DbConnection CreateDbConnection();
        DbParameter CreateDbParameter(string parameterName, object value);
    }
}
