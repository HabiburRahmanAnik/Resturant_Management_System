using Resturant_Management_System.Data_Access_Layer;
using Resturant_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_Management_System.Resturant_Logic_Layer
{
    class LoginService
    {
        LoginDataAccess loginDataAccess;

        public LoginService()
        {
            this.loginDataAccess = new LoginDataAccess();
        }
        public bool Login(string username, string password)
        {
            User user = new User()
            {
                Username = username,
                Password = password
            };
            return this.loginDataAccess.Login(user);
        }
        public string GetPost(string username)
        {
            return loginDataAccess.GetPost(username);
        }
    }
}
