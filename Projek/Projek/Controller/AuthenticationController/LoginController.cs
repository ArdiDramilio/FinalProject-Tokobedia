using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class LoginController
    {
        public static Response DoLogin(String email, String pass)
        {
            if (email == "")
            {
                return new Response(false, "Email Cannot Be Empty");
            }
            if (pass == "")
            {
                return new Response(false, "Password Cannot Be Empty");
            }
            Response response = LoginHandler.DoLogin(email, pass);
            return response;
        }
        public static MsUser AddSession(String email)
        {
            MsUser User = LoginHandler.AddSession(email);
            return User;
        }
    }
}