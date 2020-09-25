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
    public partial class UpdateProductType : System.Web.UI.Page
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
                            String ProductTypeID = Request.QueryString["id"];
                            MsProductType type = UpdateProductTypeController.SearchProductType(ProductTypeID);
                            BoxTypeName.Text = type.ProductTypeName.ToString();
                            BoxDescription.Text = type.ProductTypeDescription.ToString(); 
                        }
                    }
                }
            }
        }

        protected void BtnUpdateProductType_Click(object sender, EventArgs e)
        {
            String ProductTypeID = Request.QueryString["id"];
            String ProductTypeName = BoxTypeName.Text.ToString();
            String ProductTypeDesc = BoxDescription.Text.ToString();
            Response response = UpdateProductTypeController.UpdateProductType(ProductTypeID, ProductTypeName, ProductTypeDesc);
            if (response.successStatus == false)
            {
                LabelUpdateProduct.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewProductType.aspx");
            }
        }
    }
}