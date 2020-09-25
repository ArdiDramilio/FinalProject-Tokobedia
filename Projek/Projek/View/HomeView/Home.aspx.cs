using Projek.Controller;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnViewProfile.Visible = false;
            BtnViewUser.Visible = false;
            BtnInsertProduct.Visible = false;
            BtnUpdateProduct.Visible = false;
            BtnViewPaymentType.Visible = false;
            BtnInsertPaymentType.Visible = false;
            BtnUpdatePaymentType.Visible = false;
            BtnViewProductType.Visible = false;
            BtnInsertProductType.Visible = false;
            BtnUpdateProductType.Visible = false;
            BtnViewTransactionReport.Visible = false;
            BtnViewCart.Visible = false;
            BtnViewTransactionHistory.Visible = false;
            GridView1.Columns[5].Visible = false;
            if (!IsPostBack)
            {
                GridView1.DataSource = HomeController.FetchDataRandom();
                GridView1.DataBind();
            }

            if(Session["LoginSession"] != null)
            {
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                if (user.RoleID == "RL1")
                {
                    BtnViewProfile.Visible = true;
                    BtnViewUser.Visible = true;
                    BtnInsertProduct.Visible = true;
                    BtnUpdateProduct.Visible = true;
                    BtnViewPaymentType.Visible = true;
                    BtnInsertPaymentType.Visible = true;
                    BtnUpdatePaymentType.Visible = true;
                    BtnViewProductType.Visible = true;
                    BtnInsertProductType.Visible = true;
                    BtnUpdateProductType.Visible = true;
                    BtnViewTransactionReport.Visible = true;
                    BtnViewTransactionHistory.Visible = true;
                }
                else if (user.RoleID == "RL2")
                {
                    BtnViewProfile.Visible = true;
                    BtnViewTransactionHistory.Visible = true;
                    BtnViewCart.Visible = true;
                    GridView1.Columns[5].Visible = true;
                }
            }
        }

        protected void BtnViewProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProductView/ViewProduct.aspx");
        }

        protected void BtnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProfileView/ViewProfile.aspx");
        }

        protected void BtnViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProfileView/ViewUser.aspx");
        }

        protected void BtnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProductView/InsertProduct.aspx");
        }

        protected void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProductView/UpdateProduct.aspx");
        }

        protected void BtnViewPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PaymentTypeView/ViewPaymentType.aspx");
        }

        protected void BtnInsertPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PaymentTypeView/InsertPaymentType.aspx");
        }

        protected void BtnUpdatePaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PaymentTypeView/UpdatePaymentType.aspx");
        }

        protected void BtnViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProductTypeView/ViewProductType.aspx");
        }

        protected void BtnInsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProductTypeView/InsertProductType.aspx");
        }

        protected void BtnUpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ProductTypeView/UpdateProductType.aspx");
        }

        protected void BtnViewTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("../TransactionView/TransactionReport.aspx");
        }

        protected void BtnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("../CartView/ViewCart.aspx");
        }

        protected void BtnViewTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("../TransactionView/TransactionHistory.aspx");
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
        }
    }
}