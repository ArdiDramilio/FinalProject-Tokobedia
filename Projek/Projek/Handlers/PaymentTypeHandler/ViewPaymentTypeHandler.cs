using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class ViewPaymentTypeHandler
    {
        public static List<DetailPaymentType> FetchDataPaymentType()
        {
            return Repository.RepositoryMsPaymentType.FetchDataPaymentType();
        }
    }
}