using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class UpdateProductHandler
    {
        public static Response UpdateItem(String ID, String Name, int Price, int Stock)
        {
            Repository.RepositoryMsProduct.UpdateProduct(ID, Name, Price, Stock);
            return new Response(true);
        }
        public static MsProduct GetProductByID(String ID)
        {
            return Repository.RepositoryMsProduct.SearchProductByID(ID);
        }
    }
}