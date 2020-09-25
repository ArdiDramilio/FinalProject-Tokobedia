using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class AddToCartController
    {
        
        public static MsProduct FetchDataByID(String ID)
        {
            return AddToCartHandler.FetchDataByID(ID);
        }
        public static MsProductType GetProductType(String ID)
        {
            return AddToCartHandler.GetProductType(ID);
        }
        public static Response DoAddCart(String UserID, String ProductID,int qty)
        {
            if (qty <= 0)
            {
                return new Response(false, "Quantity Must Be More Than 0");
            }
            Response response = AddToCartHandler.DoAddCart(UserID, ProductID, qty);
            return response;
        }
    }
}