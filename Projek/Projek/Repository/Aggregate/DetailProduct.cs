using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository.Aggregate
{
    public class DetailProduct
    {
        public string ProductID { get; internal set; }
        public string ProductName { get; internal set; }
        public int ProductStock { get; internal set; }
        public string ProductType { get; internal set; }
        public int ProductPrice { get; internal set; }
    }
}