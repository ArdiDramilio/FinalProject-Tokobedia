using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class InsertProductHandler
    {
        public static Response DoInsertProduct(String TypeID, String Name, int Price, int Stock, Int64 ID)
        {
            MsProductType type = Repository.RepositoryMsProductType.SearchTypeByID(TypeID);
            if (type == null)
            {
                return new Response(false, "Type ID Cannot Found");
            }
            Repository.RepositoryMsProduct.InsertProduct(TypeID, Name, Price, Stock, ID);
            return new Response(true);
        }
        public static int CountData()
        {
            int ID = Repository.RepositoryMsProduct.CountData();
            return ID;
        }
    }
}