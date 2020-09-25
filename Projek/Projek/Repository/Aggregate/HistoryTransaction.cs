using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository.Aggregate
{
    public class HistoryTransaction
    {
        public DateTime TransactionDate { get; internal set; }
        public string PaymentTypeName { get; internal set; }
        public string ProductName { get; internal set; }
        public int ProductQuantity { get; internal set; }
        public int SubTotal { get; internal set; }
    }
}