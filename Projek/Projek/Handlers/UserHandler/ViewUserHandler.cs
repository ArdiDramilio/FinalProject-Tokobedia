using Projek.Helpers;
using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class ViewUserHandler
    {
        public static List<DetailUser> FetchDetailUser()
        {
            return Repository.RepositoryMsUser.FetchDataUser();
        }
        public static Response ToggleStatus(String ID,String UserID)
        {
            MsUser user = Repository.RepositoryMsUser.GetUserByID(ID);
            if (user.UserID==UserID)
            {
                return new Response(false, "Current Admin Cannot Change Status and Role");
            }
            else
            {
                if (user.UserStatus == "Active")
                {
                    Repository.RepositoryMsUser.UpdateStatus(ID, "Blocked");
                }
                else
                {
                    Repository.RepositoryMsUser.UpdateStatus(ID, "Active");
                }
            }
            return new Response(true);
        }

        public static Response ChangeRole(String UserID,String Role,String UserIDLogin)
        {
            MsUser user = Repository.RepositoryMsUser.GetUserByID(UserID); 
            if (user.UserID == UserIDLogin)
            {
                return new Response(false, "Current Admin Cannot Change Status and Role");
            }
            else
            {
                Repository.RepositoryMsUser.UpdateRole(UserID, Role);
            }
            return new Response(true);
        }
    }
}