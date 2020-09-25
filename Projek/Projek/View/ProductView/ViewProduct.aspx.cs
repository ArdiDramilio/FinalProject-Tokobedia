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
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnInsertProduct.Visible = false;            
            GridView1.Columns[7].Visible = false;
            GridView1.Columns[6].Visible = false;
            GridView1.Columns[5].Visible = false;
            GridView1.DataSource = ViewProductController.FetchDataProduct();
            GridView1.DataBind();

            if (Session["LoginSession"] != null)
            {
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                if (user.RoleID == "RL1")
                {
                    GridView1.Columns[6].Visible = true;
                    GridView1.Columns[5].Visible = true;
                    BtnInsertProduct.Visible = true;
                    GridView1.DataSource = ViewProductController.FetchDataProductForAdmin();
                    GridView1.DataBind();
                }
                else if (user.RoleID == "RL2")
                {
                    GridView1.Columns[7].Visible = true;
                }
            }
            
        }

        protected void BtnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("../CartView/AddToCart.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                Response.Redirect("../CartView/AddToCart.aspx?id=" + ID);
            }
            if (e.CommandName == "UpdateProduct")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                Response.Redirect("UpdateProduct2.aspx?id=" + ID);
            }
            if (e.CommandName == "DeleteProduct")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                Response response = DeleteProductController.DoDeleteProduct(ID);
                if (response.successStatus == false)
                {
                    LabelViewProduct.Text = response.message;
                }
                else
                {
                    Response.Redirect("ViewProduct.aspx");
                }
            }
        }
    }
}