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
    public partial class ViewCart : System.Web.UI.Page
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
                    GridView2.Visible = false;
                    LabelChoose.Visible = false;
                    List<DetailCart> Cart = ViewCartController.ViewCart(ID);
                    if (Cart.Count != 0)
                    {
                        GridView1.DataSource = Cart;
                        GridView1.DataBind();
                        GridView1.FooterRow.Cells[3].Text = "GrandTotal";
                        int GrandTotal = 0;
                        for (int i = 0; i < GridView1.Rows.Count; i++)
                        {
                            GrandTotal += int.Parse(GridView1.Rows[i].Cells[4].Text);
                        }
                        GridView1.FooterRow.Cells[4].Text = GrandTotal.ToString();
                    }
                    else
                    {
                        LabelViewCart.Text = "Cart Is Empty";
                        BtnCheckout.Visible = false;
                    }
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String UserID = Session["LoginSession"].ToString();
            if (e.CommandName=="UpdateProduct")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                Response.Redirect("UpdateCart.aspx?id=" + ID);

            }
            if (e.CommandName == "DeleteProduct")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                DeleteProductCartController.DoDeleteProductCart(UserID, ID);
                Response.Redirect("ViewCart.aspx");
            }
        }

        protected void BtnCheckout_Click(object sender, EventArgs e)
        {
            GridView2.Visible = true;
            LabelChoose.Visible = true;
            GridView2.DataSource = ViewPaymentTypeController.FetchDataPaymentType();
            GridView2.DataBind();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectPaymentType")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String PaymentID = GridView2.Rows[Row].Cells[0].Text.ToString();
                String UserID = Session["LoginSession"].ToString();
                CheckoutController.DoCheckout(UserID,PaymentID);
                Response.Redirect("ViewCart.aspx");
            }
        }
    }
}