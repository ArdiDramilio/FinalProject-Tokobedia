using Projek.Controller;
using Projek.Helpers;
using Projek.Model;
using Projek.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek.View
{
    public partial class UpdateCart : System.Web.UI.Page
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
                if (user.RoleID != "RL2")
                {
                    Response.Redirect("../HomeView/Home.aspx");
                }
                else
                {
                    if (!IsPostBack)
                    {
                        String ProductID = Request.QueryString["id"];
                        DetailCart cart = UpdateCartController.GetCart(ID, ProductID);
                        LabelProductName.Text = cart.ProductName.ToString();
                        LabelProductPrice.Text = cart.ProductPrice.ToString();
                        BoxQuantity.Text = cart.ProductQuantity.ToString();
                    }
                }
            }
        }

        protected void BtnUpdateCart_Click(object sender, EventArgs e)
        {
            String ID = Session["LoginSession"].ToString();
            String ProductID = Request.QueryString["id"];
            int Qty;
            Response response;
            if (int.TryParse(BoxQuantity.Text.ToString(), out Qty) == true)
            {
                Qty = int.Parse(BoxQuantity.Text.ToString());
                response = UpdateCartController.UpdateCart(ID, ProductID, Qty);
            }
            else
            {
                response = new Response(false, "Must be Numeric");
            }

            if (response.successStatus == false)
            {
                LabelUpdateCart.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewCart.aspx");
            }
        }
    }
}