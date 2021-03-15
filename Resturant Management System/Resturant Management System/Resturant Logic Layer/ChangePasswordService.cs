using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class ChangePasswordService
    {
        ChangePasswordDataAccess changePasswordDataAccess;
        public ChangePasswordService()
        {
            this.changePasswordDataAccess = new ChangePasswordDataAccess();
        }
        public int ChangePassword(string username,string password)
        {
            User user = new User()
            {
                Username = username,
                Password = password
            };
            return this.changePasswordDataAccess.ChangePassword(user);
        }
        public string GetPassword(string userName)
        {
            return this.changePasswordDataAccess.GetPassword(userName);
        }
    }
}
