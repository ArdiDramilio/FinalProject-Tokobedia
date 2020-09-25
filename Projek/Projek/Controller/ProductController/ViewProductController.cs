using Projek.Handlers;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class ViewProductController
    {
        public static List<DetailProduct> FetchDataProduct()
        {
            return ViewProductHandler.FetchDataProduct();
        }
        public static List<DetailProduct> FetchDataProductForAdmin()
        {
            return ViewProductHandler.FetchDataProductForAdmin();
        }
    }
}