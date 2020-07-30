using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.Singleton3
{
    public abstract class SqlHelperBase<TSingleton>: ISqlHelper
        where TSingleton : class
    {
        private static readonly Lazy<TSingleton> _instance
            = new Lazy<TSingleton>(() => (TSingleton)Activator.CreateInstance(typeof(TSingleton), true));

        public static TSingleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        /// <summary>
        /// 增删改操作，返回影响条数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            using (DbConnection conn = CreateDbConnection())
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 查询操作，返回查询结果中的第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            using (DbConnection conn = CreateDbConnection())
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
            }
        }

        public abstract DbConnection CreateDbConnection();

        public abstract DbParameter CreateDbParameter(string parameterName, object value);
    }
}
