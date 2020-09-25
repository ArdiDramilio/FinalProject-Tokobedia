using Projek.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class DeleteProductCartController
    {
        public static void DoDeleteProductCart(String UserID,String ProductID)
        {
            DeleteProductCartHandler.DoDeleteProductCart(UserID, ProductID);
        }
    }
}