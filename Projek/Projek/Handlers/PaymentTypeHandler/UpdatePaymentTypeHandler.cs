using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class UpdatePaymentTypeHandler
    {
        public static MsPaymentType GetPaymentType(String ID)
        {
            return Repository.RepositoryMsPaymentType.SearchPaymentByID(ID);
        }
        public static Response DoUpdatePaymentType(String ID, String Name)
        {
            MsPaymentType type = Repository.RepositoryMsPaymentType.SearchTypeByName(Name);
            if (type != null)
            {
                return new Response(false, "Payment Type Name Must be Unique");
            }
            Repository.RepositoryMsPaymentType.UpdatePaymentType(ID, Name);
            return new Response(true);
        }
    }
}