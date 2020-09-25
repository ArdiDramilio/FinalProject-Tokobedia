using Projek.Controller;
using Projek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek
{
    public partial class HomeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                BtnLogout.Visible = false;
            }
            else
            {
                String ID = Session["LoginSession"].ToString();
                MsUser user = HomeController.FetchDataForHome(ID);
                LabelNama.Text = user.UserName;
                BtnLogout.Visible = true;
                BtnLogin.Visible = false;
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../AuthenticationView/Login.aspx");

        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Cookies["email"].Expires = DateTime.Now.AddMonths(-1);
            Response.Cookies["pass"].Expires = DateTime.Now.AddMonths(-1);
            Response.Redirect("../HomeView/Home.aspx");
        }
    }
}