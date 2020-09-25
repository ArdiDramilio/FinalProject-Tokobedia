using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class UpdateProductController
    {
        public static Response UpdateItem(String ID, String Name, int Price, int Stock)
        {
            if (Name == "")
            {
                return new Response(false, "Product Name Cannot Be Empty");
            }
            if (Stock <= 0)
            {
                return new Response(false, "Product Stock Must Be 1 Or More");
            }
            if (Price <= 1000)
            {
                return new Response(false, "Product Price Must Be Above 1000 and Multiply of 1000");
            }
            if (Price % 1000 != 0)
            {
                return new Response(false, "Product Price Must Be Above 1000 and Multiply of 1000");
            }
            return UpdateProductHandler.UpdateItem(ID, Name, Price, Stock);
        }
        public static MsProduct GetProductByID(String ID)
        {
            return UpdateProductHandler.GetProductByID(ID);
        }
    }
}