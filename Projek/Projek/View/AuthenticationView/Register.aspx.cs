using Projek.Controller;
using Projek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projek.View
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginSession"] != null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
        }

        protected void BtnInsertRegister_Click(object sender, EventArgs e)
        {
            String Name = RegisNama.Text.ToString();
            String Email = RegisEmail.Text.ToString();
            String Password = RegisPassword.Text.ToString();
            String ConfirmPassword = ConfirmPass.Text.ToString();
            String Gender = RegisGender.Text.ToString();
            int ID = RegisterController.CountData()+1;
            Response response = RegisterController.DoRegister(Name, Email, Password, ConfirmPassword, Gender, ID);
            if (response.successStatus == false)
            {
                LabelRegister.Text = response.message;
            }
            else
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
        }
    }
}