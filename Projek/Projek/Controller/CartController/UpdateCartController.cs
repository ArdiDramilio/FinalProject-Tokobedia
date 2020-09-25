using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class UpdateCartController
    {
        public static DetailCart GetCart(String UserID,String ProductID)
        {
            return UpdateCartHandler.GetCart(UserID, ProductID);
        }
        public static Response UpdateCart(String UserID, string ProductID, int Qty)
        {
            if (Qty < 0)
            {
                return new Response(false, "Quantity Cannot Below Zero Number");
            }
            if (Qty == 0)
            {
                DeleteProductCartHandler.DoDeleteProductCart(UserID, ProductID);
                return new Response(true);
            }
            return UpdateCartHandler.UpdateCart(UserID, ProductID, Qty);
        }
    }
}