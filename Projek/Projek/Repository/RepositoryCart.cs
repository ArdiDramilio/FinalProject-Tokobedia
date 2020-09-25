using Projek.Factory;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryCart
    {
        private static TokobediaEntities db = new TokobediaEntities();
        public static int GetServedQty(String ProductID)
        {
            MsCart temp = (from x in db.MsCarts
                           where x.ProductID == ProductID
                           select x).FirstOrDefault();
            if (temp != null)
            {
                return (from x in db.MsCarts
                        where x.ProductID == ProductID
                        select x.Quantity).Sum();
            }
            else
            {
                return 0;
            }

        }
        public static MsCart SearchCart(String UserID,String ProductID)
        {
            return (from x in db.MsCarts
                    where x.UserID == UserID && x.ProductID==ProductID
                    select x).FirstOrDefault();
        }
        public static int CountCart(String UserID)
        {
            return (from x in db.MsCarts
                    where x.UserID == UserID
                    select x).Count();

        }
        public static MsCart SearchUserCart(String UserID)
        {
            return (from x in db.MsCarts
                    where x.UserID == UserID
                    select x).FirstOrDefault();
        }
        public static void InsertCart(String UserID, String ProductID,int qty)
        {
            db.MsCarts.Add(FactoryMsCart.InitCart(UserID, ProductID, qty));
            db.SaveChanges();
        }
        public static void AppendCart(String UserID, String ProductID, int qty)
        {
            MsCart cart = SearchCart(UserID, ProductID);
            cart.Quantity = cart.Quantity + qty;
            db.SaveChanges();
        }
        public static List<DetailCart> FetchDataCart(String UserID)
        {
            return (from x in db.MsCarts
                    join y in db.MsProducts
                    on x.ProductID equals y.ProductID
                    where x.UserID  == UserID
                    orderby x.ProductID ascending
                    select new DetailCart
                    {
                        ProductID = x.ProductID,
                        ProductName = y.ProductName,
                        ProductPrice = y.ProductPrice,
                        ProductQuantity = x.Quantity,
                        ProductSubTotal = x.Quantity * y.ProductPrice
                    }).ToList();
        }
        public static void DeleteProduct(String UserID,String ProductID)
        {
            MsCart cart = SearchCart(UserID, ProductID);
            db.MsCarts.Remove(cart);
            db.SaveChanges();
        }
        public static DetailCart GetDataCart(String UserID,String ProductID)
        {
            return (from x in db.MsCarts
                    join y in db.MsProducts
                    on x.ProductID equals y.ProductID
                    where x.UserID == UserID && x.ProductID==ProductID
                    select new DetailCart
                    {
                        ProductID = x.ProductID,
                        ProductName = y.ProductName,
                        ProductPrice = y.ProductPrice,
                        ProductQuantity = x.Quantity,
                        ProductSubTotal = x.Quantity * y.ProductPrice
                    }).FirstOrDefault();
        }
        public static void UpdateCart(String ProductID,String UserID,int Quantity)
        {
            MsCart cart = SearchCart(UserID, ProductID);
            cart.Quantity = Quantity;
            db.SaveChanges();
        }
    }
}