using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class ViewCartHandler
    {
        public static List<DetailCart> ViewCart(String UserID)
        {
            return Repository.RepositoryCart.FetchDataCart(UserID);
        }
    }
}