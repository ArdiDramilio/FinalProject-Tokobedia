using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class UpdateCartHandler
    {
        public static DetailCart GetCart(String UserID, String ProductID)
        {
            return Repository.RepositoryCart.GetDataCart(UserID, ProductID);
        }
        public static Response UpdateCart(String UserID,String ProductID,int Qty)
        {
            MsProduct product = Repository.RepositoryMsProduct.SearchProductByID(ProductID);
            int servedqty = Repository.RepositoryCart.GetServedQty(ProductID);
            MsCart cart = Repository.RepositoryCart.SearchCart(UserID, ProductID);
            if(Qty == cart.Quantity)
            {
                return new Response(true);
            }
            if (Qty > product.ProductStock)
            {
                return new Response(false, "Must Be Less than Or Equals to Product Stock");
            }
            if ((Qty + servedqty) > product.ProductStock)
            {
                return new Response(false, "Must Be Less than Or Equals to Product Stock");
            }
            RepositoryCart.UpdateCart(ProductID, UserID, Qty);
            return new Response(true);

        }
    }
}