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
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
            else
            {
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                if (user.RoleID != "RL1")
                {
                    Response.Redirect("../HomeView/Home.aspx");
                }
                else
                {
                    if(Request.QueryString["id"] == null)
                    {
                        Response.Redirect("../HomeView/Home.aspx");
                    }
                    else
                    {
                        if (!IsPostBack)
                        {
                            String ProductID = Request.QueryString["id"];
                            MsProduct product = UpdateProductController.GetProductByID(ProductID);
                            BoxProductName.Text = product.ProductName.ToString();
                            BoxProductPrice.Text = product.ProductPrice.ToString();
                            BoxProductStock.Text = product.ProductStock.ToString();
                        }
                    }
                }
            }
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            String ProductID = Request.QueryString["id"];
            String Name = BoxProductName.Text.ToString();
            int Stock = 0;
            int Price = 0;
            if (int.TryParse(BoxProductStock.Text.ToString(), out Stock) == true)
            {
                Stock = int.Parse(BoxProductStock.Text.ToString());
            }
            if (int.TryParse(BoxProductPrice.Text.ToString(), out Price) == true)
            {
                Price = int.Parse(BoxProductPrice.Text.ToString());
            }
            Response response = UpdateProductController.UpdateItem(ProductID, Name, Price, Stock);
            if (response.successStatus == false)
            {
                labelUpdateProduct.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewProduct.aspx");
            }
        }
    }
}