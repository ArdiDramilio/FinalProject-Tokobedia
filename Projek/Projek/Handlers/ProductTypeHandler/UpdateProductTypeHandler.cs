using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class UpdateProductTypeHandler
    {
        public static MsProductType SearchProductType(String ID)
        {
            return Repository.RepositoryMsProductType.SearchTypeByID(ID);
        }
        public static Response UpdateProductType(String ID, String TypeName, String Desc)
        {
            MsProductType type = Repository.RepositoryMsProductType.SearchTypeByName(TypeName);
            if (type != null)
            {
                return new Response(false, "Product Type Name Must be Unique");
            }
            Repository.RepositoryMsProductType.UpdateType(ID, TypeName, Desc);
            return new Response(true);
        }
    }
}