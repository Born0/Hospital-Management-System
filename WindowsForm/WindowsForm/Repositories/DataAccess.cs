using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Repositories
{
    class DataAccess
    {
        static SqlConnection connection;
        static SqlCommand command;

        public DataAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HMS"].ConnectionString);
            connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand(sql,connection);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            connection.Close();
            connection.Open();
            command = new SqlCommand(sql,connection);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            connection.Close();
        }
        //~DataAccess()
        //{
        //    connection.Close();
        //}
    }
}
