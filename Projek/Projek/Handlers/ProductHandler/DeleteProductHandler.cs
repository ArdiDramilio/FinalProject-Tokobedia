using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class DeleteProductHandler
    {
        public static Response DoDeleteProduct(String ID)
        {
            DetailTransaction detail = Repository.RepositoryDetailTransaction.SearchDetailByID(ID);
            MsProduct product = Repository.RepositoryMsProduct.SearchProductByID(ID);
            if (detail != null)
            {
                return new Response(false, "Cannot Delete Product");
            }
            if (product == null)
            {
                return new Response(false, "Product Cannot Found");
            }
            Repository.RepositoryMsProduct.DeleteProduct(ID);
            return new Response(true);
        }
    }
}