using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class InsertPaymentTypeController
    {
        public static int CountData()
        {
            int ID = InsertPaymentTypeHandler.CountData();
            return ID;
        }
        public static Response DoInsertPaymentType(Int64 ID, String Name)
        {
            if (Name == "")
            {
                return new Response(false, "Payment Type Name Cannot Be Empty");
            }
            if (Name.Length < 3)
            {
                return new Response(false, "Payment Type Name Consists of 3 Characters or More");
            }
            Response response = InsertPaymentTypeHandler.DoInsertPaymentType(ID, Name);
            return response;
        }
    }
}