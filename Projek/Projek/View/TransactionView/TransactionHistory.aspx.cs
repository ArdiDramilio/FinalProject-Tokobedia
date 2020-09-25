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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
            else
            {
                BtnReport.Visible = false;
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                if (user.RoleID == "RL1")
                {
                    GridView1.DataSource = HistoryTransactionController.GetAllHistory();
                    GridView1.DataBind();
                    BtnReport.Visible = true;
                }
                else if(user.RoleID == "RL2")
                {
                    GridView1.DataSource = HistoryTransactionController.GetUserHistory(ID);
                    GridView1.DataBind();
                }
                else
                {
                    Response.Redirect("../HomeView/Home.aspx");
                }
            }
        }

        protected void BtnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionReport.aspx");
        }
    }
}