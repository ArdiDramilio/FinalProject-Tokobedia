using Projek.Factory;
using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryMsProduct
    {
        private static TokobediaEntities db = new TokobediaEntities();
        public static void InsertProduct(String TypeID, String Name, int Price, int Stock, Int64 ID)
        {
            db.MsProducts.Add(FactoryMsProduct.InitProduct(TypeID,Name,Price,Stock,ID));
            db.SaveChanges();
        }
        public static int CountData()
        {
            return (from y in db.MsProducts
                    where y.ProductID != null
                    select y).Count();
        }
        public static int CountAvailableData()
        {
            return (from y in db.MsProducts
                    where y.ProductID != null && y.ProductStock > 0
                    select y).Count();
        }
        public static List<DetailProduct> FetchDataProduct()
        {
            return (from x in db.MsProducts
                    join y in db.MsProductTypes
                    on x.ProductTypeID equals y.ProductTypeID
                    where x.ProductStock > 0
                    orderby x.ProductID ascending
                    select new DetailProduct
                    {
                        ProductID = x.ProductID,
                        ProductName = x.ProductName,
                        ProductStock = x.ProductStock,
                        ProductType = y.ProductTypeName,
                        ProductPrice = x.ProductPrice
                    }).ToList();
        }
        public static List<DetailProduct> FetchDataProductForAdmin()
        {
            return (from x in db.MsProducts
                    join y in db.MsProductTypes
                    on x.ProductTypeID equals y.ProductTypeID
                    orderby x.ProductID ascending
                    select new DetailProduct
                    {
                        ProductID = x.ProductID,
                        ProductName = x.ProductName,
                        ProductStock = x.ProductStock,
                        ProductType = y.ProductTypeName,
                        ProductPrice = x.ProductPrice
                    }).ToList();
        }
        public static MsProduct SearchProductByID(String ID)
        {
            return (from x in db.MsProducts
                    where x.ProductID == ID
                    select x).FirstOrDefault();
        }
        public static MsProduct SearchProductByTypeID(String ID)
        {
            return (from x in db.MsProducts
                    where x.ProductTypeID == ID
                    select x).FirstOrDefault();
        }
        public static void DeleteProduct(String ID)
        {
            MsProduct product = SearchProductByID(ID);
            db.MsProducts.Remove(product);
            db.SaveChanges();

        }
        public static List<DetailProduct> FetchDataRandom(String ran1,String ran2,String ran3,String ran4,String ran5)
        {

            return (from x in db.MsProducts
                    join y in db.MsProductTypes
                    on x.ProductTypeID equals y.ProductTypeID
                    where x.ProductID == ran5 || x.ProductID == ran2 || x.ProductID == ran1 || x.ProductID == ran4 || x.ProductID == ran3
                    select  new DetailProduct
                    {
                        ProductID = x.ProductID,
                        ProductName = x.ProductName,
                        ProductStock = x.ProductStock,
                        ProductType = y.ProductTypeName,
                        ProductPrice = x.ProductPrice
                    }).ToList();
        }
        public static void UpdateProduct(String ID, String Name, int Price, int Stock)
        {
            MsProduct product = SearchProductByID(ID);
            product.ProductName = Name;
            product.ProductPrice = Price;
            product.ProductStock = Stock;
            db.SaveChanges();
        }
        public static void UpdateStockProduct(String ID, int Stock)
        {
            MsProduct product = SearchProductByID(ID);
            product.ProductStock = product.ProductStock - Stock;
            db.SaveChanges();
        }
    }
}