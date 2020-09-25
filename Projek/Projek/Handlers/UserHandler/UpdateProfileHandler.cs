using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class UpdateProfileHandler
    {
        public static Response DoUpdateProfile(String ID, String Nama, String Email, String Gender)
        {
            MsUser user = Repository.RepositoryMsUser.GetUserByEmail(Email);
            if (user != null)
            {
                return new Response(false, "Email Must Be Unique");
            }
            Repository.RepositoryMsUser.UpdateData(ID, Nama, Email, Gender);
            return new Response(true);
        }
        public static Response DoChangePassword(String ID, String OldPassword, String NewPassword)
        {
            MsUser user = Repository.RepositoryMsUser.GetUserByID(ID);
            if (OldPassword != user.UserPassword)
            {
                return new Response(false, "Old Password Must Be Same With Current Password");
            }
            Repository.RepositoryMsUser.UpdatePassword(ID, NewPassword);
            return new Response(true);
        }
    }
}