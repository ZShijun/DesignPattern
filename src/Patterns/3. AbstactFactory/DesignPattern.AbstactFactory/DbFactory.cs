using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.AbstactFactory
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateDbConnection();
        public abstract DbParameter CreateDbParameter(string parameterName, object value);
    }
}
