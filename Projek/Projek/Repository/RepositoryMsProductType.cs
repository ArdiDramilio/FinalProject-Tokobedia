using Projek.Factory;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryMsProductType
    {
        private static TokobediaEntities db = new TokobediaEntities();
        public static MsProductType SearchTypeByID(String ID)
        {
            return (from b in db.MsProductTypes
                    where b.ProductTypeID == ID
                    select b).FirstOrDefault();
        }
        public static List<DetailProductType> FetchData()
        {
            return (from x in db.MsProductTypes
                    select new DetailProductType
                    {
                        ProductTypeID = x.ProductTypeID,
                        ProductTypeName = x.ProductTypeName,
                        ProductTypeDesc = x.ProductTypeDescription
                    }).ToList();
        }
        public static void DeleteType(String ID)
        {
            MsProductType product = SearchTypeByID(ID);
            db.MsProductTypes.Remove(product);
            db.SaveChanges();
        }
        public static void UpdateType(String ID, String TypeName, String Desc)
        {
            MsProductType product = SearchTypeByID(ID);
            product.ProductTypeName = TypeName;
            product.ProductTypeDescription = Desc;
            db.SaveChanges();
        }
        public static MsProductType SearchTypeByName(String Name)
        {
            return (from b in db.MsProductTypes
                    where b.ProductTypeName == Name
                    select b).FirstOrDefault();
        }
        public static void InsertType(Int64 ID, String TypeName, String Desc)
        {
            db.MsProductTypes.Add(FactoryMsProductType.InitProductType(ID, TypeName, Desc));
            db.SaveChanges();
        }
        public static int CountData()
        {
            return (from y in db.MsProductTypes
                    where y != null
                    select y).Count();
        }
    }
}