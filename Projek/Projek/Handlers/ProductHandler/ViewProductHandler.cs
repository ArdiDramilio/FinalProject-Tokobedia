using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class ViewProductHandler
    {
        public static List<DetailProduct> FetchDataProduct()
        {
            return Repository.RepositoryMsProduct.FetchDataProduct();
        }
        public static List<DetailProduct> FetchDataProductForAdmin()
        {
            return Repository.RepositoryMsProduct.FetchDataProductForAdmin();
        }
    }
}