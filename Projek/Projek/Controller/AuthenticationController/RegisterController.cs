using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class RegisterController
    {
        public static Response DoRegister(String Nama, String Email, String Password, String ConfirmPassword , String Gender, Int64 ID)
        {
            if (Email == "")
            {
                return new Response(false, "Email Cannot Be Empty");
            }
            if (Nama == "")
            {
                return new Response(false, "Name Cannot Be Empty");
            }
            if (Password == "")
            {
                return new Response(false, "Password Cannot Be Empty");
            }
            if (ConfirmPassword != Password)
            {
                return new Response(false, "Confirm Password Must Be Same With Password");
            }
            if (Gender == "")
            {
                return new Response(false, "Gender Cannot Be Empty");
            }
            Response response = RegisterHandler.DoRegister(Nama, Email, Password, Gender, ID);
            return response;
        }
        public static int CountData()
        {
            int ID = RegisterHandler.CountData();
            return ID;
        }
    }
}