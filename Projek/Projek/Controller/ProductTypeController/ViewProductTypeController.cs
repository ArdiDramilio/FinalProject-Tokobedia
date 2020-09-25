using Projek.Handlers;
using Projek.Helpers;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class ViewProductTypeController
    {
        public static List<DetailProductType> FetchFromDB()
        {
            return ViewProductTypeHandler.FetchFromDB();
        }
    }
}