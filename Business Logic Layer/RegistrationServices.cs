using Digital_NoteBooK.Data_Access_Layer;
using Digital_NoteBooK.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_NoteBooK.Business_Logic_Layer
{
    class RegistrationServices
    {
        RegistrationAccess registrationDataAccess;
        public RegistrationServices()
        {
            registrationDataAccess = new RegistrationAccess();
        }

        public int AddnewUser(string userName,string userPassword,string userEmail,string userDateOfBirth,string userAddress)
        {
            Users users = new Users();
            users.UserName = userName;
            users.UserPassword = userPassword;
            users.UserEmail = userEmail;
            users.UserDateOfBirth = userDateOfBirth;
            users.UserAddress = userAddress;
           return  this.registrationDataAccess.UserRegitration(users);
        }
    }
}
