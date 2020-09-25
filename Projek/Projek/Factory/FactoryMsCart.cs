using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryMsCart
    {
        public static MsCart InitCart(String UserID,String ProductID, int qty)
        {
            MsCart newcart = new MsCart();
            newcart.UserID = UserID;
            newcart.ProductID = ProductID;
            newcart.Quantity = qty;
            return newcart;
        }
    }
}