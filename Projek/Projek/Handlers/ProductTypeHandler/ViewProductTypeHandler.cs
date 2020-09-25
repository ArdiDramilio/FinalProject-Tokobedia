using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class ViewProductTypeHandler
    {
        public static List<DetailProductType> FetchFromDB()
        {
            return Repository.RepositoryMsProductType.FetchData();
        }
    }
}