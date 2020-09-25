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
    public partial class UpdatePaymentType2 : System.Web.UI.Page
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
                    if (Request.QueryString["id"] == null)
                    {
                        Response.Redirect("../HomeView/Home.aspx");
                    }
                    else
                    {
                        if (!IsPostBack)
                        {
                            String PaymentTypeID = Request.QueryString["id"];
                            MsPaymentType payment = UpdatePaymentTypeController.GetPaymentType(PaymentTypeID);
                            BoxPaymentTypeName.Text = payment.PaymentTypeName;
                        }
                    }
                }
            }
        }

        protected void BtnUpdatePaymentType_Click(object sender, EventArgs e)
        {
            String PaymentTypeID = Request.QueryString["id"];
            String PaymentName = BoxPaymentTypeName.Text.ToString();
            Response response = UpdatePaymentTypeController.DoUpdatePaymentType(PaymentTypeID, PaymentName);
            if (response.successStatus == false)
            {
                LabelUpdatePaymentType.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewPaymentType.aspx");
            }
        }
    }
}