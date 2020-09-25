using Projek.Handlers.TransactionHandler;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller.TransactionController
{
    public class ReportingController
    {
        public static DataSet1 GetDataSet()
        {
            DataSet1 dataset = new DataSet1();
            var headertransaction = dataset.HeaderTransaction;
            var detailtransaction = dataset.DetailTransaction;

            List<HeaderTransaction> header = ReportingHandler.fetchheader();

            foreach (HeaderTransaction h in header)
            {
                var row = headertransaction.NewRow();
                row["TransactionID"] = h.TransactionID;
                row["TransactionDate"] = h.TransactionDate;
                row["UserID"] = h.UserID;
                row["PaymentTypeID"] = h.PaymentTypeID;
                headertransaction.Rows.Add(row);

                List<DetailTransaction> detail = ReportingHandler.fetchdetail(h.TransactionID);
                foreach (DetailTransaction d in detail)
                {
                    var rowdet = detailtransaction.NewRow();
                    rowdet["TransactionID"] = d.TransactionID;
                    rowdet["ProductID"] = d.ProductID;
                    rowdet["ProductName"] = d.MsProduct.ProductName;
                    rowdet["ProductPrice"] = d.MsProduct.ProductPrice;
                    rowdet["Quantity"] = d.Quantity;
                    detailtransaction.Rows.Add(rowdet);
                }
            }
            return dataset;
        }
    }
}