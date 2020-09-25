using Projek.Handlers;
using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class HomeController
    {
        public static MsUser FetchDataForHome(String ID)
        {
            MsUser user = HomeHandler.FetchDataForHome(ID);
            return user;
        }
        public static List<DetailProduct> FetchDataRandom()
        {
            return HomeHandler.FetchDataRandom();
        }
    }
}   