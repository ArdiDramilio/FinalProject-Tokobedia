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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] == null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    String ID = Session["LoginSession"].ToString();
                    MsUser user = HomeController.FetchDataForHome(ID);
                    UpdateNama.Text = user.UserName;
                    UpdateEmail.Text = user.UserEmail;
                    UpdateGender.Text = user.UserGender;
                }
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            String Name = UpdateNama.Text.ToString();
            String Email = UpdateEmail.Text.ToString();
            String Gender = UpdateGender.Text.ToString();
            String UserID = Session["LoginSession"].ToString();
            Response response = UpdateProfileController.DoUpdateProfile(UserID,Name,Email,Gender);
            if (response.successStatus == false)
            {
                LabelUpdateProfile.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewProfile.aspx");
            }
        }
    }
}