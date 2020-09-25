using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class UpdatePaymentTypeController
    {
        public static MsPaymentType GetPaymentType(String ID)
        {
            return UpdatePaymentTypeHandler.GetPaymentType(ID);
        }
        public static Response DoUpdatePaymentType(String ID, String Name)
        {
            if (Name == "")
            {
                return new Response(false, "Payment Type Name Cannot Be Empty");
            }
            if (Name.Length < 3)
            {
                return new Response(false, "Payment Type Name Consists of 3 Characters or More");
            }
            Response response = UpdatePaymentTypeHandler.DoUpdatePaymentType(ID, Name);
            return response;
        }
    }
}