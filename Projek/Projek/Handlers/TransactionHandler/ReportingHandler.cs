using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers.TransactionHandler
{
    public class ReportingHandler
    {
        public static List<HeaderTransaction> fetchheader()
        {
            return Repository.RepositoryHeaderTransaction.getallheader();
        }
        public static List<DetailTransaction> fetchdetail(String TransactionID)
        {
            return Repository.RepositoryDetailTransaction.getdetail(TransactionID);
        }
    }
}