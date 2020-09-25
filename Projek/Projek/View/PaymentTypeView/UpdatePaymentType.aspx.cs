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
    public partial class UpdatePaymentType : System.Web.UI.Page
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
                    GridView1.DataSource = ViewPaymentTypeController.FetchDataPaymentType();
                    GridView1.DataBind();
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "UpdatePaymentType")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                Response.Redirect("UpdatePaymentType2.aspx?id=" + ID);
            }
        }
    }
}