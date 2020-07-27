using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DesignPattern.AbstactFactory
{
    public class SqlHelper
    {
        //DbConnectionFactory _connectionFactory;
        //DbParameterFactory _parameterFactory;
        DbFactory _dbFactory;

        public SqlHelper(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        //public SqlHelper(DbConnectionFactory connectionFactory, DbParameterFactory parameterFactory)
        //{
        //    this._connectionFactory = connectionFactory;
        //    _parameterFactory = parameterFactory;
        //}

        /// <summary>
        /// 增删改操作，返回影响条数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql,params DbParameter[] parms)
        {
            using (DbConnection conn = _dbFactory.CreateDbConnection())
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    if (parms != null)
                    {
                        cmd.Parameters.AddRange(parms);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 查询操作，返回查询结果中的第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, params DbParameter[] parms)
        {
            using (DbConnection conn = _dbFactory.CreateDbConnection())
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    if (parms != null)
                    {
                        cmd.Parameters.AddRange(parms);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        public DbParameter CreateDbParameter(string parameterName, object value)
        {
            return _dbFactory.CreateDbParameter(parameterName, value);
        }
    }
}
