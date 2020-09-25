using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class HistoryTransactionHandler
    {
        public static List<HistoryTransaction> GetAllHistory()
        {
            return Repository.RepositoryHeaderTransaction.FetchHistory();
        }
        public static List<HistoryTransaction> GetUserHistory(String UserID)
        {
            return Repository.RepositoryHeaderTransaction.FetchUserHistory(UserID);
        }
    }
}