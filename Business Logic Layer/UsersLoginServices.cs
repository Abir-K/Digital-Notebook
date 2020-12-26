using Digital_NoteBooK.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_NoteBooK.Business_Logic_Layer
{
    class UsersLoginServices
    {
        UserDataAccess userDataAccess;
        public UsersLoginServices()
        {
            userDataAccess = new UserDataAccess();
        }

        public bool UsersLogin(string username, string password)
        {
            return userDataAccess.UsersLogin(username, password);
        }

    }
}
