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
    public partial class InsertProductType : System.Web.UI.Page
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
            }
        }

        protected void BtnUpdateProductType_Click(object sender, EventArgs e)
        {
            String Name = BoxTypeName.Text.ToString();
            String Description = BoxDescription.Text.ToString();
            int ID = InsertProductTypeController.CountData() + 1;
            Response response = InsertProductTypeController.DoInsertProductType(ID, Name, Description);
            if (response.successStatus == false)
            {
                LabelInsertProduct.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}