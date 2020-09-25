using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryHeaderTransaction
    {
        public static HeaderTransaction InitHeader(int ID,String UserID,String PaymentTypeID)
        {
            HeaderTransaction header = new HeaderTransaction();
            header.TransactionID = "TR" + ID;
            header.UserID = UserID;
            header.PaymentTypeID = PaymentTypeID;
            header.TransactionDate = DateTime.Now;
            return header;
        }
    }
}