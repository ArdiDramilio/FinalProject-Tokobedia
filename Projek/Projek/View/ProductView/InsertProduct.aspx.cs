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
    public partial class InsertProduct : System.Web.UI.Page
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
                    GridView1.DataSource = ViewProductTypeController.FetchFromDB();
                    GridView1.DataBind();
                }
            }
        }

        protected void BtnInsertProduct_Click(object sender, EventArgs e)
        {
            String Name = BoxProductName.Text;
            int Stock=0;
            int Price=0;
            if (int.TryParse(BoxProductStock.Text.ToString(), out Stock) == true)
            {
                Stock = int.Parse(BoxProductStock.Text.ToString());
            }       
            if (int.TryParse(BoxProductPrice.Text.ToString(), out Price) == true)
            {
                Price = int.Parse(BoxProductPrice.Text.ToString());
            }

            String TypeID = BoxTypeID.Text;
            int ID = InsertProductController.CountData() + 1;
            Response response = InsertProductController.DoInsertProduct(TypeID, Name, Price, Stock, ID);
            if (response.successStatus == false)
            {
                LabelInsertProduct.Text = response.message;
            }
            else
            {
                Response.Redirect("ViewProduct.aspx");
            }
        }
    }
}