using Projek.Handlers;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class ViewCartController
    {
        public static List<DetailCart> ViewCart(String UserID)
        {
            return ViewCartHandler.ViewCart(UserID);
        }
    }
}