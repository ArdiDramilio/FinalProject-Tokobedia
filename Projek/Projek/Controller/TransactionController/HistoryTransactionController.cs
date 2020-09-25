using Projek.Handlers;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class HistoryTransactionController
    {
        public static List<HistoryTransaction> GetAllHistory()
        {
            return HistoryTransactionHandler.GetAllHistory();
        }
        public static List<HistoryTransaction> GetUserHistory(String UserID)
        {
            return HistoryTransactionHandler.GetUserHistory(UserID);
        }
    }
}