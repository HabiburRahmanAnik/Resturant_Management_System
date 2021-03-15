using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class ManageEmployeeService
    {
        ManageEmployeeDataAccess manageEmployeeDataAccess;
        public ManageEmployeeService()
        {
            this.manageEmployeeDataAccess = new ManageEmployeeDataAccess();
        }
        public List<User> GetAllEmployee(string post)
        {
            return this.manageEmployeeDataAccess.GetEmployee(post);
        }
        public int DeleteEmployee(int id)
        {
            return this.manageEmployeeDataAccess.DeleteEmployee(id);
        }
        public int UpdateEmployee(int id, string name, string userName, string email, string post, string dateOfBirth, string joinningDate, string salary, string bloodGroup, string gender, string maritialStatus, string address)
        {
            User user = new User()
            {
                Id = id,
                Name = name,
                Username = userName,
                Email = email,
                Post = post,
                DateOfBirth = dateOfBirth,
                JoiningDate = joinningDate,
                Salary = Convert.ToDouble(salary),
                BloodGroup = bloodGroup,
                Gender = gender,
                MaritalStatus = maritialStatus,
                Address = address
            };
            return this.manageEmployeeDataAccess.UpdateEmployee(user);
        }
        public List<User> SearchEMployee(string username)
        {
            return this.manageEmployeeDataAccess.SearchEmployee(username);
        }
        public List<User> GetUser(string username)
        {
            return this.manageEmployeeDataAccess.GetUser(username);
        }
    }
}
