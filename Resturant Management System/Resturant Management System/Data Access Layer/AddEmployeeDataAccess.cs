using Resturant_Management_System.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturant_Management_System.Entities;

namespace Resturant_Management_System.Data_Access_Layer
{
    class AddEmployeeDataAccess
    {
        DataAccess dataAccess;
        public AddEmployeeDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public int InsertEmployee(User user)
        {
            string query = "INSERT INTO Users (Name,Username,Password,Email,Post,DateOfBirth,JoiningDate,Salary,BloodGroup,Gender,MaritialStatus,Address) VALUES('"+user.Name+"','"+user.Username+"','"+user.Password+"','"+user.Email+"','"+user.Post+"','"+user.DateOfBirth+"','"+user.JoiningDate+"','"+user.Salary+"','"+user.BloodGroup+"','"+user.Gender+"','"+user.MaritalStatus+"','"+user.Address+"')";
            return this.dataAccess.ExecuteQuery(query);
        }               
    }
}
