using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class InsertProductTypeHandler
    {
        public static Response DoInsertProductType(Int64 ID, String Name, String Description)
        {
            MsProductType type = Repository.RepositoryMsProductType.SearchTypeByName(Name);
            if (type != null)
            {
                return new Response(false, "Product Type Name Must be Unique");
            }
            Repository.RepositoryMsProductType.InsertType(ID, Name, Description);
            return new Response(true);
        }
        public static int CountData()
        {
            int ID = Repository.RepositoryMsProductType.CountData();
            return ID;
        }
    }
}