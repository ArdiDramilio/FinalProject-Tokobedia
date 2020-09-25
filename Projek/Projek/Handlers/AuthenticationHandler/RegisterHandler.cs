using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class RegisterHandler
    {
        public static int CountData()
        {
            int ID = RepositoryMsUser.CountData();
            return ID;
        }
        public static Response DoRegister(String Nama, String Email, String Password, String Gender, Int64 ID)
        {
            MsUser user = Repository.RepositoryMsUser.GetUserByEmail(Email);
            if (user != null)
            {
                return new Response(false, "Email Must be Unique");
            }
            Repository.RepositoryMsUser.RegisData(Nama, Email, Password, Gender, ID);
            return new Response(true);
        }
    }
}