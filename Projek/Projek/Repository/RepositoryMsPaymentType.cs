using Projek.Factory;
using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryMsPaymentType
    {
        private static TokobediaEntities db = new TokobediaEntities();

        public static List<DetailPaymentType> FetchDataPaymentType()
        {
            return (from x in db.MsPaymentTypes
                    select new DetailPaymentType
                    {
                        PaymentTypeID = x.PaymentTypeID,
                        PaymentTypeName = x.PaymentTypeName
                    }).ToList();
        }

        public static MsPaymentType SearchTypeByName(String Name)
        {
            return (from b in db.MsPaymentTypes
                    where b.PaymentTypeName == Name
                    select b).FirstOrDefault();
        }

        public static int CountData()
        {
            return (from y in db.MsPaymentTypes
                    where y != null
                    select y).Count();
        }

        public static void InsertPaymentType(Int64 ID, String Name)
        {
            db.MsPaymentTypes.Add(FactoryMsPaymentType.InitPaymentType(ID, Name));
            db.SaveChanges();
        }

        public static MsPaymentType SearchPaymentByID(String ID)
        {
            return (from x in db.MsPaymentTypes
                    where x.PaymentTypeID == ID
                    select x).FirstOrDefault();
        }
        public static void DeletePayment(String ID)
        {
            MsPaymentType payment = SearchPaymentByID(ID);
            db.MsPaymentTypes.Remove(payment);
            db.SaveChanges();
        }
        public static void UpdatePaymentType(String ID,String PaymentName)
        {
            MsPaymentType payment = SearchPaymentByID(ID);
            payment.PaymentTypeName = PaymentName;
            db.SaveChanges();
        }
    }
}