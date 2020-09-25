using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class DeletePaymentTypeHandler
    {
        public static Response DoDeletePayment(String ID)
        {
            HeaderTransaction header= Repository.RepositoryHeaderTransaction.SearchHeaderByPaymentTypeID(ID);
            if (header != null)
            {
                return new Response(false, "Cannot Delete Payment Type");
            }
            Repository.RepositoryMsPaymentType.DeletePayment(ID);
            return new Response(true);
        }
   }
}