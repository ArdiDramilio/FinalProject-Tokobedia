using Projek.Controller;
using Projek.Helpers;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek.View
{
    public partial class AddToCart2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
            else if (Request.QueryString["id"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
            else
            {
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                if (user.RoleID != "RL2")
                {
                    Response.Redirect("../HomeView/Home.aspx");
                }
                else
                {
                    String ProductID = Request.QueryString["id"];
                    MsProduct product = AddToCartController.FetchDataByID(ProductID);
                    MsProductType type = AddToCartController.GetProductType(product.ProductTypeID);
                    LabelProductName.Text = product.ProductName.ToString();
                    LabelProductStock.Text = product.ProductStock.ToString();
                    LabelProductPrice.Text = product.ProductPrice.ToString();
                    LabelProductType.Text = type.ProductTypeName.ToString();

                }
            }
           
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            int Qty = 0;
            Response response;
            String UserID = Session["LoginSession"].ToString();
            String ProductID = Request.QueryString["id"];

            if (int.TryParse(BoxQuantity.Text.ToString(),out Qty) == true)
            {
                Qty = int.Parse(BoxQuantity.Text.ToString());
                response = AddToCartController.DoAddCart(UserID, ProductID, Qty);
            }
            else
            {
                response = new Response(false, "Must be Numeric");
            }

            if (response.successStatus == false)
            {
                LabelAddToCart.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewCart.aspx");
            }
        }
    }
}