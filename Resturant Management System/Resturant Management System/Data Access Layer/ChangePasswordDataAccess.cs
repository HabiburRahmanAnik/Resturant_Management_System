using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class ChangePasswordDataAccess
    {
        DataAccess dataAccess;
        public ChangePasswordDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public int ChangePassword(User user)
        {
            string query = "UPDATE Users SET Password='" + user.Password + "' WHERE Username='" + user.Username + "'";
            return this.dataAccess.ExecuteQuery(query);
        }
        public string GetPassword(string username)
        {
            string query = "SELECT * FROM Users WHERE Username='" + username + "'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(query);
            reader.Read();
            return reader["Password"].ToString();
        }
    }
}
