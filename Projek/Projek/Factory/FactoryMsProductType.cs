using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryMsProductType
    {
        public static MsProductType InitProductType(Int64 ID, String Name, String Desc)
        {
            MsProductType ProductType = new MsProductType();
            ProductType.ProductTypeID = "PT" + ID;
            ProductType.ProductTypeName = Name;
            ProductType.ProductTypeDescription = Desc;
            return ProductType;
        }
    }
}