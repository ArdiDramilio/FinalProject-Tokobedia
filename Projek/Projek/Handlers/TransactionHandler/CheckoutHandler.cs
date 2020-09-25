using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class CheckoutHandler
    {
        public static void DoCheckout(String UserID,String PaymentID)
        {
            int numbercart = Repository.RepositoryCart.CountCart(UserID);
            int ID = Repository.RepositoryHeaderTransaction.CountHeeader();
            Repository.RepositoryHeaderTransaction.InsertHeader(ID, UserID, PaymentID);

            for (int i = 0; i < numbercart; i++)
            {
                MsCart cart = Repository.RepositoryCart.SearchUserCart(UserID);
                String TransactionID = "TR" + ID;
                String ProductID = cart.ProductID;
                int Quantity = cart.Quantity;

                Repository.RepositoryDetailTransaction.insertDetail(TransactionID, ProductID, Quantity);
                Repository.RepositoryCart.DeleteProduct(UserID, ProductID);
                Repository.RepositoryMsProduct.UpdateStockProduct(ProductID, cart.Quantity);
                
            } 
        }
    }
}