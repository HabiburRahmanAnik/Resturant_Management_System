using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class DataAccess:IDisposable
    {
        SqlConnection connection;
        SqlCommand command;

        public DataAccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            this.connection.Open();
        }
        public SqlDataReader GetData(string query)
        {
            this.command = new SqlCommand(query, this.connection);
            SqlDataReader reader = this.command.ExecuteReader();
            return reader;
        } 

        public int ExecuteQuery(string query)
        {
            this.command = new SqlCommand(query, this.connection);
            int result = this.command.ExecuteNonQuery();
            return result;
        }

        public void Dispose()
        {
            this.connection.Close();
        }

    }
}
