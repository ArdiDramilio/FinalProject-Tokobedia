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
    public partial class ViewUser : System.Web.UI.Page
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
                    LabelRole1.Visible = false;
                    BoxUpdateRole.Visible = false;
                    BtnUpdateRole.Visible = false;
                    GridView1.DataSource = ViewUserController.FetchDetailUser();
                    GridView1.DataBind();
                }
            }
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String UserID = Session["LoginSession"].ToString();
            if (e.CommandName == "ToggleStatus")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text;
                Response response = ViewUserController.ToggleStatus(ID,UserID);
                if (response.successStatus == false)
                {
                    LabelViewUser.Text = response.message;
                }
                else
                {
                    Response.Redirect("ViewUser.aspx");
                }
            }
            if (e.CommandName == "ChangeRole")
            {
                int Row = 0;
                Row = Convert.ToInt16(e.CommandArgument.ToString());
                String ID = GridView1.Rows[Row].Cells[0].Text.ToString();
                LabelViewUser.Text = ID;
                LabelRole1.Visible = true;
                BoxUpdateRole.Visible = true;
                BtnUpdateRole.Visible = true;
            }
        }

        protected void BtnUpdateRole_Click(object sender, EventArgs e)
        {
            String UserIDLogin = Session["LoginSession"].ToString();
            String UserID = LabelViewUser.Text.ToString();
            String Role = BoxUpdateRole.Text.ToString();
            Response response = ViewUserController.ChangeRole(UserID, Role, UserIDLogin);
            if (response.successStatus == false)
            {
                LabelViewUser.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewUser.aspx");
            }
        }
    }
}