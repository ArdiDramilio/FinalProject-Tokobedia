using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryUser
    {
        public static MsUser InitUser(String Nama, String Email, String Password, String Gender, Int64 ID)
        {
            MsUser UserBaru = new MsUser();
            UserBaru.UserName = Nama;
            UserBaru.UserEmail = Email;
            UserBaru.UserPassword = Password;
            UserBaru.UserGender = Gender;
            UserBaru.RoleID = "RL2";
            UserBaru.UserID = "US" + ID;
            UserBaru.UserStatus = "Active";

            return UserBaru;
        }
    }
}