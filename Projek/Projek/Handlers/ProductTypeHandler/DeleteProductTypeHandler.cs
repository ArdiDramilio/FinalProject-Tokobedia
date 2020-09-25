using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class DeleteProductTypeHandler
    {
        public static Response DeleteProductType(String ID)
        {
            MsProduct product = Repository.RepositoryMsProduct.SearchProductByTypeID(ID);
            if (product != null)
            {
                return new Response(false, "Cannot Delete Product Type");
            }
            else
            {
                Repository.RepositoryMsProductType.DeleteType(ID);
                return new Response(true);
            }
        }
    }
}