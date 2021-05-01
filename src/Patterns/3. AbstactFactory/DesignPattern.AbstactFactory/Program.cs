using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace DesignPattern.AbstactFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnectionFactory sqlConnectionFactory = new SqlConnectionFactory();
            DbParameterFactory sqlParameterFactory = new SqlParameterFactory();
            DbFactory dbFactory = new SqlDbFactory();
            //SqlHelper sqlHelper = new SqlHelper(sqlConnectionFactory, sqlParameterFactory);
            SqlHelper sqlHelper = new SqlHelper(dbFactory);
            //string insertSql = "insert into [Users](Name,Age) values('ww',13);";
            //int res = sqlHelper.ExecuteNonQuery(insertSql);
            //Console.WriteLine($"插入{res}记录");
            int age = 12;
            string selectSql = $"select count(*) from [Users] where Age>@Age;";
            object count = sqlHelper.ExecuteScalar(selectSql,
                new DbParameter[] { sqlHelper.CreateDbParameter("@Age", age) });
            Console.WriteLine($"共有{count}记录");
        }
    }
}
