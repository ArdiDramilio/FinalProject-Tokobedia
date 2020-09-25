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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }    
        }

        protected void BtnChangePassword_Click(object sender, EventArgs e)
        {
            String OldPass = UpdateOldPassword.Text.ToString();
            String NewPass = UpdateNewPassword.Text.ToString();
            String ConfirmPass = UpdateConfirmPassword.Text.ToString();
            String UserID = Session["LoginSession"].ToString();
            Response response = UpdateProfileController.DoChangePassword(UserID, OldPass, NewPass, ConfirmPass);
            if (response.successStatus == false)
            {
                LabelChangePassword.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewProfile.aspx");
            }
        }
    }
}