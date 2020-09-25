using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class UpdateProfileController
    {
        public static Response DoUpdateProfile(String ID, String Nama, String Email, String Gender)
        {
            if (Nama == "")
            {
                return new Response(false, "Name Cannot Empty");
            }
            if (Email == "")
            {
                return new Response(false, "Email Cannot Empty");
            }
            if (Gender == "")
            {
                return new Response(false, "Gender Cannot Empty");
            }
            return UpdateProfileHandler.DoUpdateProfile(ID, Nama, Email, Gender);
        }
        public static Response DoChangePassword(String ID, String OldPassword, String NewPassword, String ConfirmPassword)
        {
            if (OldPassword == "")
            {
                return new Response(false, "Old Password Cannot Empty");
            }
            if (NewPassword == "")
            {
                return new Response(false, "New Password Cannot Empty");
            }
            if (ConfirmPassword == "")
            {
                return new Response(false, "Confirm Password Cannot Empty");
            }
            if (ConfirmPassword != NewPassword)
            {
                return new Response(false, "Confirm Password Must Be Same With New Password");
            }
            if (OldPassword == NewPassword)
            {
                return new Response(false, "New Password Cannot Be The Same With Old Password");
            }
            return UpdateProfileHandler.DoChangePassword(ID, OldPassword, NewPassword);
        }
    }
}