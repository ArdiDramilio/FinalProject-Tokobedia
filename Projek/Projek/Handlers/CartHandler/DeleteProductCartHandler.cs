using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class DeleteProductCartHandler
    {
        public static void DoDeleteProductCart(String UserID, String ProductID)
        {
            Repository.RepositoryCart.DeleteProduct(UserID, ProductID);
        }
    }
}