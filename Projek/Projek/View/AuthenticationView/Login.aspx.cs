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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["email"] != null && Request.Cookies["pass"] != null)
                {
                    BoxEmailLogin.Text = Request.Cookies["email"].Value;
                    BoxPasswordLogin.Attributes["value"] = Request.Cookies["pass"].Value;
                    RememberMe.Checked = true;
                }
                else
                {
                    RememberMe.Checked = false;
                }
            }
              
            if (Session["LoginSession"] != null)
            {
                Response.Redirect("../HomeView/Home.aspx");
            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            String Email = BoxEmailLogin.Text;
            String Pass = BoxPasswordLogin.Text;
            Response response = LoginController.DoLogin(Email, Pass);
            if (response.successStatus == true)
            {
                Session["LoginSession"] = LoginController.AddSession(Email).UserID;
                if (RememberMe.Checked == true)
                {
                    Response.Cookies["email"].Value = null;
                    Response.Cookies["pass"].Value = null;
                    Response.Cookies["email"].Value = BoxEmailLogin.Text.ToString();
                    Response.Cookies["pass"].Value = BoxPasswordLogin.Text.ToString();
                    Response.Cookies["email"].Expires = DateTime.Now.AddMonths(3);
                    Response.Cookies["pass"].Expires = DateTime.Now.AddMonths(3);
                }
                else if (RememberMe.Checked == false)
                {
                    if (Request.Cookies["email"] != null && Request.Cookies["pass"] != null)
                    {
                        if (Request.Cookies["email"].Value == BoxEmailLogin.Text.ToString() && Request.Cookies["pass"].Value == BoxPasswordLogin.Text.ToString())
                        {
                            Response.Cookies["email"].Expires = DateTime.Now.AddMonths(-1);
                            Response.Cookies["pass"].Expires = DateTime.Now.AddMonths(-1);
                            RememberMe.Checked = false;
                        }
                    }
                }
                Response.Redirect("../HomeView/Home.aspx");
            }
            else
            {
                LabelMessage.Text = response.message;
            }
        }
    }
}