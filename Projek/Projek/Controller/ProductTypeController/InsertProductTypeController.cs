using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class InsertProductTypeController
    {
        public static Response DoInsertProductType(Int64 ID, String Name, String Description)
        {
            if (Name == "")
            {
                return new Response(false, "Product Type Name Cannot Be Empty");
            }
            if (Name.Length < 5)
            {
                return new Response(false, "Product Type Name Consists of 5 Characters or More");
            }
            if (Description == "")
            {
                return new Response(false, "Product Type Description Cannot Be Empty");
            }
            Response response = InsertProductTypeHandler.DoInsertProductType(ID, Name, Description);
            return response;
        }
        public static int CountData()
        {
            int ID = InsertProductTypeHandler.CountData();
            return ID;
        }
    }
}