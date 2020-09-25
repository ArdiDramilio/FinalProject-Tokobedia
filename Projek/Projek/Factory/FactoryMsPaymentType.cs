using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryMsPaymentType
    {
        public static MsPaymentType InitPaymentType(Int64 ID, String Name)
        {
            MsPaymentType paymenttypes = new MsPaymentType();
            paymenttypes.PaymentTypeID = "PY" + ID;
            paymenttypes.PaymentTypeName = Name;

            return paymenttypes;
        }
    }
}