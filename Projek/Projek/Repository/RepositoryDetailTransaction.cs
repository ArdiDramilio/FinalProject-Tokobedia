using Projek.Factory;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryDetailTransaction
    {
        private static TokobediaEntities db = new TokobediaEntities();
        public static DetailTransaction SearchDetailByID(String ID)
        {
            return (from y in db.DetailTransactions
                    where y.ProductID == ID
                    select y).FirstOrDefault();
        }
        public static void insertDetail(String TransactionID,String ProductID,int Quantity)
        {
            db.DetailTransactions.Add(FactoryDetailTransaction.InitDetail(TransactionID, ProductID, Quantity));
            db.SaveChanges();
        }
        public static List<DetailTransaction> getdetail(String TransactionID)
        {
            return (from x in db.DetailTransactions
                    where x.TransactionID == TransactionID
                    select x).ToList();
        }
    }
}