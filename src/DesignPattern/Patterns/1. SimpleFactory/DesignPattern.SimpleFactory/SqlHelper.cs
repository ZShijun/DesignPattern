using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.SqlClient;

namespace DesignPattern.SimpleFactory
{
    public class SqlHelper
    {
        /// <summary>
        /// 增删改操作，返回影响条数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            using (DbConnection conn = DbConnectionFactory.CreateDbConnection())
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
            using (DbConnection conn = DbConnectionFactory.CreateDbConnection())
            {
                using (DbCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
