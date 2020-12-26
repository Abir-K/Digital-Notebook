using Digital_NoteBooK.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_NoteBooK.Data_Access_Layer
{
    class RegistrationAccess
    {
        DataAccess dataAccess;

        public RegistrationAccess()
        {
            dataAccess = new DataAccess();
        }

        public int UserRegitration(Users user)
        {
            string sql = "Insert Into UsersRegistration(Name,Email,DateOfBirth,Address,Password) Values('" + user.UserName + "','" + user.UserEmail + "','" + user.UserDateOfBirth + "','" + user.UserAddress+ "','"+user.UserPassword+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

    }
}
