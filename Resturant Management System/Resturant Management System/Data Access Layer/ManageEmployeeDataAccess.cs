using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Data_Access_Layer
{
    class ManageEmployeeDataAccess
    {
        DataAccess dataAccess;
        public ManageEmployeeDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<User> GetEmployee(string post)
        {
            string query = "SELECT * FROM Users WHERE Post='" + post + "'";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<User> users = new List<User>();
            while(reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Post = reader["Post"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.JoiningDate = reader["JoiningDate"].ToString();
                user.Salary = (double)reader["Salary"];
                user.BloodGroup = reader["BloodGroup"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.MaritalStatus = reader["MaritialStatus"].ToString();
                user.Address = reader["Address"].ToString();
                users.Add(user);
            }
            return users;
        }
        public int DeleteEmployee(int id)
        {
            string query = "DELETE FROM Users WHERE Id=" + id;
            return this.dataAccess.ExecuteQuery(query);
        }
        public int UpdateEmployee(User user)
        {
            string query = "UPDATE Users SET Name='" + user.Name + "',Username='" + user.Username + "', Email='" + user.Email + "',Post='" + user.Post + "',DateOfBirth='" + user.DateOfBirth + "',joiningDate='" + user.JoiningDate + "',[Salary]='" + user.Salary + "',BloodGroup='"+user.BloodGroup+"',Gender='"+user.Gender+ "',[MaritialStatus]='"+user.MaritalStatus+"',Address='"+user.Address+"' WHERE Id="+user.Id;
            return this.dataAccess.ExecuteQuery(query);
        }
        public List<User> SearchEmployee(string username)
        {
            string query= "SELECT * FROM Users WHERE Username LIKE '" + username + "%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<User> users = new List<User>();

            while(reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Post = reader["Post"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.JoiningDate = reader["JoiningDate"].ToString();
                user.Salary = (double)reader["Salary"];
                user.BloodGroup = reader["BloodGroup"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.MaritalStatus = reader["MaritialStatus"].ToString();
                user.Address = reader["Address"].ToString();
                users.Add(user);
            }
            return users;
        }
        public List<User> GetUser(string userName)
        {
            string query = "SELECT * FROM Users WHERE Username='" + userName + "'";
            SqlDataReader reader = this.dataAccess.GetData(query);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Post = reader["Post"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.JoiningDate = reader["JoiningDate"].ToString();
                user.Salary = (double)reader["Salary"];
                user.BloodGroup = reader["BloodGroup"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.MaritalStatus = reader["MaritialStatus"].ToString();
                user.Address = reader["Address"].ToString();
                users.Add(user);
            }
            return users;
        }
    }
}
