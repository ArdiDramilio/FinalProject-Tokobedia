using Projek.Factory;
using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryHeaderTransaction
    {
        private static TokobediaEntities db = new TokobediaEntities();
        public static HeaderTransaction SearchHeaderByPaymentTypeID(String ID)
        {
            return (from x in db.HeaderTransactions
                    where x.PaymentTypeID == ID
                    select x).FirstOrDefault();
        }
        public static HeaderTransaction SearchHeaderByID(String ID)
        {
            return (from x in db.HeaderTransactions
                    where x.TransactionID == ID
                    select x).FirstOrDefault();
        }
        public static void InsertHeader(int ID,String UserID,String PaymentTypeID)
        {
            db.HeaderTransactions.Add(FactoryHeaderTransaction.InitHeader(ID,UserID,PaymentTypeID));
            db.SaveChanges();
        }
        public static int CountHeeader()
        {
            return (from x in db.HeaderTransactions
                    where x.TransactionID != null
                    select x).Count();
        }
        public static List<HistoryTransaction> FetchHistory()
        {
            return (from x in db.HeaderTransactions
                    join y in db.DetailTransactions
                    on x.TransactionID equals y.TransactionID
                    join z in db.MsProducts
                    on y.ProductID equals z.ProductID
                    join a in db.MsPaymentTypes
                    on x.PaymentTypeID equals a.PaymentTypeID
                    select new HistoryTransaction
                    {
                        TransactionDate = x.TransactionDate,
                        PaymentTypeName = a.PaymentTypeName,
                        ProductName = z.ProductName,
                        ProductQuantity = y.Quantity,
                        SubTotal = y.Quantity * z.ProductPrice
                    }).ToList();
        }
        public static List<HistoryTransaction> FetchUserHistory(String UserID)
        {
            return (from x in db.HeaderTransactions
                    join y in db.DetailTransactions
                    on x.TransactionID equals y.TransactionID
                    join z in db.MsProducts
                    on y.ProductID equals z.ProductID
                    join a in db.MsPaymentTypes
                    on x.PaymentTypeID equals a.PaymentTypeID
                    where x.UserID == UserID
                    select new HistoryTransaction
                    {
                        TransactionDate = x.TransactionDate,
                        PaymentTypeName = a.PaymentTypeName,
                        ProductName = z.ProductName,
                        ProductQuantity = y.Quantity,
                        SubTotal= y.Quantity * z.ProductPrice
                    }).ToList();
        }
        public static List<HeaderTransaction> getallheader()
        {
            return (from x in db.HeaderTransactions
                    where x.TransactionID != null
                    select x).ToList();
        }
    }
}