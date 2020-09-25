using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Factory
{
    public class FactoryMsProduct
    {
        public static MsProduct InitProduct(String TypeID, String Name, int Price, int Stock, Int64 ID)
        {
            MsProduct products = new MsProduct();
            products.ProductID = "PD" + ID;
            products.ProductTypeID = TypeID;
            products.ProductName = Name;
            products.ProductPrice = Price;
            products.ProductStock = Stock;

            return products;
        }
    }
}