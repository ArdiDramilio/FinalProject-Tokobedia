using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryDetailTransaction
    {
        public static DetailTransaction InitDetail(String TransactionID,String ProductID,int Quantity)
        {
            DetailTransaction detail = new DetailTransaction();
            detail.TransactionID = TransactionID;
            detail.ProductID = ProductID;
            detail.Quantity = Quantity;
            return detail;
        }
        
    }
}