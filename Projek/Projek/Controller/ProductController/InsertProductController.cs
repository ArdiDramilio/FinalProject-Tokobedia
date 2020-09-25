using Projek.Handlers;
using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller
{
    public class InsertProductController
    {
        public static Response DoInsertProduct(String TypeID, String Name, int Price, int Stock, Int64 ID)
        {
            if (Name == "")
            {
                return new Response(false, "Product Name Cannot Be Empty");
            }
            if (Stock <=0)
            {
                return new Response(false, "Product Stock Must Be 1 Or More");
            }
            if (Price <=1000)
            {
                return new Response(false, "Product Price Must Be Above 1000 and Multiply of 1000");
            }
            if (Price %1000 !=0)
            {
                return new Response(false, "Product Price Must Be Above 1000 and Multiply of 1000");
            }
            if (TypeID == "")
            {
                return new Response(false, "Product Type ID Cannot Be Empty");
            }
            Response response = InsertProductHandler.DoInsertProduct(TypeID, Name, Price, Stock, ID);
            return response;
        }
        public static int CountData()
        {
            int ID = InsertProductHandler.CountData();
            return ID;
        }
    }
}