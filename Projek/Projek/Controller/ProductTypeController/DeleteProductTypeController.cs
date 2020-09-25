using Projek.Handlers;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Controller.ProductTypeController
{
    public class DeleteProductTypeController
    {
        public static Response DeleteProductType(String ID)
        {
            return DeleteProductTypeHandler.DeleteProductType(ID);
        }
    }
}