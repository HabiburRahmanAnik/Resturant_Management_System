using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class AddEmployeeService
    {
        AddEmployeeDataAccess addEmployeeDataAccess;
        public AddEmployeeService()
        {
            this.addEmployeeDataAccess = new AddEmployeeDataAccess();
        }
        public int InsertEmployee(string name,string userName,string password,string email,string post,string dateOfBirth,string joinningDate,string salary,string bloodGroup,string gender,string maritialStatus,string address)
        {
            User user = new User()
            {
                Name = name,
                Username = userName,
                Password = password,
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
            return this.addEmployeeDataAccess.InsertEmployee(user);
        }
    }
}
