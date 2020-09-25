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
    public partial class InsertPaymentType : System.Web.UI.Page
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

        protected void BtnInsertPaymentType_Click(object sender, EventArgs e)
        {
            String Name = BoxPaymentTypeName.Text.ToString();
            int ID = InsertPaymentTypeController.CountData() + 1;
            Response response = InsertPaymentTypeController.DoInsertPaymentType(ID, Name);
            if (response.successStatus == false)
            {
                LabelInsertPaymentType.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewPaymentType.aspx");
            }
        }
    }
}