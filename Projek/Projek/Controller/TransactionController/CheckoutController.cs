using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class CheckoutController
    {
        public static void DoCheckout(String UserID,String PaymentID)
        {
           CheckoutHandler.DoCheckout(UserID,PaymentID);
        }
    }
}