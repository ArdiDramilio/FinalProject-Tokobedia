using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class UpdateProductTypeController
    {
        public static MsProductType SearchProductType(String ID)
        {
            return UpdateProductTypeHandler.SearchProductType(ID);
        }
        public static Response UpdateProductType(String ID, String TypeName, String Desc)
        {
            if (TypeName == "")
            {
                return new Response(false, "Product Type Name Cannot Empty");
            }
            if (TypeName.Length < 5)
            {
                return new Response(false, "Product Type Name Must Consist of 5 Characters Or More");
            }
            if (Desc == "")
            {
                return new Response(false, "Product Type Description Cannot Empty");
            }
            return UpdateProductTypeHandler.UpdateProductType(ID, TypeName, Desc);
        }
    }
}