using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class InsertPaymentTypeHandler
    {
        public static int CountData()
        {
            int ID = Repository.RepositoryMsPaymentType.CountData();
            return ID;
        }
        public static Response DoInsertPaymentType(Int64 ID, String Name)
        {
            MsPaymentType type = Repository.RepositoryMsPaymentType.SearchTypeByName(Name);
            if (type != null)
            {
                return new Response(false, "Payment Type Name Must be Unique");
            }
            Repository.RepositoryMsPaymentType.InsertPaymentType(ID, Name);
            return new Response(true);
        }
    }
}