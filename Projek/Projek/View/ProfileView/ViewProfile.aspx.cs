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
    public partial class ViewProfile : System.Web.UI.Page
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
                LabelName.Text = user.UserName;
                LabelGender.Text = user.UserGender;
                LabelEmail.Text = user.UserEmail;
            }
        }

        protected void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}