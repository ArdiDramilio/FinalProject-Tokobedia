using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class LoginHandler
    {
        public static Response DoLogin(String email, String pass)
        {
            MsUser User = RepositoryMsUser.GetUser(email, pass);
            if (User == null)
            {
                return new Response(false, "Wrong email or password");
            }
            else if (User.UserStatus=="Blocked")
            {
                return new Response(false, "User Blocked");
            }
            return new Response(true);
        }
        public static MsUser AddSession(String email)
        {
            MsUser User = RepositoryMsUser.GetUserByEmail(email);
            return User;
        }
    }
}