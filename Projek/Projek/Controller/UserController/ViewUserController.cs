using Projek.Handlers;
using Projek.Helpers;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class ViewUserController
    {
        public static List<DetailUser> FetchDetailUser()
        {
            return ViewUserHandler.FetchDetailUser();
        }
        public static Response ToggleStatus(String ID,String UserID)
        {
            return ViewUserHandler.ToggleStatus(ID,UserID);
        }
        public static Response ChangeRole(String UserID,String Role,String UserIDLogin)
        {
            if (Role == "")
            {
                return new Response(false, "Role Cannot Empty");
            }
            else if (Role == "Admin")
            {
                return ViewUserHandler.ChangeRole(UserID, "RL1",UserIDLogin);
            }
            else if (Role == "Member")
            {
                return ViewUserHandler.ChangeRole(UserID, "RL2",UserIDLogin);
            }else
            {
                return new Response(false, "Role Not Found");
            }
        }
    }
}