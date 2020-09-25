using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class AddToCartHandler
    {
       
        public static MsProduct FetchDataByID(String ID)
        {
            return Repository.RepositoryMsProduct.SearchProductByID(ID);
        }
        public static MsProductType GetProductType(String ID)
        {
            return Repository.RepositoryMsProductType.SearchTypeByID(ID);
        }
        public static Response DoAddCart(String UserID,String ProductID, int qty)
        {
            MsProduct product = Repository.RepositoryMsProduct.SearchProductByID(ProductID);
            int servedqty = Repository.RepositoryCart.GetServedQty(ProductID);
            MsCart cart = Repository.RepositoryCart.SearchCart(UserID,ProductID);

            if (qty > product.ProductStock)
            {
                return new Response(false, "Must Be Less than Or Equals to Product Stock");
            }
            if ((qty + servedqty) > product.ProductStock)
            {
                return new Response(false, "Must Be Less than Or Equals to Product Stock");
            }

            if (cart == null)
            {
                Repository.RepositoryCart.InsertCart(UserID, ProductID, qty);
            }
            else
            {
                Repository.RepositoryCart.AppendCart(UserID, ProductID, qty);
            }

            return new Response(true);
        }
    }
}