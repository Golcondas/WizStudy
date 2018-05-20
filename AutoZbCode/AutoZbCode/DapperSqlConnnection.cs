//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace AutoZbCode
{
    public static class DapperSqlConnnection
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;

        //public static SqlConnection OpenSqlServerConnection()
        //{
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    connection.Open();
        //    return connection;
        //}

        //获取MySql的连接数据库对象。MySqlConnection
        public static MySqlConnection OpenMysqlConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
