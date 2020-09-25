using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class DeleteProductController
    {
        public static Response DoDeleteProduct(String ID)
        {
            if (ID == "")
            {
                return new Response(false, "Product ID Cannot Be Empty");
            }
            Response response = DeleteProductHandler.DoDeleteProduct(ID);
            return response;
        }
    }
}