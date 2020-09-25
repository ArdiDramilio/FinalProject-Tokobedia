using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class DeletePaymentTypeController
    {
        public static Response DoDeletePayment(String ID)
        {
            return DeletePaymentTypeHandler.DoDeletePayment(ID);
        }
    }
}